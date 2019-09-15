namespace NeuralNetworkMaker.MainTabControls.Design
{
   partial class DesignControl
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignControl));
         this.toolbarDesign = new System.Windows.Forms.ToolStrip();
         this.btnAddLayer = new System.Windows.Forms.ToolStripButton();
         this.btnRemoveSelectedLayers = new System.Windows.Forms.ToolStripButton();
         this.btnAddNode = new System.Windows.Forms.ToolStripButton();
         this.btnRemoveSelectedNodes = new System.Windows.Forms.ToolStripButton();
         this.btnToggleBias = new System.Windows.Forms.ToolStripButton();
         this.PropertyGridDesign = new System.Windows.Forms.PropertyGrid();
         this.toolbarDesign.SuspendLayout();
         this.SuspendLayout();
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
         this.toolbarDesign.Location = new System.Drawing.Point(0, 0);
         this.toolbarDesign.Name = "toolbarDesign";
         this.toolbarDesign.Padding = new System.Windows.Forms.Padding(0);
         this.toolbarDesign.Size = new System.Drawing.Size(553, 39);
         this.toolbarDesign.TabIndex = 1;
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
         // PropertyGridDesign
         // 
         this.PropertyGridDesign.Dock = System.Windows.Forms.DockStyle.Fill;
         this.PropertyGridDesign.Location = new System.Drawing.Point(0, 39);
         this.PropertyGridDesign.Margin = new System.Windows.Forms.Padding(2);
         this.PropertyGridDesign.Name = "PropertyGridDesign";
         this.PropertyGridDesign.Size = new System.Drawing.Size(553, 761);
         this.PropertyGridDesign.TabIndex = 2;
         // 
         // DesignControl
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
         this.Controls.Add(this.PropertyGridDesign);
         this.Controls.Add(this.toolbarDesign);
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "DesignControl";
         this.Size = new System.Drawing.Size(553, 800);
         this.Load += new System.EventHandler(this.DesignControl_Load);
         this.toolbarDesign.ResumeLayout(false);
         this.toolbarDesign.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.ToolStrip toolbarDesign;
        private System.Windows.Forms.ToolStripButton btnAddLayer;
        private System.Windows.Forms.ToolStripButton btnRemoveSelectedLayers;
        private System.Windows.Forms.ToolStripButton btnAddNode;
        private System.Windows.Forms.ToolStripButton btnRemoveSelectedNodes;
        private System.Windows.Forms.ToolStripButton btnToggleBias;
        private System.Windows.Forms.PropertyGrid PropertyGridDesign;
    }
}
