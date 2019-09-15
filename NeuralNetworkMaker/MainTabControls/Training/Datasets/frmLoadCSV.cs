using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NeuralNetworkMaker.MainTabControls.Training.Datasets
{
   public partial class frmLoadCSV : Form
   {
      public frmLoadCSV()
      {
         InitializeComponent();
      }

      public DataTable<string> RawData { get; private set; }

      private void btnFile_Click(object sender, EventArgs e)
      {
         SelectFile();
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         CloseForm(DialogResult.Cancel);
      }

      private void btnOk_Click(object sender, EventArgs e)
      {
         if (!LoadCsv())
            return;

         CloseForm(DialogResult.OK);
      }

      private void txtFile_TextChanged(object sender, EventArgs e)
      {
         EnableControls();
      }

      private void SelectFile()
      {
         using (var dialog = new OpenFileDialog()
         {
            AddExtension = true,
            AutoUpgradeEnabled = true,
            CheckFileExists = true,
            CheckPathExists = true,
            DefaultExt = "csv files (*.csv)|*.csv",
            Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*",
            Multiselect = false,
            Title = "Select CSV File"
         })
         {
            if (dialog.ShowDialog(this) == DialogResult.Cancel)
               return;

            txtFile.Text = dialog.FileName;
         }

         EnableControls();
      }

      private bool LoadCsv()
      {
         var linesValues = LoadCsvFile(txtFile.Text);

         if (linesValues.Count() == 0)
            return false;

         var headersAndValues = GetHeaders(linesValues);
         linesValues = headersAndValues.LinesValues;

         ValidateLinesValues(headersAndValues.Headers, linesValues);

         this.RawData = new DataTable<string>(headersAndValues.Headers, linesValues);
         return true;
      }

      private void ValidateLinesValues(IEnumerable<string> headers, IEnumerable<string[]> linesValues)
      {
         foreach (var lineValues in linesValues)
         {
            if (lineValues.Length != headers.Count())
            {
               throw new InvalidOperationException("The number of columns must be the same in all rows");
            }
         }
      }

      private (IEnumerable<string> Headers, IEnumerable<string[]> LinesValues) GetHeaders(IEnumerable<string[]> linesValues)
      {
         var firstLine = linesValues.First();

         IEnumerable<string> headers;

         if (chFirstRowHeader.Checked)
         {
            headers = firstLine;
            linesValues = linesValues.Skip(1);
         }
         else
         {
            headers = firstLine.Select((l, i) => $"Col_{i}");
         }

         return (headers, linesValues);
      }

      private void EnableControls()
      {
         chFirstRowHeader.Enabled = btnOk.Enabled = !string.IsNullOrWhiteSpace(txtFile.Text);
      }

      private IEnumerable<string[]> LoadCsvFile(string filePath)
      {
         try
         {
            return File.ReadLines(filePath)
               .Where(l => !string.IsNullOrWhiteSpace(l.Trim()))
               .Select(l => l.Split(','));
         }
         catch (Exception e)
         {
            MessageBox.Show($"Error to open the '{filePath}' file: {e.Message}", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return new string[][] { };
         }
      }

      private void CloseForm(DialogResult result)
      {
         this.DialogResult = result;
         this.Close();
      }
   }
}
