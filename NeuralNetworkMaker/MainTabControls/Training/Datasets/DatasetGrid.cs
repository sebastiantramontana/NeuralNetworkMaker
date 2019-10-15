using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeuralNetwork.Model.Layers;
using NeuralNetwork.Model.Nodes;
using NeuralNetwork.Visualizer.Preferences;
using NeuralNetwork.Visualizer.Preferences.Brushes;
using NeuralNetworkMaker.MainTabControls.Training.Datasets.ColumnsLoader;

namespace NeuralNetworkMaker.MainTabControls.Training.Datasets
{
   public partial class DatasetGrid : UserControl
   {
      public DatasetGrid()
      {
         InitializeComponent();

         InitializeTabs();
         SetSetDoubleBufferControls();
      }

      [Browsable(false)]
      public InputLayer InputLayer { get; set; }

      private void DatasetGrid_Load(object sender, EventArgs e)
      {

      }

      public async Task LoadRawDataAsync(DataTable<string> rawDataTable)
      {
         if (rawDataTable is null)
         {
            throw new ArgumentNullException($"{nameof(rawDataTable)} is null");
         }

         SwitchEnableControls(false);

         ResetGrids();
         ResetLoadingProgressBar();

         LoadColumns(rawDataTable);

         var parts = rawDataTable.SplitRows(60, 20, 20);

         UnsubscribeRowsCollectionChanged();

         await LoadRowsByChuncks(parts.Training, 60, gridTraining).ConfigureAwait(false);
         await LoadRowsByChuncks(parts.Validation, 20, gridValidation).ConfigureAwait(false);
         await LoadRowsByChuncks(parts.Test, 20, gridTest).ConfigureAwait(false);

         SubscribeRowsCollectionChanged();

         SwitchEnableControls(true);
         ShowTabsLegends();
      }

      public Dataset GetDataset()
      {
         return null;
      }

      private void InitializeTabs()
      {
         tabTraining.Tag = gridTraining;
         tabValidation.Tag = gridValidation;
         tabTest.Tag = gridTest;
      }

      private void ShowTabsLegends()
      {
         ShowRowsInTab(tabTraining, "Training");
         ShowRowsInTab(tabValidation, "Validation");
         ShowRowsInTab(tabTest, "Test");
      }

      private void UnsubscribeRowsCollectionChanged()
      {
         SafeInvoke(() =>
         {
            gridTraining.Rows.CollectionChanged -= Rows_CollectionChanged;
            gridValidation.Rows.CollectionChanged -= Rows_CollectionChanged;
            gridTest.Rows.CollectionChanged -= Rows_CollectionChanged;
         });
      }

      private void SubscribeRowsCollectionChanged()
      {
         SafeInvoke(() =>
         {
            gridTraining.Rows.CollectionChanged += Rows_CollectionChanged;
            gridValidation.Rows.CollectionChanged += Rows_CollectionChanged;
            gridTest.Rows.CollectionChanged += Rows_CollectionChanged;
         });
      }

      private void Rows_CollectionChanged(object sender, CollectionChangeEventArgs e)
      {
         if (e.Action == CollectionChangeAction.Refresh)
            return;



      }

      private void ShowRowsInTab(TabPage tabPage, string title)
      {
         var grid = tabPage.Tag as DataGridView;
         var text = $"{title}";

         if (grid.Rows.Count > 0)
            text += $" ({grid.Rows.Count - 1})";

         SafeInvoke(() => { tabPage.Text = text; });
      }
      private void SwitchEnableControls(bool enable)
      {
         SafeInvoke(() =>
         {
            toolDataset.Enabled =
            gridTraining.Enabled =
            gridValidation.Enabled =
            gridTest.Enabled = enable;
         });
      }

      private void LoadColumns(DataTable<string> rawDataTable)
      {
         var columns = GetDatatsetColumns(rawDataTable);

         foreach (var column in columns)
         {
            AddColumn(column);
         }
      }

      private void ResetLoadingProgressBar()
      {
         SafeInvoke(() =>
         {
            toolLoadingData.Value = 0;
            toolLoadingData.Step = 1;
         });
      }
      private void ResetGrids()
      {
         SafeInvoke(() =>
         {
            ClearColumns(gridTraining);
            ClearColumns(gridValidation);
            ClearColumns(gridTest);
         });

         ShowTabsLegends();
      }

      private void ClearColumns(DataGridView dataGridView)
      {
         dataGridView.Columns.Clear();
         dataGridView.Refresh();
      }

      private IEnumerable<string> GetDatatsetColumns(DataTable<string> rawDataTable)
      {
         var columnLoader = new DatasetColumnLoader(rawDataTable, new DatasetByRowColumnLoader(rawDataTable, new NeuralNetworkColumnLoader(this.InputLayer, new InvalidColumnLoader())));
         return columnLoader.GetColumns();
      }

      //TODO: Ver un mejor nombre o un refactor para la barra de progreso
      private async Task LoadRowsByChuncks(IEnumerable<string[]> data, int chunks, DataGridView grid)
      {
         int count = (int)Math.Ceiling(data.Count() / (double)chunks);

         for (int i = 0; i < chunks; i++)
         {
            var chunk = data.Skip(count * i).Take(count);
            SafeInvoke(() => { LoadRows(grid, chunk); });

            await Task.Run(() =>
            {
               SafeInvoke(() => { toolLoadingData.PerformStep(); });
            })
            .ConfigureAwait(false);
         }
      }
      private void LoadRows(DataGridView grid, IEnumerable<string[]> rawRows)
      {
         foreach (var row in rawRows)
         {
            AddRow(grid, row);
         }
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
         int rowIndex = grid.Rows.Add(values);

         for (int columnIndex = 0; columnIndex < grid.Columns.Count; columnIndex++)
            FormatCell(grid, rowIndex, columnIndex);
      }

      private void RemoveSelectedRows()
      {
         if (MessageBox.Show("Are you sure to remove the selected rows?", "Remove Rows", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            return;

         var grid = tabGrids.SelectedTab.Tag as DataGridView;
         var rows = grid.SelectedRows.Cast<DataGridViewRow>();

         foreach (var row in rows)
         {
            grid.Rows.Remove(row);
         }
      }

      private int columnCounter = 1;
      private void AddColumn()
      {
         var name = $"C_{columnCounter++}";
         AddColumn(name);
      }

      private void AddColumn(string name)
      {
         SafeInvoke(() =>
         {
            gridTraining.Columns.Add(name, name);
            gridValidation.Columns.Add(name, name);
            gridTest.Columns.Add(name, name);
         });
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
         foreach (var columnName in columnNames)
         {
            grid.Columns.Remove(columnName);
         }
      }

      private void SetSetDoubleBufferControls()
      {
         SetDoubleBufferControl(gridTraining);
         SetDoubleBufferControl(gridValidation);
         SetDoubleBufferControl(gridTest);
         SetDoubleBufferControl(toolLoadingData.Control);

         void SetDoubleBufferControl(Control control)
         {
            typeof(Control)
               .GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance)
               .SetValue(control, true, null);
         }
      }

      private void toolEncoding_EnabledChanged(object sender, EventArgs e)
      {
         toolEncoding.ToolTipText = toolEncoding.Enabled
            ? "Some columns look categorical and seem to need encoding!"
            : "No categorical columns to encode";
      }

      private void Grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
      {
         var grid = sender as DataGridView;
         FormatCell(grid, e.RowIndex, e.ColumnIndex);
      }

      private void FormatCell(DataGridView grid, int rowIndex, int columnIndex)
      {
         var row = grid.Rows[rowIndex];

         if (row.IsNewRow)
            return;

         var cell = row.Cells[columnIndex];
         var cellContent = cell.Value?.ToString();

         if (string.IsNullOrWhiteSpace(cellContent))
         {
            cell.Style.BackColor = Color.LightPink;
            return;
         }

         var isNumeric = double.TryParse(cellContent, out _);

         if (isNumeric)
         {
            cell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            cell.Style.BackColor = Color.White;
         }
         else
         {
            cell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cell.Style.BackColor = Color.LightYellow;
         }
      }

      private void toolAddRow_Click(object sender, EventArgs e)
      {

      }

      //TODO: COPIED FROM NEURALNETWORK.VISUALIZER: MAKE COMMON LIB!!!
      private void SafeInvoke(Action action)
      {
         if (this.InvokeRequired)
         {
            this.Invoke(action);
         }
         else
         {
            action();
         }
      }

      //TODO: COPIED FROM NEURALNETWORK.VISUALIZER: MAKE COMMON LIB!!!
      private T SafeInvoke<T>(Func<T> action)
      {
         return (this.InvokeRequired ? (T)this.Invoke(action) : action());
      }
   }
}
