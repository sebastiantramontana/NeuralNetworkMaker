using NeuralNetwork.Visualizer.Preferences.Brushes;
using NeuralNetworkMaker.Preferences.Extensions;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NeuralNetworkMaker.Preferences.Dialogs
{
   public partial class frmBrushPreference : Form
   {
      private Color _selectedColor1 = Color.Transparent;
      private Color _selectedColor2 = Color.Transparent;

      public frmBrushPreference()
      {
         InitializeComponent();
      }

      public IBrush Brush { get; set; }

      private void frmBrushPreference_Load(object sender, EventArgs e)
      {
         LoadControls();
         UpdatePreview();
      }

      private void Color1_ColorChanged(object sender, EventArgs e)
      {
         _selectedColor1 = Color1.SelectedColor;
         UpdatePreview();
      }

      private void Color2_ColorChanged(object sender, EventArgs e)
      {
         _selectedColor2 = Color2.SelectedColor;
         UpdatePreview();
      }

      private void panPreview_Paint(object sender, PaintEventArgs e)
      {
         var graph = e.Graphics;
         var brushPreference = GetSelectedBrushPreference();

         using (var brush = brushPreference?.CreateBrush(panPreview.ClientRectangle) ?? new SolidBrush(Color.Transparent))
         {
            if (brush is SolidBrush solidBrush && solidBrush.Color == Color.Transparent)
            {
               graph.DrawTransparentRectangle(panPreview.ClientRectangle.Size);
            }
            else
            {
               graph.FillRectangle(brush, panPreview.ClientRectangle);
            }
         }
      }

      private void radGradient_CheckedChanged(object sender, EventArgs e)
      {
         Color2.Enabled = spinAngle.Enabled = radGradient.Checked;
         UpdatePreview();
      }

      private void spinAngle_ValueChanged(object sender, EventArgs e)
      {
         UpdatePreview();
      }

      private void btnOk_Click(object sender, EventArgs e)
      {
         this.Brush = GetSelectedBrushPreference();
      }

      private IBrush GetSelectedBrushPreference()
      {
         IBrush brush;

         if (radSolid.Checked)
         {
            brush = new SolidBrushPreference(_selectedColor1);
         }
         else
         {
            var gradientBrush = new GradientBrushPreference(_selectedColor1, _selectedColor2, (int)spinAngle.Value);
            brush = gradientBrush;
         }

         return brush;
      }

      private void UpdatePreview()
      {
         panPreview.Refresh();
      }

      private void LoadControls()
      {
         if (this.Brush == null)
            return;

         if (this.Brush is GradientBrushPreference gradientBrush)
         {
            radGradient.Checked = true;
            _selectedColor1 = gradientBrush.Color1;
            _selectedColor2 = gradientBrush.Color2;
            spinAngle.Value = gradientBrush.Angle;
         }
         else
         {
            var solidBrush = this.Brush as SolidBrushPreference;

            radSolid.Checked = true;
            _selectedColor1 = solidBrush.Color;
            _selectedColor2 = Color.Transparent;
            spinAngle.Value = 0m;
         }

         Color1.SelectedColor = _selectedColor1;
         Color2.SelectedColor = _selectedColor2;
      }
   }
}
