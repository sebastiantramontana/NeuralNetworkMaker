namespace NeuralNetworkMaker
{
   partial class MainForm
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

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
         this.mainMenu = new System.Windows.Forms.MenuStrip();
         this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.SeparatorMenuItem = new System.Windows.Forms.ToolStripSeparator();
         this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.MainContainer = new System.Windows.Forms.SplitContainer();
         this.tabActions = new System.Windows.Forms.TabControl();
         this.tabDesign = new System.Windows.Forms.TabPage();
         this.designControl = new NeuralNetworkMaker.MainTabControls.Design.DesignControl();
         this.tabTraining = new System.Windows.Forms.TabPage();
         this.trainingControl = new NeuralNetworkMaker.MainTabControls.Training.TrainingControl();
         this.tabPredict = new System.Windows.Forms.TabPage();
         this.NNVisualizerControl = new NeuralNetwork.Visualizer.NeuralNetworkVisualizerControl();
         this.ToolbarNNVisualizer = new System.Windows.Forms.ToolStrip();
         this.btnPreferencesNNVisualizer = new System.Windows.Forms.ToolStripButton();
         this.ComboQualityNNVisualizer = new System.Windows.Forms.ToolStripComboBox();
         this.btnZoomOutNNVisualizer = new System.Windows.Forms.ToolStripButton();
         this.btnZoomInNNVisualizer = new System.Windows.Forms.ToolStripButton();
         this.datasetGrid = new NeuralNetworkMaker.MainTabControls.Training.Datasets.DatasetGrid();
         this.btnExportAsImageNNVisualizer = new System.Windows.Forms.ToolStripButton();
         this.mainMenu.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
         this.MainContainer.Panel1.SuspendLayout();
         this.MainContainer.Panel2.SuspendLayout();
         this.MainContainer.SuspendLayout();
         this.tabActions.SuspendLayout();
         this.tabDesign.SuspendLayout();
         this.tabTraining.SuspendLayout();
         this.ToolbarNNVisualizer.SuspendLayout();
         this.SuspendLayout();
         // 
         // mainMenu
         // 
         this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem});
         this.mainMenu.Location = new System.Drawing.Point(0, 0);
         this.mainMenu.Name = "mainMenu";
         this.mainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
         this.mainMenu.Size = new System.Drawing.Size(1028, 24);
         this.mainMenu.TabIndex = 0;
         this.mainMenu.Text = "menuStrip1";
         // 
         // FileMenuItem
         // 
         this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.SeparatorMenuItem,
            this.exitToolStripMenuItem});
         this.FileMenuItem.Name = "FileMenuItem";
         this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
         this.FileMenuItem.Text = "File";
         // 
         // NewMenuItem
         // 
         this.NewMenuItem.Name = "NewMenuItem";
         this.NewMenuItem.Size = new System.Drawing.Size(103, 22);
         this.NewMenuItem.Text = "New";
         this.NewMenuItem.Click += new System.EventHandler(this.NewMenuItem_Click);
         // 
         // openToolStripMenuItem
         // 
         this.openToolStripMenuItem.Name = "openToolStripMenuItem";
         this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
         this.openToolStripMenuItem.Text = "Open";
         // 
         // saveToolStripMenuItem
         // 
         this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
         this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
         this.saveToolStripMenuItem.Text = "Save";
         // 
         // SeparatorMenuItem
         // 
         this.SeparatorMenuItem.Name = "SeparatorMenuItem";
         this.SeparatorMenuItem.Size = new System.Drawing.Size(100, 6);
         // 
         // exitToolStripMenuItem
         // 
         this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
         this.exitToolStripMenuItem.Text = "Exit";
         // 
         // MainContainer
         // 
         this.MainContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this.MainContainer.Location = new System.Drawing.Point(0, 24);
         this.MainContainer.Margin = new System.Windows.Forms.Padding(0);
         this.MainContainer.Name = "MainContainer";
         // 
         // MainContainer.Panel1
         // 
         this.MainContainer.Panel1.Controls.Add(this.tabActions);
         // 
         // MainContainer.Panel2
         // 
         this.MainContainer.Panel2.Controls.Add(this.NNVisualizerControl);
         this.MainContainer.Panel2.Controls.Add(this.ToolbarNNVisualizer);
         this.MainContainer.Panel2.Controls.Add(this.datasetGrid);
         this.MainContainer.Size = new System.Drawing.Size(1028, 585);
         this.MainContainer.SplitterDistance = 238;
         this.MainContainer.SplitterWidth = 2;
         this.MainContainer.TabIndex = 1;
         // 
         // tabActions
         // 
         this.tabActions.Controls.Add(this.tabDesign);
         this.tabActions.Controls.Add(this.tabTraining);
         this.tabActions.Controls.Add(this.tabPredict);
         this.tabActions.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tabActions.ItemSize = new System.Drawing.Size(100, 23);
         this.tabActions.Location = new System.Drawing.Point(0, 0);
         this.tabActions.Margin = new System.Windows.Forms.Padding(2);
         this.tabActions.Name = "tabActions";
         this.tabActions.SelectedIndex = 0;
         this.tabActions.Size = new System.Drawing.Size(236, 583);
         this.tabActions.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
         this.tabActions.TabIndex = 0;
         this.tabActions.SelectedIndexChanged += new System.EventHandler(this.tabActions_SelectedIndexChanged);
         // 
         // tabDesign
         // 
         this.tabDesign.Controls.Add(this.designControl);
         this.tabDesign.Location = new System.Drawing.Point(4, 27);
         this.tabDesign.Margin = new System.Windows.Forms.Padding(2);
         this.tabDesign.Name = "tabDesign";
         this.tabDesign.Padding = new System.Windows.Forms.Padding(2);
         this.tabDesign.Size = new System.Drawing.Size(228, 552);
         this.tabDesign.TabIndex = 0;
         this.tabDesign.Text = "Design";
         this.tabDesign.UseVisualStyleBackColor = true;
         // 
         // designControl
         // 
         this.designControl.Dock = System.Windows.Forms.DockStyle.Fill;
         this.designControl.Location = new System.Drawing.Point(2, 2);
         this.designControl.Margin = new System.Windows.Forms.Padding(4);
         this.designControl.Name = "designControl";
         this.designControl.NNVisualizerControl = null;
         this.designControl.Size = new System.Drawing.Size(224, 548);
         this.designControl.TabIndex = 0;
         // 
         // tabTraining
         // 
         this.tabTraining.Controls.Add(this.trainingControl);
         this.tabTraining.Location = new System.Drawing.Point(4, 27);
         this.tabTraining.Margin = new System.Windows.Forms.Padding(2);
         this.tabTraining.Name = "tabTraining";
         this.tabTraining.Padding = new System.Windows.Forms.Padding(2);
         this.tabTraining.Size = new System.Drawing.Size(229, 552);
         this.tabTraining.TabIndex = 1;
         this.tabTraining.Text = "Training";
         this.tabTraining.UseVisualStyleBackColor = true;
         // 
         // trainingControl
         // 
         this.trainingControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.trainingControl.DatasetGridControl = null;
         this.trainingControl.Location = new System.Drawing.Point(0, 0);
         this.trainingControl.Margin = new System.Windows.Forms.Padding(0);
         this.trainingControl.Name = "trainingControl";
         this.trainingControl.Size = new System.Drawing.Size(231, 556);
         this.trainingControl.TabIndex = 0;
         this.trainingControl.VisualizerControl = null;
         // 
         // tabPredict
         // 
         this.tabPredict.Location = new System.Drawing.Point(4, 27);
         this.tabPredict.Margin = new System.Windows.Forms.Padding(2);
         this.tabPredict.Name = "tabPredict";
         this.tabPredict.Padding = new System.Windows.Forms.Padding(2);
         this.tabPredict.Size = new System.Drawing.Size(229, 552);
         this.tabPredict.TabIndex = 2;
         this.tabPredict.Text = "Predict";
         this.tabPredict.UseVisualStyleBackColor = true;
         // 
         // NNVisualizerControl
         // 
         this.NNVisualizerControl.AutoScroll = true;
         this.NNVisualizerControl.BackColor = System.Drawing.Color.White;
         this.NNVisualizerControl.Dock = System.Windows.Forms.DockStyle.Fill;
         this.NNVisualizerControl.InputLayer = null;
         this.NNVisualizerControl.Location = new System.Drawing.Point(0, 27);
         this.NNVisualizerControl.Margin = new System.Windows.Forms.Padding(4);
         this.NNVisualizerControl.Name = "NNVisualizerControl";
         this.NNVisualizerControl.Selectable = true;
         this.NNVisualizerControl.Size = new System.Drawing.Size(786, 556);
         this.NNVisualizerControl.TabIndex = 2;
         this.NNVisualizerControl.Zoom = 1F;
         // 
         // ToolbarNNVisualizer
         // 
         this.ToolbarNNVisualizer.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.ToolbarNNVisualizer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnZoomInNNVisualizer,
            this.btnPreferencesNNVisualizer,
            this.ComboQualityNNVisualizer,
            this.btnZoomOutNNVisualizer,
            this.btnExportAsImageNNVisualizer});
         this.ToolbarNNVisualizer.Location = new System.Drawing.Point(0, 0);
         this.ToolbarNNVisualizer.Name = "ToolbarNNVisualizer";
         this.ToolbarNNVisualizer.Size = new System.Drawing.Size(786, 27);
         this.ToolbarNNVisualizer.TabIndex = 1;
         // 
         // btnPreferencesNNVisualizer
         // 
         this.btnPreferencesNNVisualizer.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
         this.btnPreferencesNNVisualizer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.btnPreferencesNNVisualizer.Image = ((System.Drawing.Image)(resources.GetObject("btnPreferencesNNVisualizer.Image")));
         this.btnPreferencesNNVisualizer.ImageTransparentColor = System.Drawing.Color.White;
         this.btnPreferencesNNVisualizer.Name = "btnPreferencesNNVisualizer";
         this.btnPreferencesNNVisualizer.Size = new System.Drawing.Size(24, 24);
         this.btnPreferencesNNVisualizer.Click += new System.EventHandler(this.btnPreferencesNNVisualizer_Click);
         // 
         // ComboQualityNNVisualizer
         // 
         this.ComboQualityNNVisualizer.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
         this.ComboQualityNNVisualizer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.ComboQualityNNVisualizer.Name = "ComboQualityNNVisualizer";
         this.ComboQualityNNVisualizer.Size = new System.Drawing.Size(92, 27);
         this.ComboQualityNNVisualizer.ToolTipText = "Graphics Quality";
         this.ComboQualityNNVisualizer.SelectedIndexChanged += new System.EventHandler(this.ComboQualityNNVisualizer_SelectedIndexChanged);
         // 
         // btnZoomOutNNVisualizer
         // 
         this.btnZoomOutNNVisualizer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.btnZoomOutNNVisualizer.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomOutNNVisualizer.Image")));
         this.btnZoomOutNNVisualizer.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.btnZoomOutNNVisualizer.Name = "btnZoomOutNNVisualizer";
         this.btnZoomOutNNVisualizer.Size = new System.Drawing.Size(24, 24);
         this.btnZoomOutNNVisualizer.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
         this.btnZoomOutNNVisualizer.ToolTipText = "Zoom Out";
         this.btnZoomOutNNVisualizer.Click += new System.EventHandler(this.btnZoomOutNNVisualizer_Click);
         // 
         // btnZoomInNNVisualizer
         // 
         this.btnZoomInNNVisualizer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.btnZoomInNNVisualizer.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomInNNVisualizer.Image")));
         this.btnZoomInNNVisualizer.ImageTransparentColor = System.Drawing.Color.White;
         this.btnZoomInNNVisualizer.Name = "btnZoomInNNVisualizer";
         this.btnZoomInNNVisualizer.Size = new System.Drawing.Size(24, 24);
         this.btnZoomInNNVisualizer.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
         this.btnZoomInNNVisualizer.ToolTipText = "Zoom In";
         this.btnZoomInNNVisualizer.Click += new System.EventHandler(this.btnZoomInNNVisualizer_Click);
         // 
         // datasetGrid
         // 
         this.datasetGrid.Dock = System.Windows.Forms.DockStyle.Fill;
         this.datasetGrid.InputLayer = null;
         this.datasetGrid.Location = new System.Drawing.Point(0, 0);
         this.datasetGrid.Margin = new System.Windows.Forms.Padding(4);
         this.datasetGrid.Name = "datasetGrid";
         this.datasetGrid.Size = new System.Drawing.Size(786, 583);
         this.datasetGrid.TabIndex = 3;
         this.datasetGrid.Visible = false;
         // 
         // btnExportAsImageNNVisualizer
         // 
         this.btnExportAsImageNNVisualizer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.btnExportAsImageNNVisualizer.Image = ((System.Drawing.Image)(resources.GetObject("btnExportAsImageNNVisualizer.Image")));
         this.btnExportAsImageNNVisualizer.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.btnExportAsImageNNVisualizer.Name = "btnExportAsImageNNVisualizer";
         this.btnExportAsImageNNVisualizer.Size = new System.Drawing.Size(24, 24);
         this.btnExportAsImageNNVisualizer.Text = "toolStripButton1";
         this.btnExportAsImageNNVisualizer.Click += new System.EventHandler(this.btnExportAsImageNNVisualizer_Click);
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1028, 609);
         this.Controls.Add(this.MainContainer);
         this.Controls.Add(this.mainMenu);
         this.MainMenuStrip = this.mainMenu;
         this.Margin = new System.Windows.Forms.Padding(2);
         this.Name = "MainForm";
         this.Text = "Neural Network Maker";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.Load += new System.EventHandler(this.MainForm_Load);
         this.mainMenu.ResumeLayout(false);
         this.mainMenu.PerformLayout();
         this.MainContainer.Panel1.ResumeLayout(false);
         this.MainContainer.Panel2.ResumeLayout(false);
         this.MainContainer.Panel2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).EndInit();
         this.MainContainer.ResumeLayout(false);
         this.tabActions.ResumeLayout(false);
         this.tabDesign.ResumeLayout(false);
         this.tabTraining.ResumeLayout(false);
         this.ToolbarNNVisualizer.ResumeLayout(false);
         this.ToolbarNNVisualizer.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip mainMenu;
      private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
      private System.Windows.Forms.ToolStripMenuItem NewMenuItem;
      private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator SeparatorMenuItem;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
      private System.Windows.Forms.SplitContainer MainContainer;
      private NeuralNetwork.Visualizer.NeuralNetworkVisualizerControl NNVisualizerControl;
      private System.Windows.Forms.TabControl tabActions;
      private System.Windows.Forms.TabPage tabDesign;
      private System.Windows.Forms.TabPage tabTraining;
      private System.Windows.Forms.TabPage tabPredict;
      private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
      private System.Windows.Forms.ToolStrip ToolbarNNVisualizer;
      private System.Windows.Forms.ToolStripButton btnPreferencesNNVisualizer;
      private System.Windows.Forms.ToolStripComboBox ComboQualityNNVisualizer;
      private System.Windows.Forms.ToolStripButton btnZoomOutNNVisualizer;
      private System.Windows.Forms.ToolStripButton btnZoomInNNVisualizer;
      private MainTabControls.Training.TrainingControl trainingControl;
      private MainTabControls.Training.Datasets.DatasetGrid datasetGrid;
      private MainTabControls.Design.DesignControl designControl;
      private System.Windows.Forms.ToolStripButton btnExportAsImageNNVisualizer;
   }
}

