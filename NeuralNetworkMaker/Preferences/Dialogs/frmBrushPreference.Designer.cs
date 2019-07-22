namespace NeuralNetworkMaker.Preferences.Dialogs
{
    partial class frmBrushPreference
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
            this.panPreview = new System.Windows.Forms.Panel();
            this.radSolid = new System.Windows.Forms.RadioButton();
            this.radGradient = new System.Windows.Forms.RadioButton();
            this.spinAngle = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.Color2 = new NeuralNetworkMaker.Preferences.Controls.ColorControl();
            this.Color1 = new NeuralNetworkMaker.Preferences.Controls.ColorControl();
            ((System.ComponentModel.ISupportInitialize)(this.spinAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // panPreview
            // 
            this.panPreview.BackColor = System.Drawing.Color.Transparent;
            this.panPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panPreview.Location = new System.Drawing.Point(12, 75);
            this.panPreview.Name = "panPreview";
            this.panPreview.Size = new System.Drawing.Size(357, 101);
            this.panPreview.TabIndex = 1;
            this.panPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.panPreview_Paint);
            // 
            // radSolid
            // 
            this.radSolid.AutoSize = true;
            this.radSolid.Checked = true;
            this.radSolid.Location = new System.Drawing.Point(12, 12);
            this.radSolid.Name = "radSolid";
            this.radSolid.Size = new System.Drawing.Size(48, 17);
            this.radSolid.TabIndex = 2;
            this.radSolid.TabStop = true;
            this.radSolid.Text = "Solid";
            this.radSolid.UseVisualStyleBackColor = true;
            // 
            // radGradient
            // 
            this.radGradient.AutoSize = true;
            this.radGradient.Location = new System.Drawing.Point(66, 12);
            this.radGradient.Name = "radGradient";
            this.radGradient.Size = new System.Drawing.Size(65, 17);
            this.radGradient.TabIndex = 3;
            this.radGradient.Text = "Gradient";
            this.radGradient.UseVisualStyleBackColor = true;
            this.radGradient.CheckedChanged += new System.EventHandler(this.radGradient_CheckedChanged);
            // 
            // spinAngle
            // 
            this.spinAngle.Enabled = false;
            this.spinAngle.Increment = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.spinAngle.Location = new System.Drawing.Point(321, 48);
            this.spinAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.spinAngle.Name = "spinAngle";
            this.spinAngle.Size = new System.Drawing.Size(48, 20);
            this.spinAngle.TabIndex = 8;
            this.spinAngle.ValueChanged += new System.EventHandler(this.spinAngle_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Color 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Color 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Angle";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(295, 182);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(216, 182);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Color2
            // 
            this.Color2.AutoSize = true;
            this.Color2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Color2.Enabled = false;
            this.Color2.Location = new System.Drawing.Point(194, 43);
            this.Color2.Name = "Color2";
            this.Color2.Size = new System.Drawing.Size(81, 26);
            this.Color2.TabIndex = 17;
            this.Color2.ColorChanged += new System.EventHandler(this.Color2_ColorChanged);
            // 
            // Color1
            // 
            this.Color1.AutoSize = true;
            this.Color1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Color1.Location = new System.Drawing.Point(58, 43);
            this.Color1.Name = "Color1";
            this.Color1.Size = new System.Drawing.Size(81, 26);
            this.Color1.TabIndex = 16;
            this.Color1.ColorChanged += new System.EventHandler(this.Color1_ColorChanged);
            // 
            // frmBrushPreference
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(383, 217);
            this.Controls.Add(this.Color2);
            this.Controls.Add(this.Color1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spinAngle);
            this.Controls.Add(this.radGradient);
            this.Controls.Add(this.radSolid);
            this.Controls.Add(this.panPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBrushPreference";
            this.Text = "Brush Preference";
            this.Load += new System.EventHandler(this.frmBrushPreference_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spinAngle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panPreview;
        private System.Windows.Forms.RadioButton radSolid;
        private System.Windows.Forms.RadioButton radGradient;
        private System.Windows.Forms.NumericUpDown spinAngle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private Controls.ColorControl Color1;
        private Controls.ColorControl Color2;
    }
}