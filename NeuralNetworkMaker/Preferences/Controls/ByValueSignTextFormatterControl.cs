using NeuralNetwork.Visualizer.Preferences.Formatting;
using NeuralNetwork.Visualizer.Preferences.Text;
using System;
using System.Windows.Forms;

namespace NeuralNetworkMaker.Preferences.Controls
{
   public partial class ByValueSignTextFormatterControl : UserControl
   {
      public event EventHandler TextFormatterChanged;

      public ByValueSignTextFormatterControl()
      {
         InitializeComponent();

         TextPreference textPreferenceDefault() => new TextPreference();
         this.ByValueSignTextFormatter = new ByValueSignFormatter<TextPreference>(textPreferenceDefault, textPreferenceDefault, textPreferenceDefault, textPreferenceDefault);
      }

      private ByValueSignFormatter<TextPreference> _byValueSignTextFormatter;
      public ByValueSignFormatter<TextPreference> ByValueSignTextFormatter
      {
         get => _byValueSignTextFormatter;
         set
         {
            _byValueSignTextFormatter = value;
            SetControls();
         }
      }

      private bool _isInitialized = false;
      private void ByValueSignTextFormatterControl_Load(object sender, EventArgs e)
      {
         SetControls();
         SetControlsSizePosition();

         _isInitialized = true;
      }

      private void ByValueSignTextFormatterControl_SizeChanged(object sender, EventArgs e)
      {
         if (!_isInitialized)
         {
            return;
         }

         SetControlsSizePosition();
      }

      private void prefWhenControl_TextPreferenceChanged(object sender, EventArgs e)
      {
         SetByValueSignTextFormatter();
      }

      private void SetControls()
      {
         prefWhenPositive.TextPreference = this.ByValueSignTextFormatter.WhenPositive();
         prefWhenZero.TextPreference = this.ByValueSignTextFormatter.WhenZero();
         prefWhenNegative.TextPreference = this.ByValueSignTextFormatter.WhenNegative();
      }

      private void SetByValueSignTextFormatter()
      {
         if (!_isInitialized)
         {
            return;
         }

         TextPreference whenPositive = prefWhenPositive.TextPreference.Clone();
         TextPreference whenZero = prefWhenZero.TextPreference.Clone();
         TextPreference whenNegative = prefWhenNegative.TextPreference.Clone();

         this.ByValueSignTextFormatter = new ByValueSignFormatter<TextPreference>(() => whenNegative.Clone(), () => whenZero.Clone(), () => whenPositive.Clone(), () => TextPreference.Null);

         TextFormatterChanged?.Invoke(this, EventArgs.Empty);
      }

      private void SetControlsSizePosition()
      {
         this.SuspendLayout();

         const int MARGIN = 5;

         int width = (int)(this.Width / 3 - MARGIN * 1.5);

         prefWhenPositive.Width = width;
         prefWhenZero.Width = width;
         prefWhenNegative.Width = width;

         prefWhenZero.Left = prefWhenPositive.Left + width + MARGIN;
         prefWhenNegative.Left = prefWhenZero.Left + width + MARGIN;

         lblWhenZero.Left = prefWhenZero.Left;
         lblWhenNegative.Left = prefWhenNegative.Left;

         this.ResumeLayout();
      }
   }
}
