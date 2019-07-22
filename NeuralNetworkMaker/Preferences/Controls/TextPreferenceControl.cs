using NeuralNetwork.Visualizer.Preferences.Text;
using NeuralNetworkMaker.Preferences.Dialogs;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NeuralNetworkMaker.Preferences.Controls
{
   public partial class TextPreferenceControl : UserControl
   {
      public event EventHandler TextPreferenceChanged;

      public TextPreferenceControl()
      {
         InitializeComponent();
      }

      [Browsable(false)]
      public string PreviewText { get; set; } = "Lorem ipsum";

      [Browsable(false)]
      public TextPreference TextPreference { get; set; } = new TextPreference();

      private void TextPreferenceControl_Resize(object sender, EventArgs e)
      {
         if (!_isInitialized)
         {
            return;
         }

         AlignControls();
      }

      private bool _isInitialized = false;
      private void TextPreferenceControl_Load(object sender, EventArgs e)
      {
         AlignControls();
         UpdatePreview();

         _isInitialized = true;
      }

      private void btnEdit_Click(object sender, EventArgs e)
      {
         using (frmTextPreference frm = new frmTextPreference())
         {
            frm.TextPreference = this.TextPreference;
            frm.PreviewText = this.PreviewText;

            if (frm.ShowDialog(this) == DialogResult.Cancel)
               return;

            this.TextPreference = frm.TextPreference;
         }

         UpdatePreview();
         TextPreferenceChanged?.Invoke(this, EventArgs.Empty);
      }

      private void lblPreview_Paint(object sender, PaintEventArgs e)
      {
         var graph = e.Graphics;
         graph.Clear(Color.FromKnownColor(KnownColor.Control));

         if (this.TextPreference == null)
            return;

         using (var font = CreateFont())
         {
            graph.DrawString(this.PreviewText, font, this.TextPreference?.Brush.CreateBrush(e.ClipRectangle) ?? Brushes.Transparent, new Point(5, 0));
         }
      }

      private void UpdatePreview()
      {
         lblPreview.Text = this.PreviewText;
         lblPreview.Refresh();
      }

      private Font CreateFont()
      {
         return new Font(this.TextPreference?.FontFamily ?? "Tahoma", 10f, this.TextPreference?.FontStyle ?? FontStyle.Regular);
      }

      private void AlignControls()
      {
         this.SuspendLayout();
         btnEdit.Location = new Point(btnEdit.Location.X, (this.Size.Height - btnEdit.Size.Height) / 2);
         this.ResumeLayout();
      }
   }
}
