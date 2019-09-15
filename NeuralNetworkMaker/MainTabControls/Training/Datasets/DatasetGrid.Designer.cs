namespace NeuralNetworkMaker.MainTabControls.Training.Datasets
{
   partial class DatasetGrid
   {
      /// <summary> 
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary> 
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatasetGrid));
         this.txtColumnNameEditor = new System.Windows.Forms.TextBox();
         this.gridTraining = new System.Windows.Forms.DataGridView();
         this.panel2 = new System.Windows.Forms.Panel();
         this.btnMatchNeuralNetIO = new System.Windows.Forms.Button();
         this.btnRemoveColumns = new System.Windows.Forms.Button();
         this.btnAddColumn = new System.Windows.Forms.Button();
         this.btnRemoveRows = new System.Windows.Forms.Button();
         this.btnAddRow = new System.Windows.Forms.Button();
         this.btnEncode = new System.Windows.Forms.Button();
         this.cboEncoders = new System.Windows.Forms.ComboBox();
         this.chIsCategorical = new System.Windows.Forms.CheckBox();
         this.label2 = new System.Windows.Forms.Label();
         this.spinInputColumnsCount = new System.Windows.Forms.NumericUpDown();
         this.toolTip = new System.Windows.Forms.ToolTip(this.components);
         this.tabGrids = new System.Windows.Forms.TabControl();
         this.tabTraining = new System.Windows.Forms.TabPage();
         this.tabValidation = new System.Windows.Forms.TabPage();
         this.gridValidation = new System.Windows.Forms.DataGridView();
         this.tabTest = new System.Windows.Forms.TabPage();
         this.gridTest = new System.Windows.Forms.DataGridView();
         ((System.ComponentModel.ISupportInitialize)(this.gridTraining)).BeginInit();
         this.panel2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.spinInputColumnsCount)).BeginInit();
         this.tabGrids.SuspendLayout();
         this.tabTraining.SuspendLayout();
         this.tabValidation.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.gridValidation)).BeginInit();
         this.tabTest.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.gridTest)).BeginInit();
         this.SuspendLayout();
         // 
         // txtColumnNameEditor
         // 
         this.txtColumnNameEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtColumnNameEditor.Location = new System.Drawing.Point(144, 224);
         this.txtColumnNameEditor.Margin = new System.Windows.Forms.Padding(0);
         this.txtColumnNameEditor.Name = "txtColumnNameEditor";
         this.txtColumnNameEditor.Size = new System.Drawing.Size(133, 15);
         this.txtColumnNameEditor.TabIndex = 14;
         this.txtColumnNameEditor.Visible = false;
         this.txtColumnNameEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtColumnNameEditor_KeyDown);
         this.txtColumnNameEditor.Validating += new System.ComponentModel.CancelEventHandler(this.txtColumnNameEditor_Validating);
         // 
         // gridTraining
         // 
         this.gridTraining.AllowUserToOrderColumns = true;
         this.gridTraining.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gridTraining.EnableHeadersVisualStyles = false;
         this.gridTraining.Location = new System.Drawing.Point(3, 3);
         this.gridTraining.Margin = new System.Windows.Forms.Padding(4);
         this.gridTraining.Name = "gridTraining";
         this.gridTraining.RowTemplate.Height = 24;
         this.gridTraining.Size = new System.Drawing.Size(1453, 678);
         this.gridTraining.TabIndex = 13;
         this.gridTraining.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridMain_ColumnHeaderMouseDoubleClick);
         this.gridTraining.SelectionChanged += new System.EventHandler(this.gridMain_SelectionChanged);
         // 
         // panel2
         // 
         this.panel2.Controls.Add(this.btnMatchNeuralNetIO);
         this.panel2.Controls.Add(this.btnRemoveColumns);
         this.panel2.Controls.Add(this.btnAddColumn);
         this.panel2.Controls.Add(this.btnRemoveRows);
         this.panel2.Controls.Add(this.btnAddRow);
         this.panel2.Controls.Add(this.btnEncode);
         this.panel2.Controls.Add(this.cboEncoders);
         this.panel2.Controls.Add(this.chIsCategorical);
         this.panel2.Controls.Add(this.label2);
         this.panel2.Controls.Add(this.spinInputColumnsCount);
         this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.panel2.Location = new System.Drawing.Point(0, 713);
         this.panel2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(1467, 39);
         this.panel2.TabIndex = 16;
         // 
         // btnMatchNeuralNetIO
         // 
         this.btnMatchNeuralNetIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnMatchNeuralNetIO.AutoSize = true;
         this.btnMatchNeuralNetIO.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.btnMatchNeuralNetIO.Enabled = false;
         this.btnMatchNeuralNetIO.Image = ((System.Drawing.Image)(resources.GetObject("btnMatchNeuralNetIO.Image")));
         this.btnMatchNeuralNetIO.Location = new System.Drawing.Point(1285, 10);
         this.btnMatchNeuralNetIO.Margin = new System.Windows.Forms.Padding(4);
         this.btnMatchNeuralNetIO.Name = "btnMatchNeuralNetIO";
         this.btnMatchNeuralNetIO.Size = new System.Drawing.Size(30, 30);
         this.btnMatchNeuralNetIO.TabIndex = 19;
         this.toolTip.SetToolTip(this.btnMatchNeuralNetIO, "Match neural network\'s inputs and output by current dataset");
         this.btnMatchNeuralNetIO.UseVisualStyleBackColor = true;
         // 
         // btnRemoveColumns
         // 
         this.btnRemoveColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnRemoveColumns.AutoSize = true;
         this.btnRemoveColumns.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.btnRemoveColumns.Enabled = false;
         this.btnRemoveColumns.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveColumns.Image")));
         this.btnRemoveColumns.Location = new System.Drawing.Point(1437, 9);
         this.btnRemoveColumns.Margin = new System.Windows.Forms.Padding(4);
         this.btnRemoveColumns.Name = "btnRemoveColumns";
         this.btnRemoveColumns.Size = new System.Drawing.Size(30, 30);
         this.btnRemoveColumns.TabIndex = 18;
         this.toolTip.SetToolTip(this.btnRemoveColumns, "Remove selected columns");
         this.btnRemoveColumns.UseVisualStyleBackColor = true;
         this.btnRemoveColumns.Click += new System.EventHandler(this.btnRemoveColumn_Click);
         // 
         // btnAddColumn
         // 
         this.btnAddColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnAddColumn.AutoSize = true;
         this.btnAddColumn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.btnAddColumn.Image = ((System.Drawing.Image)(resources.GetObject("btnAddColumn.Image")));
         this.btnAddColumn.Location = new System.Drawing.Point(1399, 10);
         this.btnAddColumn.Margin = new System.Windows.Forms.Padding(4);
         this.btnAddColumn.Name = "btnAddColumn";
         this.btnAddColumn.Size = new System.Drawing.Size(30, 30);
         this.btnAddColumn.TabIndex = 17;
         this.toolTip.SetToolTip(this.btnAddColumn, "Add column");
         this.btnAddColumn.UseVisualStyleBackColor = true;
         this.btnAddColumn.Click += new System.EventHandler(this.btnAddColumn_Click);
         // 
         // btnRemoveRows
         // 
         this.btnRemoveRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnRemoveRows.AutoSize = true;
         this.btnRemoveRows.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.btnRemoveRows.Enabled = false;
         this.btnRemoveRows.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveRows.Image")));
         this.btnRemoveRows.Location = new System.Drawing.Point(1361, 9);
         this.btnRemoveRows.Margin = new System.Windows.Forms.Padding(4);
         this.btnRemoveRows.Name = "btnRemoveRows";
         this.btnRemoveRows.Size = new System.Drawing.Size(30, 30);
         this.btnRemoveRows.TabIndex = 16;
         this.toolTip.SetToolTip(this.btnRemoveRows, "Remove selected rows");
         this.btnRemoveRows.UseVisualStyleBackColor = true;
         this.btnRemoveRows.Click += new System.EventHandler(this.btnRemoveRow_Click);
         // 
         // btnAddRow
         // 
         this.btnAddRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnAddRow.AutoSize = true;
         this.btnAddRow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.btnAddRow.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRow.Image")));
         this.btnAddRow.Location = new System.Drawing.Point(1323, 10);
         this.btnAddRow.Margin = new System.Windows.Forms.Padding(4);
         this.btnAddRow.Name = "btnAddRow";
         this.btnAddRow.Size = new System.Drawing.Size(30, 30);
         this.btnAddRow.TabIndex = 15;
         this.toolTip.SetToolTip(this.btnAddRow, "Add row");
         this.btnAddRow.UseVisualStyleBackColor = true;
         this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
         // 
         // btnEncode
         // 
         this.btnEncode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.btnEncode.Enabled = false;
         this.btnEncode.Location = new System.Drawing.Point(536, 11);
         this.btnEncode.Margin = new System.Windows.Forms.Padding(4);
         this.btnEncode.Name = "btnEncode";
         this.btnEncode.Size = new System.Drawing.Size(100, 28);
         this.btnEncode.TabIndex = 13;
         this.btnEncode.Text = "Encode";
         this.toolTip.SetToolTip(this.btnEncode, "Encode categorical column");
         this.btnEncode.UseVisualStyleBackColor = true;
         // 
         // cboEncoders
         // 
         this.cboEncoders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.cboEncoders.Enabled = false;
         this.cboEncoders.FormattingEnabled = true;
         this.cboEncoders.Location = new System.Drawing.Point(367, 13);
         this.cboEncoders.Margin = new System.Windows.Forms.Padding(4);
         this.cboEncoders.Name = "cboEncoders";
         this.cboEncoders.Size = new System.Drawing.Size(160, 24);
         this.cboEncoders.TabIndex = 12;
         this.toolTip.SetToolTip(this.cboEncoders, "Select catergorical encoder");
         // 
         // chIsCategorical
         // 
         this.chIsCategorical.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.chIsCategorical.AutoSize = true;
         this.chIsCategorical.Enabled = false;
         this.chIsCategorical.Location = new System.Drawing.Point(239, 16);
         this.chIsCategorical.Margin = new System.Windows.Forms.Padding(4);
         this.chIsCategorical.Name = "chIsCategorical";
         this.chIsCategorical.Size = new System.Drawing.Size(115, 21);
         this.chIsCategorical.TabIndex = 11;
         this.chIsCategorical.Text = "Is Categorical";
         this.toolTip.SetToolTip(this.chIsCategorical, "Column is categorical");
         this.chIsCategorical.UseVisualStyleBackColor = true;
         // 
         // label2
         // 
         this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(-3, 16);
         this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(95, 17);
         this.label2.TabIndex = 10;
         this.label2.Text = "Input columns";
         // 
         // spinInputColumnsCount
         // 
         this.spinInputColumnsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.spinInputColumnsCount.Enabled = false;
         this.spinInputColumnsCount.Location = new System.Drawing.Point(103, 15);
         this.spinInputColumnsCount.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
         this.spinInputColumnsCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
         this.spinInputColumnsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.spinInputColumnsCount.Name = "spinInputColumnsCount";
         this.spinInputColumnsCount.Size = new System.Drawing.Size(89, 22);
         this.spinInputColumnsCount.TabIndex = 9;
         this.toolTip.SetToolTip(this.spinInputColumnsCount, "(rest columns will be the output)");
         this.spinInputColumnsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.spinInputColumnsCount.ValueChanged += new System.EventHandler(this.spinInputColumnsCount_ValueChanged);
         // 
         // tabGrids
         // 
         this.tabGrids.Controls.Add(this.tabTraining);
         this.tabGrids.Controls.Add(this.tabValidation);
         this.tabGrids.Controls.Add(this.tabTest);
         this.tabGrids.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tabGrids.Location = new System.Drawing.Point(0, 0);
         this.tabGrids.Name = "tabGrids";
         this.tabGrids.SelectedIndex = 0;
         this.tabGrids.Size = new System.Drawing.Size(1467, 713);
         this.tabGrids.TabIndex = 17;
         // 
         // tabTraining
         // 
         this.tabTraining.Controls.Add(this.txtColumnNameEditor);
         this.tabTraining.Controls.Add(this.gridTraining);
         this.tabTraining.Location = new System.Drawing.Point(4, 25);
         this.tabTraining.Name = "tabTraining";
         this.tabTraining.Padding = new System.Windows.Forms.Padding(3);
         this.tabTraining.Size = new System.Drawing.Size(1459, 684);
         this.tabTraining.TabIndex = 0;
         this.tabTraining.Text = "Training";
         this.tabTraining.UseVisualStyleBackColor = true;
         // 
         // tabValidation
         // 
         this.tabValidation.Controls.Add(this.gridValidation);
         this.tabValidation.Location = new System.Drawing.Point(4, 25);
         this.tabValidation.Name = "tabValidation";
         this.tabValidation.Padding = new System.Windows.Forms.Padding(3);
         this.tabValidation.Size = new System.Drawing.Size(1459, 684);
         this.tabValidation.TabIndex = 1;
         this.tabValidation.Text = "Validation";
         this.tabValidation.UseVisualStyleBackColor = true;
         // 
         // gridValidation
         // 
         this.gridValidation.AllowUserToOrderColumns = true;
         this.gridValidation.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gridValidation.EnableHeadersVisualStyles = false;
         this.gridValidation.Location = new System.Drawing.Point(3, 3);
         this.gridValidation.Margin = new System.Windows.Forms.Padding(4);
         this.gridValidation.Name = "gridValidation";
         this.gridValidation.RowTemplate.Height = 24;
         this.gridValidation.Size = new System.Drawing.Size(1453, 678);
         this.gridValidation.TabIndex = 14;
         // 
         // tabTest
         // 
         this.tabTest.Controls.Add(this.gridTest);
         this.tabTest.Location = new System.Drawing.Point(4, 25);
         this.tabTest.Name = "tabTest";
         this.tabTest.Padding = new System.Windows.Forms.Padding(3);
         this.tabTest.Size = new System.Drawing.Size(1459, 684);
         this.tabTest.TabIndex = 2;
         this.tabTest.Text = "Test";
         this.tabTest.UseVisualStyleBackColor = true;
         // 
         // gridTest
         // 
         this.gridTest.AllowUserToOrderColumns = true;
         this.gridTest.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gridTest.EnableHeadersVisualStyles = false;
         this.gridTest.Location = new System.Drawing.Point(3, 3);
         this.gridTest.Margin = new System.Windows.Forms.Padding(4);
         this.gridTest.Name = "gridTest";
         this.gridTest.RowTemplate.Height = 24;
         this.gridTest.Size = new System.Drawing.Size(1453, 678);
         this.gridTest.TabIndex = 15;
         // 
         // DatasetGrid
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
         this.Controls.Add(this.tabGrids);
         this.Controls.Add(this.panel2);
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "DatasetGrid";
         this.Size = new System.Drawing.Size(1467, 752);
         ((System.ComponentModel.ISupportInitialize)(this.gridTraining)).EndInit();
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.spinInputColumnsCount)).EndInit();
         this.tabGrids.ResumeLayout(false);
         this.tabTraining.ResumeLayout(false);
         this.tabTraining.PerformLayout();
         this.tabValidation.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.gridValidation)).EndInit();
         this.tabTest.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.gridTest)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TextBox txtColumnNameEditor;
      private System.Windows.Forms.DataGridView gridTraining;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.NumericUpDown spinInputColumnsCount;
      private System.Windows.Forms.ToolTip toolTip;
      private System.Windows.Forms.Button btnAddRow;
      private System.Windows.Forms.Button btnEncode;
      private System.Windows.Forms.ComboBox cboEncoders;
      private System.Windows.Forms.CheckBox chIsCategorical;
      private System.Windows.Forms.Button btnRemoveColumns;
      private System.Windows.Forms.Button btnAddColumn;
      private System.Windows.Forms.Button btnRemoveRows;
      private System.Windows.Forms.Button btnMatchNeuralNetIO;
      private System.Windows.Forms.TabControl tabGrids;
      private System.Windows.Forms.TabPage tabTraining;
      private System.Windows.Forms.TabPage tabValidation;
      private System.Windows.Forms.TabPage tabTest;
      private System.Windows.Forms.DataGridView gridValidation;
      private System.Windows.Forms.DataGridView gridTest;
   }
}
