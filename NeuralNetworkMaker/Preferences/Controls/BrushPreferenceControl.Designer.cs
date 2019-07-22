namespace NeuralNetworkMaker.Preferences.Controls
{
    partial class BrushPreferenceControl
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
         this.panBrush = new System.Windows.Forms.Panel();
         this.btnEdit = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // panBrush
         // 
         this.panBrush.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.panBrush.BackColor = System.Drawing.Color.Transparent;
         this.panBrush.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.panBrush.Location = new System.Drawing.Point(0, 0);
         this.panBrush.Margin = new System.Windows.Forms.Padding(0);
         this.panBrush.Name = "panBrush";
         this.panBrush.Size = new System.Drawing.Size(131, 31);
         this.panBrush.TabIndex = 0;
         this.panBrush.Paint += new System.Windows.Forms.PaintEventHandler(this.panBrush_Paint);
         // 
         // btnEdit
         // 
         this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
         this.btnEdit.Location = new System.Drawing.Point(132, 0);
         this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
         this.btnEdit.Name = "btnEdit";
         this.btnEdit.Size = new System.Drawing.Size(37, 32);
         this.btnEdit.TabIndex = 1;
         this.btnEdit.Text = "...";
         this.btnEdit.UseVisualStyleBackColor = false;
         this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
         // 
         // BrushPreferenceControl
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
         this.Controls.Add(this.btnEdit);
         this.Controls.Add(this.panBrush);
         this.Margin = new System.Windows.Forms.Padding(0);
         this.MaximumSize = new System.Drawing.Size(168, 32);
         this.MinimumSize = new System.Drawing.Size(168, 32);
         this.Name = "BrushPreferenceControl";
         this.Size = new System.Drawing.Size(168, 32);
         this.Load += new System.EventHandler(this.BrushPreference_Load);
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panBrush;
        private System.Windows.Forms.Button btnEdit;
    }
}
