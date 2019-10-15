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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatasetGrid));
         this.txtColumnNameEditor = new System.Windows.Forms.TextBox();
         this.gridTraining = new System.Windows.Forms.DataGridView();
         this.tabGrids = new System.Windows.Forms.TabControl();
         this.tabTraining = new System.Windows.Forms.TabPage();
         this.tabValidation = new System.Windows.Forms.TabPage();
         this.gridValidation = new System.Windows.Forms.DataGridView();
         this.tabTest = new System.Windows.Forms.TabPage();
         this.gridTest = new System.Windows.Forms.DataGridView();
         this.toolDataset = new System.Windows.Forms.ToolStrip();
         this.toolAddRow = new System.Windows.Forms.ToolStripButton();
         this.toolRemoveRows = new System.Windows.Forms.ToolStripButton();
         this.toolAddColumn = new System.Windows.Forms.ToolStripButton();
         this.toolRemoveColumns = new System.Windows.Forms.ToolStripButton();
         this.toolMoveRows = new System.Windows.Forms.ToolStripDropDownButton();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.toolMatchNeuralNetIOToDataset = new System.Windows.Forms.ToolStripButton();
         this.toolMatchDatasetToNeuralNetIO = new System.Windows.Forms.ToolStripButton();
         this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.toolInputColumnsCount = new NeuralNetworkMaker.ToolStripNumericUpDown();
         this.toolEncoding = new System.Windows.Forms.ToolStripDropDownButton();
         this.toolOpenFullScreen = new System.Windows.Forms.ToolStripButton();
         this.toolLoadingData = new System.Windows.Forms.ToolStripProgressBar();
         this.toolChangeSeletedColumnName = new System.Windows.Forms.ToolStripButton();
         ((System.ComponentModel.ISupportInitialize)(this.gridTraining)).BeginInit();
         this.tabGrids.SuspendLayout();
         this.tabTraining.SuspendLayout();
         this.tabValidation.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.gridValidation)).BeginInit();
         this.tabTest.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.gridTest)).BeginInit();
         this.toolDataset.SuspendLayout();
         this.SuspendLayout();
         // 
         // txtColumnNameEditor
         // 
         this.txtColumnNameEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtColumnNameEditor.Location = new System.Drawing.Point(144, 224);
         this.txtColumnNameEditor.Margin = new System.Windows.Forms.Padding(0);
         this.txtColumnNameEditor.Name = "txtColumnNameEditor";
         this.txtColumnNameEditor.Size = new System.Drawing.Size(133, 13);
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
         this.gridTraining.RowHeadersWidth = 20;
         this.gridTraining.RowTemplate.Height = 24;
         this.gridTraining.Size = new System.Drawing.Size(1453, 694);
         this.gridTraining.TabIndex = 13;
         this.gridTraining.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellValueChanged);
         this.gridTraining.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridMain_ColumnHeaderMouseDoubleClick);
         this.gridTraining.SelectionChanged += new System.EventHandler(this.gridMain_SelectionChanged);
         // 
         // tabGrids
         // 
         this.tabGrids.Controls.Add(this.tabTraining);
         this.tabGrids.Controls.Add(this.tabValidation);
         this.tabGrids.Controls.Add(this.tabTest);
         this.tabGrids.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tabGrids.Location = new System.Drawing.Point(0, 26);
         this.tabGrids.Multiline = true;
         this.tabGrids.Name = "tabGrids";
         this.tabGrids.SelectedIndex = 0;
         this.tabGrids.Size = new System.Drawing.Size(1467, 726);
         this.tabGrids.TabIndex = 17;
         // 
         // tabTraining
         // 
         this.tabTraining.Controls.Add(this.gridTraining);
         this.tabTraining.Controls.Add(this.txtColumnNameEditor);
         this.tabTraining.Location = new System.Drawing.Point(4, 22);
         this.tabTraining.Name = "tabTraining";
         this.tabTraining.Padding = new System.Windows.Forms.Padding(3);
         this.tabTraining.Size = new System.Drawing.Size(1459, 700);
         this.tabTraining.TabIndex = 0;
         this.tabTraining.Text = "Training";
         this.tabTraining.UseVisualStyleBackColor = true;
         // 
         // tabValidation
         // 
         this.tabValidation.Controls.Add(this.gridValidation);
         this.tabValidation.Location = new System.Drawing.Point(4, 22);
         this.tabValidation.Name = "tabValidation";
         this.tabValidation.Padding = new System.Windows.Forms.Padding(3);
         this.tabValidation.Size = new System.Drawing.Size(1459, 700);
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
         this.gridValidation.Size = new System.Drawing.Size(1453, 694);
         this.gridValidation.TabIndex = 14;
         this.gridValidation.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellValueChanged);
         // 
         // tabTest
         // 
         this.tabTest.Controls.Add(this.gridTest);
         this.tabTest.Location = new System.Drawing.Point(4, 22);
         this.tabTest.Name = "tabTest";
         this.tabTest.Padding = new System.Windows.Forms.Padding(3);
         this.tabTest.Size = new System.Drawing.Size(1459, 700);
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
         this.gridTest.Size = new System.Drawing.Size(1453, 694);
         this.gridTest.TabIndex = 15;
         this.gridTest.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellValueChanged);
         // 
         // toolDataset
         // 
         this.toolDataset.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
         this.toolDataset.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAddRow,
            this.toolRemoveRows,
            this.toolAddColumn,
            this.toolRemoveColumns,
            this.toolChangeSeletedColumnName,
            this.toolMoveRows,
            this.toolStripSeparator1,
            this.toolMatchNeuralNetIOToDataset,
            this.toolMatchDatasetToNeuralNetIO,
            this.toolStripSeparator2,
            this.toolInputColumnsCount,
            this.toolEncoding,
            this.toolOpenFullScreen,
            this.toolLoadingData});
         this.toolDataset.Location = new System.Drawing.Point(0, 0);
         this.toolDataset.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
         this.toolDataset.Name = "toolDataset";
         this.toolDataset.Size = new System.Drawing.Size(1467, 26);
         this.toolDataset.TabIndex = 0;
         // 
         // toolAddRow
         // 
         this.toolAddRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolAddRow.Image = ((System.Drawing.Image)(resources.GetObject("toolAddRow.Image")));
         this.toolAddRow.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
         this.toolAddRow.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolAddRow.Name = "toolAddRow";
         this.toolAddRow.Size = new System.Drawing.Size(23, 23);
         this.toolAddRow.ToolTipText = "Add new blank row";
         this.toolAddRow.Click += new System.EventHandler(this.toolAddRow_Click);
         // 
         // toolRemoveRows
         // 
         this.toolRemoveRows.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolRemoveRows.Image = ((System.Drawing.Image)(resources.GetObject("toolRemoveRows.Image")));
         this.toolRemoveRows.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolRemoveRows.Name = "toolRemoveRows";
         this.toolRemoveRows.Size = new System.Drawing.Size(23, 23);
         this.toolRemoveRows.ToolTipText = "Remove selected rows";
         // 
         // toolAddColumn
         // 
         this.toolAddColumn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolAddColumn.Image = ((System.Drawing.Image)(resources.GetObject("toolAddColumn.Image")));
         this.toolAddColumn.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolAddColumn.Name = "toolAddColumn";
         this.toolAddColumn.Size = new System.Drawing.Size(23, 23);
         this.toolAddColumn.ToolTipText = "Add new column";
         // 
         // toolRemoveColumns
         // 
         this.toolRemoveColumns.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolRemoveColumns.Image = ((System.Drawing.Image)(resources.GetObject("toolRemoveColumns.Image")));
         this.toolRemoveColumns.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolRemoveColumns.Name = "toolRemoveColumns";
         this.toolRemoveColumns.Size = new System.Drawing.Size(23, 23);
         this.toolRemoveColumns.ToolTipText = "Remove selected columns";
         // 
         // toolMoveRows
         // 
         this.toolMoveRows.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolMoveRows.Image = ((System.Drawing.Image)(resources.GetObject("toolMoveRows.Image")));
         this.toolMoveRows.ImageTransparentColor = System.Drawing.Color.White;
         this.toolMoveRows.Name = "toolMoveRows";
         this.toolMoveRows.Size = new System.Drawing.Size(29, 23);
         this.toolMoveRows.ToolTipText = "Move selected rows to other grid";
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
         // 
         // toolMatchNeuralNetIOToDataset
         // 
         this.toolMatchNeuralNetIOToDataset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolMatchNeuralNetIOToDataset.Image = ((System.Drawing.Image)(resources.GetObject("toolMatchNeuralNetIOToDataset.Image")));
         this.toolMatchNeuralNetIOToDataset.ImageTransparentColor = System.Drawing.Color.White;
         this.toolMatchNeuralNetIOToDataset.Name = "toolMatchNeuralNetIOToDataset";
         this.toolMatchNeuralNetIOToDataset.Size = new System.Drawing.Size(23, 23);
         this.toolMatchNeuralNetIOToDataset.ToolTipText = "Match neural network I/O to dataset columns";
         // 
         // toolMatchDatasetToNeuralNetIO
         // 
         this.toolMatchDatasetToNeuralNetIO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolMatchDatasetToNeuralNetIO.Image = ((System.Drawing.Image)(resources.GetObject("toolMatchDatasetToNeuralNetIO.Image")));
         this.toolMatchDatasetToNeuralNetIO.ImageTransparentColor = System.Drawing.Color.White;
         this.toolMatchDatasetToNeuralNetIO.Name = "toolMatchDatasetToNeuralNetIO";
         this.toolMatchDatasetToNeuralNetIO.Size = new System.Drawing.Size(23, 23);
         this.toolMatchDatasetToNeuralNetIO.ToolTipText = "Match dataset columns to neural network I/O ";
         this.toolMatchDatasetToNeuralNetIO.Click += new System.EventHandler(this.ToolMatchNeuralNetIO_Click);
         // 
         // toolStripSeparator2
         // 
         this.toolStripSeparator2.Name = "toolStripSeparator2";
         this.toolStripSeparator2.Size = new System.Drawing.Size(6, 26);
         // 
         // toolInputColumnsCount
         // 
         this.toolInputColumnsCount.Enabled = false;
         this.toolInputColumnsCount.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
         this.toolInputColumnsCount.Name = "toolInputColumnsCount";
         this.toolInputColumnsCount.Size = new System.Drawing.Size(41, 23);
         this.toolInputColumnsCount.Text = "1";
         this.toolInputColumnsCount.ToolTipText = "Input columns (rest columns are the outputs)";
         this.toolInputColumnsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         // 
         // toolEncoding
         // 
         this.toolEncoding.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolEncoding.Enabled = false;
         this.toolEncoding.Image = ((System.Drawing.Image)(resources.GetObject("toolEncoding.Image")));
         this.toolEncoding.ImageTransparentColor = System.Drawing.Color.White;
         this.toolEncoding.Name = "toolEncoding";
         this.toolEncoding.Size = new System.Drawing.Size(29, 23);
         this.toolEncoding.ToolTipText = "No categorical columns to encode";
         this.toolEncoding.EnabledChanged += new System.EventHandler(this.toolEncoding_EnabledChanged);
         // 
         // toolOpenFullScreen
         // 
         this.toolOpenFullScreen.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
         this.toolOpenFullScreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolOpenFullScreen.Image = ((System.Drawing.Image)(resources.GetObject("toolOpenFullScreen.Image")));
         this.toolOpenFullScreen.ImageTransparentColor = System.Drawing.Color.White;
         this.toolOpenFullScreen.Name = "toolOpenFullScreen";
         this.toolOpenFullScreen.Size = new System.Drawing.Size(23, 23);
         this.toolOpenFullScreen.ToolTipText = "Open in fullscreen";
         // 
         // toolLoadingData
         // 
         this.toolLoadingData.Name = "toolLoadingData";
         this.toolLoadingData.Size = new System.Drawing.Size(100, 23);
         this.toolLoadingData.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
         // 
         // toolChangeSeletedColumnName
         // 
         this.toolChangeSeletedColumnName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolChangeSeletedColumnName.Image = ((System.Drawing.Image)(resources.GetObject("toolChangeSeletedColumnName.Image")));
         this.toolChangeSeletedColumnName.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolChangeSeletedColumnName.Name = "toolChangeSeletedColumnName";
         this.toolChangeSeletedColumnName.Size = new System.Drawing.Size(23, 23);
         this.toolChangeSeletedColumnName.ToolTipText = "Change name of selected column";
         // 
         // DatasetGrid
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
         this.Controls.Add(this.tabGrids);
         this.Controls.Add(this.toolDataset);
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "DatasetGrid";
         this.Size = new System.Drawing.Size(1467, 752);
         this.Load += new System.EventHandler(this.DatasetGrid_Load);
         ((System.ComponentModel.ISupportInitialize)(this.gridTraining)).EndInit();
         this.tabGrids.ResumeLayout(false);
         this.tabTraining.ResumeLayout(false);
         this.tabTraining.PerformLayout();
         this.tabValidation.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.gridValidation)).EndInit();
         this.tabTest.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.gridTest)).EndInit();
         this.toolDataset.ResumeLayout(false);
         this.toolDataset.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtColumnNameEditor;
      private System.Windows.Forms.DataGridView gridTraining;
      private System.Windows.Forms.TabControl tabGrids;
      private System.Windows.Forms.TabPage tabTraining;
      private System.Windows.Forms.TabPage tabValidation;
      private System.Windows.Forms.TabPage tabTest;
      private System.Windows.Forms.DataGridView gridValidation;
      private System.Windows.Forms.DataGridView gridTest;
      private System.Windows.Forms.ToolStrip toolDataset;
      private System.Windows.Forms.ToolStripButton toolMatchDatasetToNeuralNetIO;
      private System.Windows.Forms.ToolStripButton toolAddRow;
      private System.Windows.Forms.ToolStripButton toolRemoveRows;
      private System.Windows.Forms.ToolStripButton toolAddColumn;
      private System.Windows.Forms.ToolStripButton toolRemoveColumns;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
      private System.Windows.Forms.ToolStripButton toolMatchNeuralNetIOToDataset;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
      private NeuralNetworkMaker.ToolStripNumericUpDown toolInputColumnsCount;
      private System.Windows.Forms.ToolStripDropDownButton toolEncoding;
      private System.Windows.Forms.ToolStripDropDownButton toolMoveRows;
      private System.Windows.Forms.ToolStripButton toolOpenFullScreen;
      private System.Windows.Forms.ToolStripProgressBar toolLoadingData;
      private System.Windows.Forms.ToolStripButton toolChangeSeletedColumnName;
   }
}
