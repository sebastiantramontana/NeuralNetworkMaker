using NeuralNetworkMaker.Preferences.Extensions;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;

namespace NeuralNetworkMaker.Preferences.Controls
{
   public partial class PenControl : UserControl
   {
      public event EventHandler PenChanged;

      public PenControl()
      {
         InitializeComponent();
      }

      private Pen _pen;
      public Pen Pen
      {
         get => _pen;
         set
         {
            _pen = value;
            SetControls();
         }
      }

      private bool _isInitialized = false;
      private void PenControl_Load(object sender, EventArgs e)
      {
         LoadCombos();
         SetControls();

         _isInitialized = true;
      }

      private void LoadCombos()
      {
         var excepCaps = new[] { LineCap.Custom };

         cboStartCap.Load(excepCaps);
         cboEndCap.Load(excepCaps);
         cboDashCap.Load<DashCap>();
         cboDashStyle.Load<DashStyle>(new[] { DashStyle.Custom });
      }

      private void SetControls()
      {
         if (_pen == null)
         {
            _pen = new Pen(Color.Transparent);
         }

         colPenColor.SelectedColor = _pen.Color;
         spinLineWidth.Value = Convert.ToDecimal(_pen.Width);
         spinDashOffset.Value = Convert.ToDecimal(_pen.DashOffset);
         cboStartCap.SelectedItem = _pen.StartCap;
         cboEndCap.SelectedItem = _pen.StartCap;
         cboDashCap.SelectedItem = _pen.DashCap;
         cboDashStyle.SelectedItem = _pen.DashStyle;

         UpdatePreview();
      }

      private void UpdatePreview()
      {
         this.Refresh();
      }

      private void cboStartCap_DrawItem(object sender, DrawItemEventArgs e)
      {
         DrawLineCap(e, pen => pen.StartCap, sender as ComboBox, pen => pen.EndCap = LineCap.Flat);
      }

      private void cboEndCap_DrawItem(object sender, DrawItemEventArgs e)
      {
         DrawLineCap(e, pen => pen.EndCap, sender as ComboBox, pen => pen.StartCap = LineCap.Flat);
      }

      private void cboDashCap_DrawItem(object sender, DrawItemEventArgs e)
      {
         DrawEnumItem(e, pen => pen.DashCap, cboDashCap, pen => pen.DashStyle = DashStyle.DashDot);
      }

      private void cboDashStyle_DrawItem(object sender, DrawItemEventArgs e)
      {
         DrawEnumItem(e, pen => pen.DashStyle, cboDashStyle);
      }

      private void DrawLineCap(DrawItemEventArgs e, Expression<Func<Pen, LineCap>> propertyExp, ComboBox cbo, Action<Pen> excludeOtherAction)
      {
         DrawEnumItem(e, propertyExp, cbo, excludeOtherAction);
      }

      private void DrawEnumItem<TEnum>(DrawItemEventArgs e, Expression<Func<Pen, TEnum>> propertyExp, ComboBox comboBox, Action<Pen> configurePenAction = null) where TEnum : Enum
      {
         if (e.Index < 0)
            return;

         var item = comboBox.Items[e.Index];

         e.DrawBackground();
         e.DrawFocusRectangle();

         e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

         using (var pen = _pen.Clone() as Pen)
         {
            var prop = (propertyExp.Body as MemberExpression).Member as PropertyInfo;
            prop.SetValue(pen, item);

            configurePenAction?.Invoke(pen);

            var y = e.Bounds.Y + e.Bounds.Height / 2;

            e.Graphics.DrawLine(pen, new Point(e.Bounds.Left + 8, y), new Point(e.Bounds.Width - 10, y));
         }
      }

      private void colPenColor_ColorChanged(object sender, EventArgs e)
      {
         ModifyPen(() => _pen.Color = colPenColor.SelectedColor);
      }

      private void spinLineWidth_ValueChanged(object sender, EventArgs e)
      {
         ModifyPen(() => _pen.Width = (float)spinLineWidth.Value);
      }

      private void spinDashOffset_ValueChanged(object sender, EventArgs e)
      {
         ModifyPen(() => _pen.DashOffset = (float)spinDashOffset.Value);
      }

      private void cboDashStyle_SelectedIndexChanged(object sender, EventArgs e)
      {
         ModifyPen(() => _pen.DashStyle = (DashStyle)cboDashStyle.SelectedItem);
      }

      private void cboDashCap_SelectedIndexChanged(object sender, EventArgs e)
      {
         ModifyPen(() => _pen.DashCap = (DashCap)cboDashCap.SelectedItem);
      }

      private void cboStartCap_SelectedIndexChanged(object sender, EventArgs e)
      {
         ModifyPen(() => _pen.StartCap = (LineCap)cboStartCap.SelectedItem);
      }

      private void cboEndCap_SelectedIndexChanged(object sender, EventArgs e)
      {
         ModifyPen(() => _pen.EndCap = (LineCap)cboEndCap.SelectedItem);
      }

      private void ModifyPen(Action modifyAction)
      {
         if(!_isInitialized)
         {
            return;
         }

         modifyAction();
         UpdatePreview();

         this.PenChanged?.Invoke(this, EventArgs.Empty);
      }

      private void panPreview_Paint(object sender, PaintEventArgs e)
      {
         var y = (panPreview.Height - _pen.Width) / 2;
         e.Graphics.DrawLine(_pen, 10, y, panPreview.Width - 20, y);
      }
   }
}
