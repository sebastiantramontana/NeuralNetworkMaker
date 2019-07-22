namespace NeuralNetworkMaker.Preferences.Controls
{
   partial class PenControl
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
         this.label1 = new System.Windows.Forms.Label();
         this.spinLineWidth = new System.Windows.Forms.NumericUpDown();
         this.label2 = new System.Windows.Forms.Label();
         this.cboDashStyle = new System.Windows.Forms.ComboBox();
         this.label5 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.spinDashOffset = new System.Windows.Forms.NumericUpDown();
         this.cboDashCap = new System.Windows.Forms.ComboBox();
         this.label3 = new System.Windows.Forms.Label();
         this.cboStartCap = new System.Windows.Forms.ComboBox();
         this.label6 = new System.Windows.Forms.Label();
         this.cboEndCap = new System.Windows.Forms.ComboBox();
         this.label7 = new System.Windows.Forms.Label();
         this.panPreview = new System.Windows.Forms.Panel();
         this.colPenColor = new NeuralNetworkMaker.Preferences.Controls.ColorControl();
         ((System.ComponentModel.ISupportInitialize)(this.spinLineWidth)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.spinDashOffset)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(10, 10);
         this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 4, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(41, 17);
         this.label1.TabIndex = 1;
         this.label1.Text = "Color";
         // 
         // spinLineWidth
         // 
         this.spinLineWidth.Location = new System.Drawing.Point(219, 43);
         this.spinLineWidth.Margin = new System.Windows.Forms.Padding(5, 4, 4, 10);
         this.spinLineWidth.Name = "spinLineWidth";
         this.spinLineWidth.Size = new System.Drawing.Size(98, 22);
         this.spinLineWidth.TabIndex = 2;
         this.spinLineWidth.ValueChanged += new System.EventHandler(this.spinLineWidth_ValueChanged);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(216, 22);
         this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 4, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(75, 17);
         this.label2.TabIndex = 3;
         this.label2.Text = "Line Width";
         // 
         // cboDashStyle
         // 
         this.cboDashStyle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
         this.cboDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboDashStyle.FormattingEnabled = true;
         this.cboDashStyle.ItemHeight = 15;
         this.cboDashStyle.Location = new System.Drawing.Point(10, 94);
         this.cboDashStyle.Margin = new System.Windows.Forms.Padding(10, 4, 4, 10);
         this.cboDashStyle.Name = "cboDashStyle";
         this.cboDashStyle.Size = new System.Drawing.Size(200, 21);
         this.cboDashStyle.TabIndex = 12;
         this.cboDashStyle.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboDashStyle_DrawItem);
         this.cboDashStyle.SelectedIndexChanged += new System.EventHandler(this.cboDashStyle_SelectedIndexChanged);
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(7, 73);
         this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 4, 0);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(76, 17);
         this.label5.TabIndex = 11;
         this.label5.Text = "Dash Style";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(319, 22);
         this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 4, 0);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(83, 17);
         this.label4.TabIndex = 10;
         this.label4.Text = "Dash Offset";
         // 
         // spinDashOffset
         // 
         this.spinDashOffset.Location = new System.Drawing.Point(322, 43);
         this.spinDashOffset.Margin = new System.Windows.Forms.Padding(5, 4, 10, 10);
         this.spinDashOffset.Name = "spinDashOffset";
         this.spinDashOffset.Size = new System.Drawing.Size(97, 22);
         this.spinDashOffset.TabIndex = 9;
         this.spinDashOffset.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
         this.spinDashOffset.ValueChanged += new System.EventHandler(this.spinDashOffset_ValueChanged);
         // 
         // cboDashCap
         // 
         this.cboDashCap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
         this.cboDashCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboDashCap.FormattingEnabled = true;
         this.cboDashCap.ItemHeight = 15;
         this.cboDashCap.Location = new System.Drawing.Point(219, 94);
         this.cboDashCap.Margin = new System.Windows.Forms.Padding(5, 4, 10, 10);
         this.cboDashCap.Name = "cboDashCap";
         this.cboDashCap.Size = new System.Drawing.Size(200, 21);
         this.cboDashCap.TabIndex = 8;
         this.cboDashCap.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboDashCap_DrawItem);
         this.cboDashCap.SelectedIndexChanged += new System.EventHandler(this.cboDashCap_SelectedIndexChanged);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(216, 73);
         this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 4, 0);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(70, 17);
         this.label3.TabIndex = 7;
         this.label3.Text = "Dash Cap";
         // 
         // cboStartCap
         // 
         this.cboStartCap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
         this.cboStartCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboStartCap.FormattingEnabled = true;
         this.cboStartCap.ItemHeight = 15;
         this.cboStartCap.Location = new System.Drawing.Point(10, 146);
         this.cboStartCap.Margin = new System.Windows.Forms.Padding(10, 4, 4, 10);
         this.cboStartCap.Name = "cboStartCap";
         this.cboStartCap.Size = new System.Drawing.Size(200, 21);
         this.cboStartCap.TabIndex = 18;
         this.cboStartCap.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboStartCap_DrawItem);
         this.cboStartCap.SelectedIndexChanged += new System.EventHandler(this.cboStartCap_SelectedIndexChanged);
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(10, 125);
         this.label6.Margin = new System.Windows.Forms.Padding(10, 0, 4, 0);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(67, 17);
         this.label6.TabIndex = 17;
         this.label6.Text = "Start Cap";
         // 
         // cboEndCap
         // 
         this.cboEndCap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
         this.cboEndCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboEndCap.FormattingEnabled = true;
         this.cboEndCap.ItemHeight = 15;
         this.cboEndCap.Location = new System.Drawing.Point(219, 146);
         this.cboEndCap.Margin = new System.Windows.Forms.Padding(5, 4, 10, 10);
         this.cboEndCap.Name = "cboEndCap";
         this.cboEndCap.Size = new System.Drawing.Size(200, 21);
         this.cboEndCap.TabIndex = 20;
         this.cboEndCap.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboEndCap_DrawItem);
         this.cboEndCap.SelectedIndexChanged += new System.EventHandler(this.cboEndCap_SelectedIndexChanged);
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(216, 125);
         this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(62, 17);
         this.label7.TabIndex = 19;
         this.label7.Text = "End Cap";
         // 
         // panPreview
         // 
         this.panPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panPreview.Location = new System.Drawing.Point(10, 181);
         this.panPreview.Margin = new System.Windows.Forms.Padding(10, 4, 10, 10);
         this.panPreview.Name = "panPreview";
         this.panPreview.Size = new System.Drawing.Size(410, 68);
         this.panPreview.TabIndex = 25;
         this.panPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.panPreview_Paint);
         // 
         // colPenColor
         // 
         this.colPenColor.AutoSize = true;
         this.colPenColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.colPenColor.Location = new System.Drawing.Point(10, 31);
         this.colPenColor.Margin = new System.Windows.Forms.Padding(10, 4, 4, 10);
         this.colPenColor.Name = "colPenColor";
         this.colPenColor.SelectedColor = System.Drawing.Color.Transparent;
         this.colPenColor.Size = new System.Drawing.Size(108, 32);
         this.colPenColor.TabIndex = 26;
         this.colPenColor.ColorChanged += new System.EventHandler(this.colPenColor_ColorChanged);
         // 
         // SimplePenControl
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
         this.AutoSize = true;
         this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.Controls.Add(this.spinDashOffset);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.cboDashStyle);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.cboDashCap);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.colPenColor);
         this.Controls.Add(this.panPreview);
         this.Controls.Add(this.cboEndCap);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.cboStartCap);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.spinLineWidth);
         this.Controls.Add(this.label1);
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "SimplePenControl";
         this.Size = new System.Drawing.Size(430, 259);
         this.Load += new System.EventHandler(this.PenControl_Load);
         ((System.ComponentModel.ISupportInitialize)(this.spinLineWidth)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.spinDashOffset)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.NumericUpDown spinLineWidth;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.ComboBox cboDashStyle;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.NumericUpDown spinDashOffset;
      private System.Windows.Forms.ComboBox cboDashCap;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.ComboBox cboStartCap;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.ComboBox cboEndCap;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Panel panPreview;
      private ColorControl colPenColor;
   }
}
