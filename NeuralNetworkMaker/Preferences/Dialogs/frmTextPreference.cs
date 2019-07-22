using NeuralNetwork.Visualizer.Preferences.Text;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NeuralNetworkMaker.Preferences.Dialogs
{
   public partial class frmTextPreference : Form
   {
      public frmTextPreference()
      {
         InitializeComponent();
      }

      public TextPreference TextPreference { get; set; }
      public string PreviewText { get; set; }

      private void frmTextPreference_Load(object sender, EventArgs e)
      {
         SetControls();
      }

      private void SetControls()
      {
         FillFontFamilies();
         SetFontStyle();

         brhPreference.Brush = this.TextPreference?.Brush;
         UpdatePreview();
      }

      private void SetFontStyle()
      {
         CheckFontStyle(chBold, FontStyle.Bold);
         CheckFontStyle(chItalic, FontStyle.Italic);
         CheckFontStyle(chUnderline, FontStyle.Underline);
         CheckFontStyle(chStrikeout, FontStyle.Strikeout);
      }

      private void CheckFontStyle(CheckBox chControl, FontStyle style)
      {
         chControl.Checked = this.TextPreference?.FontStyle.HasFlag(style) ?? false;
         chControl.Tag = style;
      }

      private void FillFontFamilies()
      {
         cboFontFamily.Items.AddRange(FontFamily.Families.Select(f => f.Name).ToArray());
         cboFontFamily.SelectedItem = this.TextPreference?.FontFamily ?? "Tahoma";
      }

      private void cboFontFamily_SelectedIndexChanged(object sender, EventArgs e)
      {
         UpdatePreview();
      }

      private void chBold_CheckedChanged(object sender, EventArgs e)
      {
         UpdatePreview();
      }

      private void chItalic_CheckedChanged(object sender, EventArgs e)
      {
         UpdatePreview();
      }

      private void chUnderline_CheckedChanged(object sender, EventArgs e)
      {
         UpdatePreview();
      }

      private void chStrikeout_CheckedChanged(object sender, EventArgs e)
      {
         UpdatePreview();
      }

      private void btnOk_Click(object sender, EventArgs e)
      {
         this.TextPreference = new TextPreference
         {
            Brush = brhPreference.Brush,
            FontFamily = cboFontFamily.SelectedItem as string,
            FontStyle = GetFontStyle()
         };
      }

      private void lblPreview_Paint(object sender, PaintEventArgs e)
      {
         var graph = e.Graphics;
         graph.Clear(lblPreview.BackColor);
         graph.DrawString(this.PreviewText, CreateFont(), brhPreference.Brush?.CreateBrush(e.ClipRectangle) ?? new SolidBrush(Color.Transparent), new Point(2, 2));
      }

      private void brhPreference_BrushChanged(object sender, EventArgs e)
      {
         UpdatePreview();
      }

      private void UpdatePreview()
      {
         lblPreview.Text = PreviewText;
         lblPreview.Refresh();
      }

      private Font CreateFont()
      {
         var fontStyle = GetFontStyle();
         return new Font(cboFontFamily.SelectedItem as string, 20f, fontStyle) { };
      }

      private FontStyle GetFontStyle()
      {
         FontStyle fontStyle = FontStyle.Regular;

         var checkArray = new[] { chBold, chItalic, chUnderline, chStrikeout };

         foreach (var chControl in checkArray)
            fontStyle |= (chControl.Checked ? (FontStyle)chControl.Tag : FontStyle.Regular);

         return fontStyle;
      }
   }
}
