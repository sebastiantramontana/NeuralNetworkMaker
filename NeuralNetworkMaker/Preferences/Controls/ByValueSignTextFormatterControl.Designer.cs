namespace NeuralNetworkMaker.Preferences.Controls
{
   partial class ByValueSignTextFormatterControl
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
         NeuralNetwork.Visualizer.Preferences.Text.TextPreference textPreference1 = new NeuralNetwork.Visualizer.Preferences.Text.TextPreference();
         System.Drawing.StringFormat stringFormat1 = new System.Drawing.StringFormat();
         NeuralNetwork.Visualizer.Preferences.Text.TextPreference textPreference2 = new NeuralNetwork.Visualizer.Preferences.Text.TextPreference();
         System.Drawing.StringFormat stringFormat2 = new System.Drawing.StringFormat();
         NeuralNetwork.Visualizer.Preferences.Text.TextPreference textPreference3 = new NeuralNetwork.Visualizer.Preferences.Text.TextPreference();
         System.Drawing.StringFormat stringFormat3 = new System.Drawing.StringFormat();
         this.label1 = new System.Windows.Forms.Label();
         this.lblWhenZero = new System.Windows.Forms.Label();
         this.lblWhenNegative = new System.Windows.Forms.Label();
         this.prefWhenNegative = new NeuralNetworkMaker.Preferences.Controls.TextPreferenceControl();
         this.prefWhenZero = new NeuralNetworkMaker.Preferences.Controls.TextPreferenceControl();
         this.prefWhenPositive = new NeuralNetworkMaker.Preferences.Controls.TextPreferenceControl();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(5, 5);
         this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 10, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(76, 13);
         this.label1.TabIndex = 3;
         this.label1.Text = "When Positive";
         // 
         // lblWhenZero
         // 
         this.lblWhenZero.AutoSize = true;
         this.lblWhenZero.Location = new System.Drawing.Point(216, 5);
         this.lblWhenZero.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
         this.lblWhenZero.Name = "lblWhenZero";
         this.lblWhenZero.Size = new System.Drawing.Size(61, 13);
         this.lblWhenZero.TabIndex = 4;
         this.lblWhenZero.Text = "When Zero";
         // 
         // lblWhenNegative
         // 
         this.lblWhenNegative.AutoSize = true;
         this.lblWhenNegative.Location = new System.Drawing.Point(430, 5);
         this.lblWhenNegative.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
         this.lblWhenNegative.Name = "lblWhenNegative";
         this.lblWhenNegative.Size = new System.Drawing.Size(82, 13);
         this.lblWhenNegative.TabIndex = 5;
         this.lblWhenNegative.Text = "When Negative";
         // 
         // prefWhenNegative
         // 
         this.prefWhenNegative.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
         this.prefWhenNegative.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.prefWhenNegative.Location = new System.Drawing.Point(433, 21);
         this.prefWhenNegative.Margin = new System.Windows.Forms.Padding(5, 3, 10, 10);
         this.prefWhenNegative.Name = "prefWhenNegative";
         this.prefWhenNegative.PreviewText = "Lorem ipsum";
         this.prefWhenNegative.Size = new System.Drawing.Size(204, 37);
         this.prefWhenNegative.TabIndex = 2;
         textPreference1.FontFamily = "Tahoma";
         textPreference1.FontStyle = System.Drawing.FontStyle.Regular;
         stringFormat1.Alignment = System.Drawing.StringAlignment.Center;
         stringFormat1.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
         stringFormat1.LineAlignment = System.Drawing.StringAlignment.Center;
         stringFormat1.Trimming = System.Drawing.StringTrimming.Character;
         textPreference1.Format = stringFormat1;
         this.prefWhenNegative.TextPreference = textPreference1;
         this.prefWhenNegative.TextPreferenceChanged += new System.EventHandler(this.prefWhenControl_TextPreferenceChanged);
         // 
         // prefWhenZero
         // 
         this.prefWhenZero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
         this.prefWhenZero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.prefWhenZero.Location = new System.Drawing.Point(219, 21);
         this.prefWhenZero.Margin = new System.Windows.Forms.Padding(5, 3, 5, 10);
         this.prefWhenZero.Name = "prefWhenZero";
         this.prefWhenZero.PreviewText = "Lorem ipsum";
         this.prefWhenZero.Size = new System.Drawing.Size(204, 37);
         this.prefWhenZero.TabIndex = 1;
         textPreference2.FontFamily = "Tahoma";
         textPreference2.FontStyle = System.Drawing.FontStyle.Regular;
         stringFormat2.Alignment = System.Drawing.StringAlignment.Center;
         stringFormat2.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
         stringFormat2.LineAlignment = System.Drawing.StringAlignment.Center;
         stringFormat2.Trimming = System.Drawing.StringTrimming.Character;
         textPreference2.Format = stringFormat2;
         this.prefWhenZero.TextPreference = textPreference2;
         this.prefWhenZero.TextPreferenceChanged += new System.EventHandler(this.prefWhenControl_TextPreferenceChanged);
         // 
         // prefWhenPositive
         // 
         this.prefWhenPositive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
         this.prefWhenPositive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.prefWhenPositive.Location = new System.Drawing.Point(5, 21);
         this.prefWhenPositive.Margin = new System.Windows.Forms.Padding(5, 3, 5, 10);
         this.prefWhenPositive.Name = "prefWhenPositive";
         this.prefWhenPositive.PreviewText = "Lorem ipsum";
         this.prefWhenPositive.Size = new System.Drawing.Size(204, 36);
         this.prefWhenPositive.TabIndex = 0;
         textPreference3.FontFamily = "Tahoma";
         textPreference3.FontStyle = System.Drawing.FontStyle.Regular;
         stringFormat3.Alignment = System.Drawing.StringAlignment.Center;
         stringFormat3.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
         stringFormat3.LineAlignment = System.Drawing.StringAlignment.Center;
         stringFormat3.Trimming = System.Drawing.StringTrimming.Character;
         textPreference3.Format = stringFormat3;
         this.prefWhenPositive.TextPreference = textPreference3;
         this.prefWhenPositive.TextPreferenceChanged += new System.EventHandler(this.prefWhenControl_TextPreferenceChanged);
         // 
         // ByValueSignTextFormatterControl
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
         this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.Controls.Add(this.lblWhenNegative);
         this.Controls.Add(this.lblWhenZero);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.prefWhenNegative);
         this.Controls.Add(this.prefWhenZero);
         this.Controls.Add(this.prefWhenPositive);
         this.Name = "ByValueSignTextFormatterControl";
         this.Size = new System.Drawing.Size(642, 62);
         this.Load += new System.EventHandler(this.ByValueSignTextFormatterControl_Load);
         this.SizeChanged += new System.EventHandler(this.ByValueSignTextFormatterControl_SizeChanged);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private TextPreferenceControl prefWhenPositive;
      private TextPreferenceControl prefWhenZero;
      private TextPreferenceControl prefWhenNegative;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label lblWhenZero;
      private System.Windows.Forms.Label lblWhenNegative;
   }
}
