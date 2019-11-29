using NeuralNetwork.Visualizer.Preferences.Brushes;
using NeuralNetworkMaker.Preferences.Dialogs;
using NeuralNetworkMaker.Preferences.Exts;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NeuralNetworkMaker.Preferences.Controls
{
   public partial class BrushPreferenceControl : UserControl
   {
      public event EventHandler BrushChanged;

      public BrushPreferenceControl()
      {
         InitializeComponent();
      }

      private IBrush _brush;
      public IBrush Brush
      {
         get => _brush;
         set
         {
            _brush = value;
            UpdatePreview();
         }
      }

      private void BrushPreference_Load(object sender, EventArgs e)
      {
         UpdatePreview();
      }

      private void UpdatePreview()
      {
         panBrush.Refresh();
      }

      private void btnEdit_Click(object sender, EventArgs e)
      {
         using (var dlg = new frmBrushPreference())
         {
            dlg.Brush = this.Brush;

            if (dlg.ShowDialog(this) == DialogResult.Cancel)
               return;

            this.Brush = dlg.Brush;
         }

         UpdatePreview();
         BrushChanged?.Invoke(this, EventArgs.Empty);
      }

      private void panBrush_Paint(object sender, PaintEventArgs e)
      {
         var brushPreference = this.Brush;
         var graph = e.Graphics;

         using (var brush = brushPreference?.CreateBrush(panBrush.ClientRectangle) ?? new SolidBrush(Color.Transparent))
         {
            if (brush is SolidBrush solidBrush && (solidBrush.Color == Color.Transparent || solidBrush.Color.A == 0))
            {
               graph.DrawTransparentRectangle(panBrush.ClientRectangle.Size);
            }
            else
            {
               graph.FillRectangle(brush, panBrush.ClientRectangle);
            }
         }
      }
   }
}
