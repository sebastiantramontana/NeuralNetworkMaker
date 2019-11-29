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

      public decimal Value
      {
         get => this.NumericUpDownControl.Value;
         set => this.NumericUpDownControl.Value = value;
      }

      public decimal Maximum
      {
         get => this.NumericUpDownControl.Maximum;
         set => this.NumericUpDownControl.Maximum = value;
      }

      protected override void OnSubscribeControlEvents(Control c)
      {
         if (c is null)
            throw new ArgumentNullException(nameof(c));

         base.OnSubscribeControlEvents(c);

         var control = c as NumericUpDown;

         if (control is null)
            throw new InvalidCastException("c is not a NumericUpDown");

         control.ValueChanged += new EventHandler(OnValueChanged);
      }

      protected override void OnUnsubscribeControlEvents(Control c)
      {
         if (c is null)
            throw new ArgumentNullException(nameof(c));

         base.OnUnsubscribeControlEvents(c);

         var control = c as NumericUpDown;

         if (control is null)
            throw new InvalidCastException("c is not a NumericUpDown");

         control.ValueChanged -= new EventHandler(OnValueChanged);
      }

      private void OnValueChanged(object sender, EventArgs e)
      {
         ValueChanged?.Invoke(this, e);
      }
   }
}
