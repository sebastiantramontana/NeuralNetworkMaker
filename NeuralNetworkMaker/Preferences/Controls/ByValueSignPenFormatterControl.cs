using NeuralNetwork.Visualizer.Preferences.Formatting;
using NeuralNetworkMaker.Preferences.Exts;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NeuralNetworkMaker.Preferences.Controls
{
   public partial class ByValueSignPenFormatterControl : UserControl
   {
      public event EventHandler PenFormatterChanged;

      public ByValueSignPenFormatterControl()
      {
         InitializeComponent();

         Pen penDefault() => new Pen(Color.Black);
         _byValueSignPenFormatter = new ByValueSignFormatter<Pen>(penDefault, penDefault, penDefault, penDefault);
      }

      private ByValueSignFormatter<Pen> _byValueSignPenFormatter;
      public ByValueSignFormatter<Pen> ByValueSignPenFormatter
      {
         get => _byValueSignPenFormatter;
         set
         {
            _byValueSignPenFormatter = value;
            SetPenWhenCase();
         }
      }

      private bool _isInitialized = false;
      private void ByValueSignPenFormatterControl_Load(object sender, EventArgs e)
      {
         Initialize();
         _isInitialized = true;
      }

      private void cboWhenCases_SelectedIndexChanged(object sender, EventArgs e)
      {
         SetPenWhenCase();
      }

      private void penWhenCase_PenChanged(object sender, EventArgs e)
      {
         SetByValueSignPenFormatter();
      }

      private void Initialize()
      {
         cboWhenCases.Load(new[] { ByValueSignCase.Undefined });
         cboWhenCases.SelectedItem = ByValueSignCase.WhenPositive;

         penWhenCase.Pen = _byValueSignPenFormatter.WhenPositive();
      }

      private void SetPenWhenCase()
      {
         if (!_isInitialized)
            return;

         var byValueSignCases = (ByValueSignCase)cboWhenCases.SelectedItem;
         Pen pen;

         switch (byValueSignCases)
         {
            case ByValueSignCase.Undefined:
               throw new InvalidOperationException($"Internal Error: Selected Item is {ByValueSignCase.Undefined}");
            case ByValueSignCase.WhenPositive:
               pen = _byValueSignPenFormatter.WhenPositive();
               break;
            case ByValueSignCase.WhenZero:
               pen = _byValueSignPenFormatter.WhenZero();
               break;
            case ByValueSignCase.WhenNegative:
               pen = _byValueSignPenFormatter.WhenNegative();
               break;
            case ByValueSignCase.WhenNull:
               pen = _byValueSignPenFormatter.WhenNull();
               break;
            default:
               throw new NotImplementedException($"Internal Error: Case {byValueSignCases} not implemented yet");
         }

         penWhenCase.Pen = pen.Clone() as Pen;

         pen.Dispose();
      }

      private void SetByValueSignPenFormatter()
      {
         if (!_isInitialized)
         {
            return;
         }

         var whenCase = (ByValueSignCase)cboWhenCases.SelectedItem;

         var whenPositive = _byValueSignPenFormatter.WhenPositive();
         var whenZero = _byValueSignPenFormatter.WhenZero();
         var whenNegative = _byValueSignPenFormatter.WhenNegative();
         var whenNull = _byValueSignPenFormatter.WhenNull();

         switch (whenCase)
         {
            case ByValueSignCase.Undefined:
               throw new InvalidOperationException($"Internal Error: Selected Item is {ByValueSignCase.Undefined}");
            case ByValueSignCase.WhenPositive:
               whenPositive = penWhenCase.Pen;
               break;
            case ByValueSignCase.WhenZero:
               whenZero = penWhenCase.Pen;
               break;
            case ByValueSignCase.WhenNegative:
               whenNegative = penWhenCase.Pen;
               break;
            case ByValueSignCase.WhenNull:
               whenNull = penWhenCase.Pen;
               break;
            default:
               throw new NotImplementedException($"Internal Error: Case {whenCase} not implemented yet");
         }

         _byValueSignPenFormatter = new ByValueSignFormatter<Pen>(() => whenNegative.Clone() as Pen, () => whenZero.Clone() as Pen, () => whenPositive.Clone() as Pen, () => whenNull.Clone() as Pen);
         PenFormatterChanged?.Invoke(this, EventArgs.Empty);
      }
   }
}
