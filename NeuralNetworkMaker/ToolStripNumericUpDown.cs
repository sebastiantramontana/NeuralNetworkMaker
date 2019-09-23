using System;
using System.Windows.Forms;

namespace NeuralNetworkMaker
{
   public class ToolStripNumericUpDown : ToolStripControlHost
   {
      public event EventHandler ValueChanged;

      public ToolStripNumericUpDown() : base(new NumericUpDown())
      {
      }

      public NumericUpDown NumericUpDownControl => this.Control as NumericUpDown;

      protected override void OnSubscribeControlEvents(Control c)
      {
         base.OnSubscribeControlEvents(c);

         var control = c as NumericUpDown;
         control.ValueChanged += new EventHandler(OnValueChanged);
      }

      protected override void OnUnsubscribeControlEvents(Control c)
      {
         base.OnUnsubscribeControlEvents(c);

         var control = c as NumericUpDown;
         control.ValueChanged -= new EventHandler(OnValueChanged);
      }

      private void OnValueChanged(object sender, EventArgs e)
      {
         ValueChanged?.Invoke(this, e);
      }
   }
}
