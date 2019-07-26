namespace NeuralNetworkMaker
{
   partial class DropDownButton
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DropDownButton));
         this.btnDropDown = new System.Windows.Forms.Button();
         this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.SuspendLayout();
         // 
         // btnDropDown
         // 
         this.btnDropDown.Dock = System.Windows.Forms.DockStyle.Fill;
         this.btnDropDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDropDown.Image")));
         this.btnDropDown.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.btnDropDown.Location = new System.Drawing.Point(0, 0);
         this.btnDropDown.Margin = new System.Windows.Forms.Padding(0);
         this.btnDropDown.Name = "btnDropDown";
         this.btnDropDown.Size = new System.Drawing.Size(90, 30);
         this.btnDropDown.TabIndex = 0;
         this.btnDropDown.Text = "Drop Down";
         this.btnDropDown.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
         this.btnDropDown.UseVisualStyleBackColor = true;
         this.btnDropDown.Click += new System.EventHandler(this.btnDropDown_Click);
         // 
         // contextMenuStrip
         // 
         this.contextMenuStrip.AllowMerge = false;
         this.contextMenuStrip.Name = "contextMenuStrip";
         this.contextMenuStrip.ShowImageMargin = false;
         this.contextMenuStrip.Size = new System.Drawing.Size(36, 4);
         this.contextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_ItemClicked);
         // 
         // DropDownButton
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
         this.Controls.Add(this.btnDropDown);
         this.Name = "DropDownButton";
         this.Size = new System.Drawing.Size(90, 30);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button btnDropDown;
      private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
   }
}
