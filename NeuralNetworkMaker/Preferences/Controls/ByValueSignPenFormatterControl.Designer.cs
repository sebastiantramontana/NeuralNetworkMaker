namespace NeuralNetworkMaker.Preferences.Controls
{
   partial class ByValueSignPenFormatterControl
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
         this.cboWhenCases = new System.Windows.Forms.ComboBox();
         this.penWhenCase = new NeuralNetworkMaker.Preferences.Controls.PenControl();
         this.SuspendLayout();
         // 
         // cboWhenCases
         // 
         this.cboWhenCases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboWhenCases.FormattingEnabled = true;
         this.cboWhenCases.Location = new System.Drawing.Point(0, 0);
         this.cboWhenCases.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
         this.cboWhenCases.Name = "cboWhenCases";
         this.cboWhenCases.Size = new System.Drawing.Size(146, 21);
         this.cboWhenCases.TabIndex = 1;
         this.cboWhenCases.SelectedIndexChanged += new System.EventHandler(this.cboWhenCases_SelectedIndexChanged);
         // 
         // penWhenCase
         // 
         this.penWhenCase.AutoSize = true;
         this.penWhenCase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.penWhenCase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.penWhenCase.Location = new System.Drawing.Point(0, 26);
         this.penWhenCase.Margin = new System.Windows.Forms.Padding(0);
         this.penWhenCase.Name = "penWhenCase";
         this.penWhenCase.Size = new System.Drawing.Size(432, 261);
         this.penWhenCase.TabIndex = 2;
         this.penWhenCase.PenChanged += new System.EventHandler(this.penWhenCase_PenChanged);
         // 
         // ByValueSignPenFormatterControl
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
         this.AutoSize = true;
         this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.Controls.Add(this.penWhenCase);
         this.Controls.Add(this.cboWhenCases);
         this.Name = "ByValueSignPenFormatterControl";
         this.Size = new System.Drawing.Size(432, 287);
         this.Load += new System.EventHandler(this.ByValueSignPenFormatterControl_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.ComboBox cboWhenCases;
      private PenControl penWhenCase;
   }
}
