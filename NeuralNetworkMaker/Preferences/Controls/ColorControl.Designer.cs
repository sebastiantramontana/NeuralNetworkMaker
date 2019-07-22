namespace NeuralNetworkMaker.Preferences.Controls
{
    partial class ColorControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
         this.btnEditColor = new System.Windows.Forms.Button();
         this.panColor = new System.Windows.Forms.Panel();
         this.btnTransparent = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // btnEditColor
         // 
         this.btnEditColor.Location = new System.Drawing.Point(25, 0);
         this.btnEditColor.Margin = new System.Windows.Forms.Padding(0);
         this.btnEditColor.Name = "btnEditColor";
         this.btnEditColor.Size = new System.Drawing.Size(28, 26);
         this.btnEditColor.TabIndex = 16;
         this.btnEditColor.Text = "...";
         this.btnEditColor.UseVisualStyleBackColor = true;
         this.btnEditColor.Click += new System.EventHandler(this.btnEditColor_Click);
         // 
         // panColor
         // 
         this.panColor.BackColor = System.Drawing.Color.Transparent;
         this.panColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.panColor.Location = new System.Drawing.Point(0, 0);
         this.panColor.Margin = new System.Windows.Forms.Padding(0);
         this.panColor.Name = "panColor";
         this.panColor.Size = new System.Drawing.Size(26, 26);
         this.panColor.TabIndex = 15;
         this.panColor.Paint += new System.Windows.Forms.PaintEventHandler(this.panColor_Paint);
         // 
         // btnTransparent
         // 
         this.btnTransparent.BackColor = System.Drawing.SystemColors.Control;
         this.btnTransparent.BackgroundImage = global::NeuralNetworkMaker.Properties.Resources.transparent;
         this.btnTransparent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
         this.btnTransparent.Location = new System.Drawing.Point(53, 0);
         this.btnTransparent.Margin = new System.Windows.Forms.Padding(0);
         this.btnTransparent.Name = "btnTransparent";
         this.btnTransparent.Size = new System.Drawing.Size(28, 26);
         this.btnTransparent.TabIndex = 17;
         this.btnTransparent.UseVisualStyleBackColor = false;
         this.btnTransparent.Click += new System.EventHandler(this.btnTransparent_Click);
         // 
         // ColorControl
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
         this.AutoSize = true;
         this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.Controls.Add(this.btnTransparent);
         this.Controls.Add(this.btnEditColor);
         this.Controls.Add(this.panColor);
         this.Name = "ColorControl";
         this.Size = new System.Drawing.Size(81, 26);
         this.Load += new System.EventHandler(this.ColorControl_Load);
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTransparent;
        private System.Windows.Forms.Button btnEditColor;
        private System.Windows.Forms.Panel panColor;
    }
}
