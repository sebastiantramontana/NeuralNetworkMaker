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
         this.PropertyGridDesign = new System.Windows.Forms.PropertyGrid();
         this.toolbarDesign = new System.Windows.Forms.ToolStrip();
         this.btnAddLayer = new System.Windows.Forms.ToolStripButton();
         this.btnRemoveSelectedLayers = new System.Windows.Forms.ToolStripButton();
         this.btnAddNode = new System.Windows.Forms.ToolStripButton();
         this.btnRemoveSelectedNodes = new System.Windows.Forms.ToolStripButton();
         this.btnToggleBias = new System.Windows.Forms.ToolStripButton();
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
         this.mainMenu.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
         this.MainContainer.Panel1.SuspendLayout();
         this.MainContainer.Panel2.SuspendLayout();
         this.MainContainer.SuspendLayout();
         this.tabActions.SuspendLayout();
         this.tabDesign.SuspendLayout();
         this.toolbarDesign.SuspendLayout();
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
         this.mainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
         this.mainMenu.Size = new System.Drawing.Size(1901, 28);
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
         this.FileMenuItem.Size = new System.Drawing.Size(44, 24);
         this.FileMenuItem.Text = "File";
         // 
         // NewMenuItem
         // 
         this.NewMenuItem.Name = "NewMenuItem";
         this.NewMenuItem.Size = new System.Drawing.Size(120, 26);
         this.NewMenuItem.Text = "New";
         this.NewMenuItem.Click += new System.EventHandler(this.NewMenuItem_Click);
         // 
         // openToolStripMenuItem
         // 
         this.openToolStripMenuItem.Name = "openToolStripMenuItem";
         this.openToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
         this.openToolStripMenuItem.Text = "Open";
         // 
         // saveToolStripMenuItem
         // 
         this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
         this.saveToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
         this.saveToolStripMenuItem.Text = "Save";
         // 
         // SeparatorMenuItem
         // 
         this.SeparatorMenuItem.Name = "SeparatorMenuItem";
         this.SeparatorMenuItem.Size = new System.Drawing.Size(117, 6);
         // 
         // exitToolStripMenuItem
         // 
         this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
         this.exitToolStripMenuItem.Text = "Exit";
         // 
         // MainContainer
         // 
         this.MainContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this.MainContainer.Location = new System.Drawing.Point(0, 28);
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
         this.MainContainer.Size = new System.Drawing.Size(1901, 1005);
         this.MainContainer.SplitterDistance = 442;
         this.MainContainer.SplitterWidth = 3;
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
         this.tabActions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.tabActions.Name = "tabActions";
         this.tabActions.SelectedIndex = 0;
         this.tabActions.Size = new System.Drawing.Size(440, 1003);
         this.tabActions.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
         this.tabActions.TabIndex = 0;
         this.tabActions.SelectedIndexChanged += new System.EventHandler(this.tabActions_SelectedIndexChanged);
         // 
         // tabDesign
         // 
         this.tabDesign.Controls.Add(this.PropertyGridDesign);
         this.tabDesign.Controls.Add(this.toolbarDesign);
         this.tabDesign.Location = new System.Drawing.Point(4, 27);
         this.tabDesign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.tabDesign.Name = "tabDesign";
         this.tabDesign.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.tabDesign.Size = new System.Drawing.Size(432, 972);
         this.tabDesign.TabIndex = 0;
         this.tabDesign.Text = "Design";
         this.tabDesign.UseVisualStyleBackColor = true;
         // 
         // PropertyGridDesign
         // 
         this.PropertyGridDesign.Dock = System.Windows.Forms.DockStyle.Fill;
         this.PropertyGridDesign.Location = new System.Drawing.Point(3, 41);
         this.PropertyGridDesign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.PropertyGridDesign.Name = "PropertyGridDesign";
         this.PropertyGridDesign.Size = new System.Drawing.Size(426, 929);
         this.PropertyGridDesign.TabIndex = 1;
         // 
         // toolbarDesign
         // 
         this.toolbarDesign.ImageScalingSize = new System.Drawing.Size(32, 32);
         this.toolbarDesign.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddLayer,
            this.btnRemoveSelectedLayers,
            this.btnAddNode,
            this.btnRemoveSelectedNodes,
            this.btnToggleBias});
         this.toolbarDesign.Location = new System.Drawing.Point(3, 2);
         this.toolbarDesign.Name = "toolbarDesign";
         this.toolbarDesign.Padding = new System.Windows.Forms.Padding(0);
         this.toolbarDesign.Size = new System.Drawing.Size(426, 39);
         this.toolbarDesign.TabIndex = 0;
         // 
         // btnAddLayer
         // 
         this.btnAddLayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.btnAddLayer.Enabled = false;
         this.btnAddLayer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddLayer.Image")));
         this.btnAddLayer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
         this.btnAddLayer.ImageTransparentColor = System.Drawing.Color.White;
         this.btnAddLayer.Name = "btnAddLayer";
         this.btnAddLayer.Size = new System.Drawing.Size(36, 36);
         this.btnAddLayer.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
         this.btnAddLayer.ToolTipText = "Insert Layers";
         this.btnAddLayer.Click += new System.EventHandler(this.btnAddLayer_Click);
         // 
         // btnRemoveSelectedLayers
         // 
         this.btnRemoveSelectedLayers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.btnRemoveSelectedLayers.Enabled = false;
         this.btnRemoveSelectedLayers.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveSelectedLayers.Image")));
         this.btnRemoveSelectedLayers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
         this.btnRemoveSelectedLayers.ImageTransparentColor = System.Drawing.Color.White;
         this.btnRemoveSelectedLayers.Name = "btnRemoveSelectedLayers";
         this.btnRemoveSelectedLayers.Size = new System.Drawing.Size(36, 36);
         this.btnRemoveSelectedLayers.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
         this.btnRemoveSelectedLayers.ToolTipText = "Remove Layer";
         this.btnRemoveSelectedLayers.Click += new System.EventHandler(this.btnRemoveSelectedLayers_Click);
         // 
         // btnAddNode
         // 
         this.btnAddNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.btnAddNode.Enabled = false;
         this.btnAddNode.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNode.Image")));
         this.btnAddNode.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
         this.btnAddNode.ImageTransparentColor = System.Drawing.Color.White;
         this.btnAddNode.Name = "btnAddNode";
         this.btnAddNode.Size = new System.Drawing.Size(36, 36);
         this.btnAddNode.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
         this.btnAddNode.ToolTipText = "Add Nodes";
         this.btnAddNode.Click += new System.EventHandler(this.btnAddNode_Click);
         // 
         // btnRemoveSelectedNodes
         // 
         this.btnRemoveSelectedNodes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.btnRemoveSelectedNodes.Enabled = false;
         this.btnRemoveSelectedNodes.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveSelectedNodes.Image")));
         this.btnRemoveSelectedNodes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
         this.btnRemoveSelectedNodes.ImageTransparentColor = System.Drawing.Color.White;
         this.btnRemoveSelectedNodes.Name = "btnRemoveSelectedNodes";
         this.btnRemoveSelectedNodes.Size = new System.Drawing.Size(36, 36);
         this.btnRemoveSelectedNodes.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
         this.btnRemoveSelectedNodes.ToolTipText = "Remove Node";
         this.btnRemoveSelectedNodes.Click += new System.EventHandler(this.btnRemoveSelectedNodes_Click);
         // 
         // btnToggleBias
         // 
         this.btnToggleBias.CheckOnClick = true;
         this.btnToggleBias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.btnToggleBias.Enabled = false;
         this.btnToggleBias.Image = ((System.Drawing.Image)(resources.GetObject("btnToggleBias.Image")));
         this.btnToggleBias.ImageTransparentColor = System.Drawing.Color.White;
         this.btnToggleBias.Name = "btnToggleBias";
         this.btnToggleBias.Size = new System.Drawing.Size(36, 36);
         this.btnToggleBias.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
         this.btnToggleBias.ToolTipText = "Add/Remove Bias";
         this.btnToggleBias.Click += new System.EventHandler(this.btnToggleBias_Click);
         // 
         // tabTraining
         // 
         this.tabTraining.Controls.Add(this.trainingControl);
         this.tabTraining.Location = new System.Drawing.Point(4, 27);
         this.tabTraining.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.tabTraining.Name = "tabTraining";
         this.tabTraining.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.tabTraining.Size = new System.Drawing.Size(432, 972);
         this.tabTraining.TabIndex = 1;
         this.tabTraining.Text = "Training";
         this.tabTraining.UseVisualStyleBackColor = true;
         // 
         // trainingControl
         // 
         this.trainingControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.trainingControl.Location = new System.Drawing.Point(0, 0);
         this.trainingControl.Margin = new System.Windows.Forms.Padding(0);
         this.trainingControl.Name = "trainingControl";
         this.trainingControl.Size = new System.Drawing.Size(432, 970);
         this.trainingControl.TabIndex = 0;
         this.trainingControl.VisualizerControl = null;
         // 
         // tabPredict
         // 
         this.tabPredict.Location = new System.Drawing.Point(4, 27);
         this.tabPredict.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.tabPredict.Name = "tabPredict";
         this.tabPredict.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.tabPredict.Size = new System.Drawing.Size(432, 972);
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
         this.NNVisualizerControl.Location = new System.Drawing.Point(0, 28);
         this.NNVisualizerControl.Margin = new System.Windows.Forms.Padding(5);
         this.NNVisualizerControl.Name = "NNVisualizerControl";
         this.NNVisualizerControl.Selectable = true;
         this.NNVisualizerControl.Size = new System.Drawing.Size(1454, 975);
         this.NNVisualizerControl.TabIndex = 2;
         this.NNVisualizerControl.Zoom = 1F;
         // 
         // ToolbarNNVisualizer
         // 
         this.ToolbarNNVisualizer.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.ToolbarNNVisualizer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPreferencesNNVisualizer,
            this.ComboQualityNNVisualizer,
            this.btnZoomOutNNVisualizer,
            this.btnZoomInNNVisualizer});
         this.ToolbarNNVisualizer.Location = new System.Drawing.Point(0, 0);
         this.ToolbarNNVisualizer.Name = "ToolbarNNVisualizer";
         this.ToolbarNNVisualizer.Size = new System.Drawing.Size(1454, 28);
         this.ToolbarNNVisualizer.TabIndex = 1;
         // 
         // btnPreferencesNNVisualizer
         // 
         this.btnPreferencesNNVisualizer.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
         this.btnPreferencesNNVisualizer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.btnPreferencesNNVisualizer.Image = ((System.Drawing.Image)(resources.GetObject("btnPreferencesNNVisualizer.Image")));
         this.btnPreferencesNNVisualizer.ImageTransparentColor = System.Drawing.Color.White;
         this.btnPreferencesNNVisualizer.Name = "btnPreferencesNNVisualizer";
         this.btnPreferencesNNVisualizer.Size = new System.Drawing.Size(24, 25);
         this.btnPreferencesNNVisualizer.Click += new System.EventHandler(this.btnPreferencesNNVisualizer_Click);
         // 
         // ComboQualityNNVisualizer
         // 
         this.ComboQualityNNVisualizer.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
         this.ComboQualityNNVisualizer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.ComboQualityNNVisualizer.Name = "ComboQualityNNVisualizer";
         this.ComboQualityNNVisualizer.Size = new System.Drawing.Size(121, 28);
         this.ComboQualityNNVisualizer.ToolTipText = "Graphics Quality";
         this.ComboQualityNNVisualizer.SelectedIndexChanged += new System.EventHandler(this.ComboQualityNNVisualizer_SelectedIndexChanged);
         // 
         // btnZoomOutNNVisualizer
         // 
         this.btnZoomOutNNVisualizer.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
         this.btnZoomOutNNVisualizer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.btnZoomOutNNVisualizer.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomOutNNVisualizer.Image")));
         this.btnZoomOutNNVisualizer.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.btnZoomOutNNVisualizer.Name = "btnZoomOutNNVisualizer";
         this.btnZoomOutNNVisualizer.Size = new System.Drawing.Size(24, 25);
         this.btnZoomOutNNVisualizer.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
         this.btnZoomOutNNVisualizer.ToolTipText = "Zoom Out";
         this.btnZoomOutNNVisualizer.Click += new System.EventHandler(this.btnZoomOutNNVisualizer_Click);
         // 
         // btnZoomInNNVisualizer
         // 
         this.btnZoomInNNVisualizer.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
         this.btnZoomInNNVisualizer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.btnZoomInNNVisualizer.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomInNNVisualizer.Image")));
         this.btnZoomInNNVisualizer.ImageTransparentColor = System.Drawing.Color.White;
         this.btnZoomInNNVisualizer.Name = "btnZoomInNNVisualizer";
         this.btnZoomInNNVisualizer.Size = new System.Drawing.Size(24, 25);
         this.btnZoomInNNVisualizer.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
         this.btnZoomInNNVisualizer.ToolTipText = "Zoom In";
         this.btnZoomInNNVisualizer.Click += new System.EventHandler(this.btnZoomInNNVisualizer_Click);
         // 
         // datasetGrid
         // 
         this.datasetGrid.Dock = System.Windows.Forms.DockStyle.Fill;
         this.datasetGrid.Location = new System.Drawing.Point(0, 0);
         this.datasetGrid.Margin = new System.Windows.Forms.Padding(4);
         this.datasetGrid.Name = "datasetGrid";
         this.datasetGrid.Size = new System.Drawing.Size(1454, 1003);
         this.datasetGrid.TabIndex = 3;
         this.datasetGrid.Visible = false;
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1901, 1033);
         this.Controls.Add(this.MainContainer);
         this.Controls.Add(this.mainMenu);
         this.MainMenuStrip = this.mainMenu;
         this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
         this.tabDesign.PerformLayout();
         this.toolbarDesign.ResumeLayout(false);
         this.toolbarDesign.PerformLayout();
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
      private System.Windows.Forms.ToolStrip toolbarDesign;
      private System.Windows.Forms.ToolStripButton btnAddLayer;
      private System.Windows.Forms.ToolStripButton btnRemoveSelectedLayers;
      private System.Windows.Forms.ToolStripButton btnAddNode;
      private System.Windows.Forms.ToolStripButton btnRemoveSelectedNodes;
      private System.Windows.Forms.PropertyGrid PropertyGridDesign;
      private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
      private System.Windows.Forms.ToolStrip ToolbarNNVisualizer;
      private System.Windows.Forms.ToolStripButton btnPreferencesNNVisualizer;
      private System.Windows.Forms.ToolStripComboBox ComboQualityNNVisualizer;
      private System.Windows.Forms.ToolStripButton btnZoomOutNNVisualizer;
      private System.Windows.Forms.ToolStripButton btnZoomInNNVisualizer;
      private System.Windows.Forms.ToolStripButton btnToggleBias;
      private MainTabControls.Training.TrainingControl trainingControl;
      private MainTabControls.Training.Datasets.DatasetGrid datasetGrid;
   }
}

