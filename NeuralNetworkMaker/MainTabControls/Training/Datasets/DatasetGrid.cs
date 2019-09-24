using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System;
using NeuralNetwork.Visualizer.Preferences;
using NeuralNetwork.Visualizer.Preferences.Brushes;
using NeuralNetwork.Model.Layers;
using System.Collections.Generic;
using NeuralNetwork.Model.Nodes;
using NeuralNetworkMaker.MainTabControls.Training.Datasets.ColumnsLoader;

namespace NeuralNetworkMaker.MainTabControls.Training.Datasets
{
   public partial class DatasetGrid : UserControl
   {
      public DatasetGrid()
      {
         InitializeComponent();

         tabTraining.Tag = gridTraining;
         tabValidation.Tag = gridValidation;
         tabTest.Tag = gridTest;
      }

      [Browsable(false)]
      public InputLayer InputLayer { get; set; }

      private void DatasetGrid_Load(object sender, EventArgs e)
      {

      }

      public void LoadDataset(DataTable<string> rawDataTable)
      {
         ResetGrids();

         LoadColumns(rawDataTable);

         var parts = rawDataTable.SplitRows(60, 20, 20);

         LoadRows(gridTraining, parts.Training);
         LoadRows(gridValidation, parts.Validation);
         LoadRows(gridTest, parts.Test);
      }

      public Dataset GetDataset()
      {
         return null;
      }

      private void LoadColumns(DataTable<string> rawDataTable)
      {
         var columns = GetDatatsetColumns(rawDataTable);

         SuspendLayout();

         foreach (var column in columns)
         {
            AddColumn(column);
         }

         ResumeLayout();
      }

      private void ResetGrids()
      {
         SuspendLayout();

         gridTraining.Columns.Clear();
         gridValidation.Columns.Clear();
         gridTest.Columns.Clear();

         ResumeLayout();
      }

      private IEnumerable<string> GetDatatsetColumns(DataTable<string> rawDataTable)
      {
         var columnLoader = new DatasetColumnLoader(rawDataTable, new DatasetByRowColumnLoader(rawDataTable, new NeuralNetworkColumnLoader(this.InputLayer, new InvalidColumnLoader())));
         return columnLoader.GetColumns();
      }

      private void LoadRows(DataGridView grid, IEnumerable<string[]> rawRows)
      {
         grid.SuspendLayout();

         foreach (var row in rawRows)
         {
            AddRow(grid, row);
         }

         grid.ResumeLayout();
      }

      private void ResetControls()
      {
         toolInputColumnsCount.Maximum = gridTraining.ColumnCount - 1;
         toolInputColumnsCount.Value = 1;
         ChangeInputColumns();
      }

      private void EnableControls()
      {
         toolInputColumnsCount.Enabled = true;
      }

      private void ChangeInputColumns()
      {
         var count = (int)toolInputColumnsCount.Value;
         var colors = GetDefaultPreferenceColors();

         ChangeColumnHeadersStyle(0, count, colors.InputColor);
         ChangeColumnHeadersStyle(count, gridTraining.ColumnCount, colors.OutputColor);
      }

      private void ChangeColumnHeadersStyle(int from, int to, Color color)
      {
         var cellStyle = new DataGridViewCellStyle { BackColor = color };

         for (int i = from; i < to; i++)
         {
            var column = gridTraining.Columns[i];
            column.HeaderCell.Style = cellStyle;
         }
      }

      private void MatchColumnGridsFromNeuralNetwork()
      {
         if (this.InputLayer == null)
            return;

         var inputs = this.InputLayer.Nodes;
         var outputs = this.InputLayer.SearchOutputLayer().Nodes;

         MatchColumnsGridFromNeuralNetwork(gridTraining, inputs, outputs);
         MatchColumnsGridFromNeuralNetwork(gridValidation, inputs, outputs);
         MatchColumnsGridFromNeuralNetwork(gridTest, inputs, outputs);
      }

      private void MatchColumnsGridFromNeuralNetwork(DataGridView grid, IEnumerable<Input> inputs, IEnumerable<Neuron> outputs)
      {
         grid.Columns.Clear();

         AddColumnsByNodes(inputs);
         AddColumnsByNodes(outputs);

         toolInputColumnsCount.Value = inputs.Count();
      }
      private void AddColumnsByNodes(IEnumerable<NodeBase> nodes)
      {
         foreach (var node in nodes)
         {
            var colName = node.Id;
            gridTraining.Columns.Add(colName, colName);
         }
      }

      private (Color InputColor, Color OutputColor) GetDefaultPreferenceColors()
      {
         using (var preference = new Preference())
         {
            var inputColor = GetColor(preference.Inputs.Background);
            var outputColor = GetColor(preference.Neurons.Background);

            return (inputColor, outputColor);
         }
      }

      private Color GetColor(IBrush brush)
      {
         var solidBrush = brush.CreateBrush(Rectangle.Empty) as SolidBrush
                        ?? Brushes.LightGreen.Clone() as SolidBrush;

         return solidBrush.Color;
      }

      private int _editingColumn = -1;
      private void gridMain_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
      {
         _editingColumn = e.ColumnIndex;

         var rect = gridTraining.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

         txtColumnNameEditor.Location = new Point(rect.Location.X + gridTraining.Location.X + 2,
                                       rect.Location.Y + gridTraining.Location.Y + 3);

         var size = Size.Subtract(rect.Size, new Size(4, 4));

         txtColumnNameEditor.Multiline = true;
         txtColumnNameEditor.MaximumSize = size;
         txtColumnNameEditor.MinimumSize = size;
         txtColumnNameEditor.Size = size;
         txtColumnNameEditor.Multiline = false;

         txtColumnNameEditor.Text = gridTraining.Columns[e.ColumnIndex].HeaderText;
         txtColumnNameEditor.Visible = true;
         txtColumnNameEditor.Focus();
      }

      private void spinInputColumnsCount_ValueChanged(object sender, EventArgs e)
      {
         ChangeInputColumns();
      }

      private void txtColumnNameEditor_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
            gridTraining.Focus();
      }

      private void txtColumnNameEditor_Validating(object sender, CancelEventArgs e)
      {
         if (_editingColumn == -1)
            return;

         if (string.IsNullOrWhiteSpace(txtColumnNameEditor.Text))
         {
            MessageBox.Show("Column name cannot be empty", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            e.Cancel = true;
            return;
         }

         gridTraining.Columns[+_editingColumn].HeaderText = txtColumnNameEditor.Text;
         txtColumnNameEditor.Visible = false;
      }

      private void gridMain_SelectionChanged(object sender, EventArgs e)
      {
         toolRemoveRows.Enabled = gridTraining.SelectedRows.Count > 0;
         toolRemoveColumns.Enabled = gridTraining.SelectedColumns.Count > 0;
      }

      private void ToolMatchNeuralNetIO_Click(object sender, EventArgs e)
      {

      }

      private void AddRow(DataGridView grid, params object[] values)
      {
         grid.Rows.Add(values);
      }

      private void RemoveSelectedRows()
      {
         if (MessageBox.Show("Are you sure to remove the selected rows?", "Remove Rows", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            return;

         var grid = tabGrids.SelectedTab.Tag as DataGridView;
         var rows = grid.SelectedRows.Cast<DataGridViewRow>();

         grid.SuspendLayout();

         foreach (var row in rows)
         {
            grid.Rows.Remove(row);
         }

         grid.ResumeLayout();
      }

      private int columnCounter = 1;
      private void AddColumn()
      {
         var name = $"C_{columnCounter++}";
         AddColumn(name);
      }

      private void AddColumn(string name)
      {
         gridTraining.Columns.Add(name, name);
         gridValidation.Columns.Add(name, name);
         gridTest.Columns.Add(name, name);
      }

      private void RemoveSelectedColumns()
      {
         if (MessageBox.Show("Are you sure to remove the selected columns?", "Remove Columns", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            return;

         var grid = tabGrids.SelectedTab.Tag as DataGridView;

         var columnNames = grid.SelectedColumns
            .OfType<DataGridViewColumn>()
            .Select(c => c.Name);

         RemoveSelectedColumns(gridTraining, columnNames);
         RemoveSelectedColumns(gridValidation, columnNames);
         RemoveSelectedColumns(gridTest, columnNames);
      }

      private void RemoveSelectedColumns(DataGridView grid, IEnumerable<string> columnNames)
      {
         grid.SuspendLayout();

         foreach (var columnName in columnNames)
         {
            grid.Columns.Remove(columnName);
         }

         grid.ResumeLayout();
      }
   }
}
