using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System;
using NeuralNetwork.Visualizer.Preferences;
using NeuralNetwork.Visualizer.Preferences.Brushes;

namespace NeuralNetworkMaker.MainTabControls.Training.Datasets
{
   public partial class DatasetGrid : UserControl
   {
      private readonly Color _inputColumnColor;
      private readonly Color _outputColumnColor;

      public DatasetGrid()
      {
         InitializeComponent();

         (_inputColumnColor, _outputColumnColor) = GetDefaultPreferenceColors();
      }

      public void LoadDataset(DataTable<string> rawDataTable)
      {

      }

      public Dataset GetDataset()
      {
         return null;
      }

      private void ResetControls()
      {
         spinInputColumnsCount.Maximum = gridTraining.ColumnCount - 1;
         spinInputColumnsCount.Value = 1;
         ChangeInputColumns();
      }

      private void EnableControls()
      {
         spinInputColumnsCount.Enabled = true;
      }

      private void ChangeInputColumns()
      {
         var count = (int)spinInputColumnsCount.Value;

         ChangeColumnHeadersStyle(0, count, _inputColumnColor);
         ChangeColumnHeadersStyle(count, gridTraining.ColumnCount, _outputColumnColor);
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

      private void MatchColumnsGrid(int lineValuesCount)
      {
         if (gridTraining.ColumnCount >= lineValuesCount)
            return;

         var diff = lineValuesCount - gridTraining.ColumnCount;
         var colNum = gridTraining.ColumnCount;

         for (int i = 0; i < diff; i++)
         {
            var colName = "C" + i;
            gridTraining.Columns.Add(colName, colName);
         }
      }

      private void AddRowToGrid(string[] lineValues)
      {
         var row = new DataGridViewRow() { Visible = true };

         row.Cells.AddRange(lineValues
            .Select(v => new DataGridViewTextBoxCell() { Value = v })
            .ToArray());

         gridTraining.Rows.Add(row);
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

      private void btnAddRow_Click(object sender, EventArgs e)
      {
         gridTraining.Rows.Add();
      }

      private void btnRemoveRow_Click(object sender, EventArgs e)
      {
         if (MessageBox.Show("Are you sure to remove the selected rows?", "Remove Rows", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            return;

         foreach (var row in gridTraining.SelectedRows.Cast<DataGridViewRow>())
            gridTraining.Rows.Remove(row);
      }

      private int columnCounter = 1;
      private void btnAddColumn_Click(object sender, EventArgs e)
      {
         var name = $"C_{columnCounter}";
         gridTraining.Columns.Add(name, name);

         columnCounter++;
      }

      private void btnRemoveColumn_Click(object sender, EventArgs e)
      {
         if (MessageBox.Show("Are you sure to remove the selected columns?", "Remove Rows", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            return;

         foreach (var column in gridTraining.SelectedColumns.Cast<DataGridViewColumn>())
            gridTraining.Columns.Remove(column);
      }

      private void gridMain_SelectionChanged(object sender, EventArgs e)
      {
         btnRemoveRows.Enabled = gridTraining.SelectedRows.Count > 0;
         btnRemoveColumns.Enabled = gridTraining.SelectedColumns.Count > 0;
      }
   }
}
