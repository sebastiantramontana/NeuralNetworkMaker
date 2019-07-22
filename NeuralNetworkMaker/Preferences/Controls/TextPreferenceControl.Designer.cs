namespace NeuralNetworkMaker.Preferences.Controls
{
    partial class TextPreferenceControl
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
         this.lblPreview = new System.Windows.Forms.Label();
         this.btnEdit = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // lblPreview
         // 
         this.lblPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.lblPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblPreview.Location = new System.Drawing.Point(4, 4);
         this.lblPreview.Margin = new System.Windows.Forms.Padding(4);
         this.lblPreview.Name = "lblPreview";
         this.lblPreview.Size = new System.Drawing.Size(151, 35);
         this.lblPreview.TabIndex = 0;
         this.lblPreview.Text = "Lorem ipsum";
         this.lblPreview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.lblPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.lblPreview_Paint);
         // 
         // btnEdit
         // 
         this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.btnEdit.Location = new System.Drawing.Point(163, 8);
         this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
         this.btnEdit.Name = "btnEdit";
         this.btnEdit.Size = new System.Drawing.Size(37, 28);
         this.btnEdit.TabIndex = 1;
         this.btnEdit.Text = "...";
         this.btnEdit.UseVisualStyleBackColor = true;
         this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
         // 
         // TextPreferenceControl
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
         this.Controls.Add(this.btnEdit);
         this.Controls.Add(this.lblPreview);
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "TextPreferenceControl";
         this.Size = new System.Drawing.Size(204, 43);
         this.Load += new System.EventHandler(this.TextPreferenceControl_Load);
         this.Resize += new System.EventHandler(this.TextPreferenceControl_Resize);
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Button btnEdit;
    }
}
