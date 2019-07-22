using NeuralNetworkMaker.Preferences.Extensions;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NeuralNetworkMaker.Preferences.Controls
{
   public partial class ColorControl : UserControl
   {
      public event EventHandler ColorChanged;

      public ColorControl()
      {
         InitializeComponent();
      }

      private Color _selectedColor = Color.Transparent;
      public Color SelectedColor
      {
         get => _selectedColor;
         set
         {
            _selectedColor = value;
            UpdatePreview();
         }
      }

      private void ColorControl_Load(object sender, EventArgs e)
      {
         UpdatePreview();
      }

      private void btnEditColor_Click(object sender, EventArgs e)
      {
         EditColor();
      }

      private void btnTransparent_Click(object sender, EventArgs e)
      {
         ChangeColor(Color.Transparent);
      }

      private void panColor_Paint(object sender, PaintEventArgs e)
      {
         DrawPreviewPanelColor(e.Graphics);
      }

      private void ChangeColor(Color color)
      {
         this.SelectedColor = color;
         ColorChanged?.Invoke(this, EventArgs.Empty);
      }

      private void EditColor()
      {
         var color = OpenColorDialog();

         if (color.IsEmpty)
            return;

         ChangeColor(color);
      }

      private Color OpenColorDialog()
      {
         var color = Color.FromArgb(255, this.SelectedColor);

         using (var dlg = new ColorDialog()
         {
            AllowFullOpen = true,
            AnyColor = true,
            Color = color,
            FullOpen = true,
            SolidColorOnly = true
         })
         {
            return (dlg.ShowDialog(this) == DialogResult.Cancel) ? Color.Empty : dlg.Color;
         }
      }

      private void UpdatePreview()
      {
         panColor.Refresh();
      }

      private void DrawPreviewPanelColor(Graphics graph)
      {
         var selectedColor = this.SelectedColor;

         if (selectedColor == Color.Transparent || selectedColor.IsEmpty || selectedColor.A == 0)
         {
            graph.DrawTransparentRectangle(panColor.ClientRectangle.Size);
         }
         else
         {
            graph.FillRectangle(new SolidBrush(selectedColor), panColor.ClientRectangle);
         }
      }

      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }
   }
}
