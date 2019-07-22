namespace NeuralNetworkMaker.Preferences.Dialogs
{
    partial class frmTextPreference
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
         this.cboFontFamily = new System.Windows.Forms.ComboBox();
         this.chBold = new System.Windows.Forms.CheckBox();
         this.chItalic = new System.Windows.Forms.CheckBox();
         this.chUnderline = new System.Windows.Forms.CheckBox();
         this.chStrikeout = new System.Windows.Forms.CheckBox();
         this.btnOk = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.lblPreview = new System.Windows.Forms.Label();
         this.brhPreference = new NeuralNetworkMaker.Preferences.Controls.BrushPreferenceControl();
         this.SuspendLayout();
         // 
         // cboFontFamily
         // 
         this.cboFontFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboFontFamily.FormattingEnabled = true;
         this.cboFontFamily.Location = new System.Drawing.Point(12, 12);
         this.cboFontFamily.Name = "cboFontFamily";
         this.cboFontFamily.Size = new System.Drawing.Size(145, 21);
         this.cboFontFamily.TabIndex = 1;
         this.cboFontFamily.SelectedIndexChanged += new System.EventHandler(this.cboFontFamily_SelectedIndexChanged);
         // 
         // chBold
         // 
         this.chBold.Appearance = System.Windows.Forms.Appearance.Button;
         this.chBold.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.chBold.Location = new System.Drawing.Point(163, 7);
         this.chBold.Name = "chBold";
         this.chBold.Size = new System.Drawing.Size(32, 32);
         this.chBold.TabIndex = 2;
         this.chBold.Text = "B";
         this.chBold.UseVisualStyleBackColor = true;
         this.chBold.CheckedChanged += new System.EventHandler(this.chBold_CheckedChanged);
         // 
         // chItalic
         // 
         this.chItalic.Appearance = System.Windows.Forms.Appearance.Button;
         this.chItalic.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.chItalic.Location = new System.Drawing.Point(198, 7);
         this.chItalic.Name = "chItalic";
         this.chItalic.Size = new System.Drawing.Size(32, 32);
         this.chItalic.TabIndex = 3;
         this.chItalic.Text = "I";
         this.chItalic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.chItalic.UseVisualStyleBackColor = true;
         this.chItalic.CheckedChanged += new System.EventHandler(this.chItalic_CheckedChanged);
         // 
         // chUnderline
         // 
         this.chUnderline.Appearance = System.Windows.Forms.Appearance.Button;
         this.chUnderline.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.chUnderline.Location = new System.Drawing.Point(232, 7);
         this.chUnderline.Name = "chUnderline";
         this.chUnderline.Size = new System.Drawing.Size(32, 32);
         this.chUnderline.TabIndex = 4;
         this.chUnderline.Text = "U";
         this.chUnderline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.chUnderline.UseVisualStyleBackColor = true;
         this.chUnderline.CheckedChanged += new System.EventHandler(this.chUnderline_CheckedChanged);
         // 
         // chStrikeout
         // 
         this.chStrikeout.Appearance = System.Windows.Forms.Appearance.Button;
         this.chStrikeout.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.chStrikeout.Location = new System.Drawing.Point(265, 7);
         this.chStrikeout.Name = "chStrikeout";
         this.chStrikeout.Size = new System.Drawing.Size(32, 32);
         this.chStrikeout.TabIndex = 5;
         this.chStrikeout.Text = "S";
         this.chStrikeout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.chStrikeout.UseVisualStyleBackColor = true;
         this.chStrikeout.CheckedChanged += new System.EventHandler(this.chStrikeout_CheckedChanged);
         // 
         // btnOk
         // 
         this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.btnOk.Location = new System.Drawing.Point(270, 121);
         this.btnOk.Name = "btnOk";
         this.btnOk.Size = new System.Drawing.Size(75, 23);
         this.btnOk.TabIndex = 7;
         this.btnOk.Text = "OK";
         this.btnOk.UseVisualStyleBackColor = true;
         this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancel.Location = new System.Drawing.Point(351, 121);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 8;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         // 
         // lblPreview
         // 
         this.lblPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.lblPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.lblPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblPreview.Location = new System.Drawing.Point(9, 42);
         this.lblPreview.Margin = new System.Windows.Forms.Padding(0);
         this.lblPreview.Name = "lblPreview";
         this.lblPreview.Size = new System.Drawing.Size(417, 76);
         this.lblPreview.TabIndex = 9;
         this.lblPreview.Text = "Lorem ipsum";
         this.lblPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.lblPreview_Paint);
         // 
         // brhPreference
         // 
         this.brhPreference.Brush = null;
         this.brhPreference.Location = new System.Drawing.Point(300, 9);
         this.brhPreference.Margin = new System.Windows.Forms.Padding(0);
         this.brhPreference.MaximumSize = new System.Drawing.Size(126, 32);
         this.brhPreference.MinimumSize = new System.Drawing.Size(126, 32);
         this.brhPreference.Name = "brhPreference";
         this.brhPreference.Size = new System.Drawing.Size(126, 32);
         this.brhPreference.TabIndex = 6;
         this.brhPreference.BrushChanged += new System.EventHandler(this.brhPreference_BrushChanged);
         // 
         // frmTextPreference
         // 
         this.AcceptButton = this.btnOk;
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
         this.CancelButton = this.btnCancel;
         this.ClientSize = new System.Drawing.Size(435, 152);
         this.Controls.Add(this.lblPreview);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnOk);
         this.Controls.Add(this.brhPreference);
         this.Controls.Add(this.chStrikeout);
         this.Controls.Add(this.chUnderline);
         this.Controls.Add(this.chItalic);
         this.Controls.Add(this.chBold);
         this.Controls.Add(this.cboFontFamily);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmTextPreference";
         this.Text = "Text Preference";
         this.Load += new System.EventHandler(this.frmTextPreference_Load);
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboFontFamily;
        private System.Windows.Forms.CheckBox chBold;
        private System.Windows.Forms.CheckBox chItalic;
        private System.Windows.Forms.CheckBox chUnderline;
        private System.Windows.Forms.CheckBox chStrikeout;
        private Controls.BrushPreferenceControl brhPreference;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPreview;
    }
}