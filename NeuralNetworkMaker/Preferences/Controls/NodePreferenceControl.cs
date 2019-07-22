using NeuralNetwork.Visualizer.Preferences;
using NeuralNetwork.Visualizer.Preferences.Formatting;
using NeuralNetwork.Visualizer.Preferences.Pens;
using NeuralNetwork.Visualizer.Preferences.Text;
using System;
using System.Windows.Forms;

namespace NeuralNetworkMaker.Preferences.Controls
{
   public partial class NodePreferenceControl : UserControl
   {
      public event EventHandler NodePreferenceChanged;

      public NodePreferenceControl()
      {
         InitializeComponent();
      }

      public NodePreference NodePreference { get; set; } = new NodePreference();

      private void NodePreferenceControl_Load(object sender, EventArgs e)
      {
         Initialize();
      }

      private bool _isInitialized = false;
      private void Initialize()
      {
         if (this.NodePreference == null)
            this.NodePreference = new NodePreference();

         brushBackground.Brush = this.NodePreference.Background;
         brushBackgroundSelected.Brush = this.NodePreference.BackgroundSelected;
         spinRoundingDigits.Value = this.NodePreference.RoundingDigits;

         InitializeOutputValueFormatter();

         penBorder.Pen = this.NodePreference.Border.CreatePen();
         penBorderSelected.Pen = this.NodePreference.BorderSelected.CreatePen();

         _isInitialized = true;
      }

      private void InitializeOutputValueFormatter()
      {
         if (this.NodePreference.OutputValueFormatter is BasicFormatter<TextPreference> basicFormatter)
         {
            var whenPositive = basicFormatter.FormaterFunc();
            var whenZero = basicFormatter.FormaterFunc();
            var whenNegative = basicFormatter.FormaterFunc();

            this.NodePreference.OutputValueFormatter = new ByValueSignFormatter<TextPreference>(() => whenNegative, () => whenZero, () => whenPositive, () => TextPreference.Null);
         }

         formatterOutputValue.ByValueSignTextFormatter = this.NodePreference.OutputValueFormatter as ByValueSignFormatter<TextPreference>;
      }

      private void spinRoundingDigits_ValueChanged(object sender, EventArgs e)
      {
         ModifyNodePreference(() => this.NodePreference.RoundingDigits = (byte)spinRoundingDigits.Value);
      }

      private void brushBackground_BrushChanged(object sender, EventArgs e)
      {
         ModifyNodePreference(() => this.NodePreference.Background = brushBackground.Brush);
      }

      private void brushBackgroundSelected_BrushChanged(object sender, EventArgs e)
      {
         ModifyNodePreference(() => this.NodePreference.BackgroundSelected = brushBackgroundSelected.Brush);
      }

      private void penBorder_PenChanged(object sender, EventArgs e)
      {
         ModifyNodePreference(() => this.NodePreference.Border = new SimplePen(penBorder.Pen));
      }

      private void penBorderSelected_PenChanged(object sender, EventArgs e)
      {
         ModifyNodePreference(() => this.NodePreference.BorderSelected = new SimplePen(penBorderSelected.Pen));
      }

      private void formatterOutputValue_TextFormatterChanged(object sender, EventArgs e)
      {
         ModifyNodePreference(() => this.NodePreference.OutputValueFormatter = formatterOutputValue.ByValueSignTextFormatter);
      }

      private void ModifyNodePreference(Action setPropAction)
      {
         if (!_isInitialized)
         {
            return;
         }

         if (this.NodePreference == null)
         {
            this.NodePreference = new NodePreference();
         }

         setPropAction();
         NodePreferenceChanged?.Invoke(this, EventArgs.Empty);
      }

      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      private void formatterOutputValue_TextFormatterChanged_1(object sender, EventArgs e)
      {

      }
   }
}
