namespace NeuralNetworkMaker.Preferences.Controls
{
   partial class NodePreferenceControl
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
         this.spinRoundingDigits = new System.Windows.Forms.NumericUpDown();
         this.label7 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.penBorderSelected = new NeuralNetworkMaker.Preferences.Controls.PenControl();
         this.penBorder = new NeuralNetworkMaker.Preferences.Controls.PenControl();
         this.brushBackgroundSelected = new NeuralNetworkMaker.Preferences.Controls.BrushPreferenceControl();
         this.brushBackground = new NeuralNetworkMaker.Preferences.Controls.BrushPreferenceControl();
         this.formatterOutputValue = new NeuralNetworkMaker.Preferences.Controls.ByValueSignTextFormatterControl();
         ((System.ComponentModel.ISupportInitialize)(this.spinRoundingDigits)).BeginInit();
         this.SuspendLayout();
         // 
         // spinRoundingDigits
         // 
         this.spinRoundingDigits.Location = new System.Drawing.Point(5, 35);
         this.spinRoundingDigits.Margin = new System.Windows.Forms.Padding(5);
         this.spinRoundingDigits.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
         this.spinRoundingDigits.Name = "spinRoundingDigits";
         this.spinRoundingDigits.Size = new System.Drawing.Size(168, 20);
         this.spinRoundingDigits.TabIndex = 13;
         this.spinRoundingDigits.ValueChanged += new System.EventHandler(this.spinRoundingDigits_ValueChanged);
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(5, 17);
         this.label7.Margin = new System.Windows.Forms.Padding(5, 5, 4, 0);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(82, 13);
         this.label7.TabIndex = 12;
         this.label7.Text = "Rounding Digits";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(2, 156);
         this.label6.Margin = new System.Windows.Forms.Padding(5, 5, 4, 3);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(38, 13);
         this.label6.TabIndex = 11;
         this.label6.Text = "Border";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(180, 5);
         this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 3);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(65, 13);
         this.label1.TabIndex = 8;
         this.label1.Text = "Background";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(358, 5);
         this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 3);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(110, 13);
         this.label4.TabIndex = 16;
         this.label4.Text = "Background Selected";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(443, 156);
         this.label8.Margin = new System.Windows.Forms.Padding(5, 5, 4, 3);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(83, 13);
         this.label8.TabIndex = 19;
         this.label8.Text = "Border Selected";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(4, 65);
         this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 3);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(104, 13);
         this.label2.TabIndex = 23;
         this.label2.Text = "Output Value Format";
         // 
         // penBorderSelected
         // 
         this.penBorderSelected.AutoSize = true;
         this.penBorderSelected.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.penBorderSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.penBorderSelected.Location = new System.Drawing.Point(446, 175);
         this.penBorderSelected.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
         this.penBorderSelected.Name = "penBorderSelected";
         this.penBorderSelected.Size = new System.Drawing.Size(432, 261);
         this.penBorderSelected.TabIndex = 21;
         this.penBorderSelected.PenChanged += new System.EventHandler(this.penBorderSelected_PenChanged);
         // 
         // penBorder
         // 
         this.penBorder.AutoSize = true;
         this.penBorder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.penBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.penBorder.Location = new System.Drawing.Point(5, 175);
         this.penBorder.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
         this.penBorder.Name = "penBorder";
         this.penBorder.Size = new System.Drawing.Size(432, 261);
         this.penBorder.TabIndex = 20;
         this.penBorder.PenChanged += new System.EventHandler(this.penBorder_PenChanged);
         // 
         // brushBackgroundSelected
         // 
         this.brushBackgroundSelected.Brush = null;
         this.brushBackgroundSelected.Location = new System.Drawing.Point(361, 23);
         this.brushBackgroundSelected.Margin = new System.Windows.Forms.Padding(5);
         this.brushBackgroundSelected.MaximumSize = new System.Drawing.Size(168, 32);
         this.brushBackgroundSelected.MinimumSize = new System.Drawing.Size(168, 32);
         this.brushBackgroundSelected.Name = "brushBackgroundSelected";
         this.brushBackgroundSelected.Size = new System.Drawing.Size(168, 32);
         this.brushBackgroundSelected.TabIndex = 17;
         this.brushBackgroundSelected.BrushChanged += new System.EventHandler(this.brushBackgroundSelected_BrushChanged);
         // 
         // brushBackground
         // 
         this.brushBackground.Brush = null;
         this.brushBackground.Location = new System.Drawing.Point(183, 23);
         this.brushBackground.Margin = new System.Windows.Forms.Padding(5);
         this.brushBackground.MaximumSize = new System.Drawing.Size(168, 32);
         this.brushBackground.MinimumSize = new System.Drawing.Size(168, 32);
         this.brushBackground.Name = "brushBackground";
         this.brushBackground.Size = new System.Drawing.Size(168, 32);
         this.brushBackground.TabIndex = 15;
         this.brushBackground.BrushChanged += new System.EventHandler(this.brushBackground_BrushChanged);
         // 
         // formatterOutputValue
         // 
         this.formatterOutputValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.formatterOutputValue.Location = new System.Drawing.Point(5, 84);
         this.formatterOutputValue.Margin = new System.Windows.Forms.Padding(5);
         this.formatterOutputValue.Name = "formatterOutputValue";
         this.formatterOutputValue.Size = new System.Drawing.Size(873, 62);
         this.formatterOutputValue.TabIndex = 24;
         this.formatterOutputValue.TextFormatterChanged += new System.EventHandler(this.formatterOutputValue_TextFormatterChanged);
         // 
         // NodePreferenceControl
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
         this.AutoSize = true;
         this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.Controls.Add(this.formatterOutputValue);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.penBorderSelected);
         this.Controls.Add(this.penBorder);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.brushBackgroundSelected);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.brushBackground);
         this.Controls.Add(this.spinRoundingDigits);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label1);
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "NodePreferenceControl";
         this.Size = new System.Drawing.Size(883, 441);
         this.Load += new System.EventHandler(this.NodePreferenceControl_Load);
         ((System.ComponentModel.ISupportInitialize)(this.spinRoundingDigits)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.NumericUpDown spinRoundingDigits;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label1;
      private BrushPreferenceControl brushBackground;
      private BrushPreferenceControl brushBackgroundSelected;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label8;
      private PenControl penBorder;
      private PenControl penBorderSelected;
      private System.Windows.Forms.Label label2;
      private ByValueSignTextFormatterControl formatterOutputValue;
   }
}
