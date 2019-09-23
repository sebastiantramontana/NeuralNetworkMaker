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
         this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
         this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
         this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
         this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.toolMatchNeuralNetIOToDataset = new System.Windows.Forms.ToolStripButton();
         this.toolMatchDatasetToNeuralNetIO = new System.Windows.Forms.ToolStripButton();
         this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.toolInputColumnsCount = new NeuralNetworkMaker.ToolStripNumericUpDown();
         this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
         this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
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
         this.gridTraining.RowTemplate.Height = 24;
         this.gridTraining.Size = new System.Drawing.Size(1453, 694);
         this.gridTraining.TabIndex = 13;
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
         this.tabValidation.Size = new System.Drawing.Size(1459, 662);
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
         this.gridValidation.Size = new System.Drawing.Size(1453, 656);
         this.gridValidation.TabIndex = 14;
         // 
         // tabTest
         // 
         this.tabTest.Controls.Add(this.gridTest);
         this.tabTest.Location = new System.Drawing.Point(4, 22);
         this.tabTest.Name = "tabTest";
         this.tabTest.Padding = new System.Windows.Forms.Padding(3);
         this.tabTest.Size = new System.Drawing.Size(1459, 662);
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
         this.gridTest.Size = new System.Drawing.Size(1453, 656);
         this.gridTest.TabIndex = 15;
         // 
         // toolDataset
         // 
         this.toolDataset.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripDropDownButton2,
            this.toolStripSeparator1,
            this.toolMatchNeuralNetIOToDataset,
            this.toolMatchDatasetToNeuralNetIO,
            this.toolStripSeparator2,
            this.toolInputColumnsCount,
            this.toolStripDropDownButton1});
         this.toolDataset.Location = new System.Drawing.Point(0, 0);
         this.toolDataset.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
         this.toolDataset.Name = "toolDataset";
         this.toolDataset.Size = new System.Drawing.Size(1467, 26);
         this.toolDataset.TabIndex = 0;
         // 
         // toolStripButton2
         // 
         this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
         this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
         this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolStripButton2.Name = "toolStripButton2";
         this.toolStripButton2.Size = new System.Drawing.Size(23, 23);
         this.toolStripButton2.Text = "toolStripButton2";
         // 
         // toolStripButton3
         // 
         this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
         this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolStripButton3.Name = "toolStripButton3";
         this.toolStripButton3.Size = new System.Drawing.Size(23, 23);
         this.toolStripButton3.Text = "toolStripButton3";
         // 
         // toolStripButton4
         // 
         this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
         this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolStripButton4.Name = "toolStripButton4";
         this.toolStripButton4.Size = new System.Drawing.Size(23, 23);
         this.toolStripButton4.Text = "toolStripButton4";
         // 
         // toolStripButton5
         // 
         this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
         this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolStripButton5.Name = "toolStripButton5";
         this.toolStripButton5.Size = new System.Drawing.Size(23, 23);
         this.toolStripButton5.Text = "toolStripButton5";
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
         this.toolMatchNeuralNetIOToDataset.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolMatchNeuralNetIOToDataset.Name = "toolMatchNeuralNetIOToDataset";
         this.toolMatchNeuralNetIOToDataset.Size = new System.Drawing.Size(23, 23);
         // 
         // toolMatchDatasetToNeuralNetIO
         // 
         this.toolMatchDatasetToNeuralNetIO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolMatchDatasetToNeuralNetIO.Image = ((System.Drawing.Image)(resources.GetObject("toolMatchDatasetToNeuralNetIO.Image")));
         this.toolMatchDatasetToNeuralNetIO.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolMatchDatasetToNeuralNetIO.Name = "toolMatchDatasetToNeuralNetIO";
         this.toolMatchDatasetToNeuralNetIO.Size = new System.Drawing.Size(23, 23);
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
         this.toolInputColumnsCount.Name = "toolInputColumnsCount";
         this.toolInputColumnsCount.Size = new System.Drawing.Size(41, 23);
         this.toolInputColumnsCount.Text = "1";
         this.toolInputColumnsCount.ToolTipText = "Input columns (rest columns will be the output)";
         // 
         // toolStripDropDownButton1
         // 
         this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
         this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
         this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 23);
         this.toolStripDropDownButton1.ToolTipText = "Select catergorical encoder";
         // 
         // toolStripDropDownButton2
         // 
         this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
         this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
         this.toolStripDropDownButton2.Size = new System.Drawing.Size(29, 23);
         this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
         // 
         // DatasetGrid
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
         this.Controls.Add(this.tabGrids);
         this.Controls.Add(this.toolDataset);
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "DatasetGrid";
         this.Size = new System.Drawing.Size(1467, 752);
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
      private System.Windows.Forms.ToolStripButton toolStripButton2;
      private System.Windows.Forms.ToolStripButton toolStripButton3;
      private System.Windows.Forms.ToolStripButton toolStripButton4;
      private System.Windows.Forms.ToolStripButton toolStripButton5;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
      private System.Windows.Forms.ToolStripButton toolMatchNeuralNetIOToDataset;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
      private NeuralNetworkMaker.ToolStripNumericUpDown toolInputColumnsCount;
      private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
      private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
   }
}
