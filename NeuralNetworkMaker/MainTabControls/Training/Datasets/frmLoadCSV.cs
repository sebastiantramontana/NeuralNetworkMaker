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

      private void btnFile_Click(object sender, EventArgs e)
      {
         SelectFile();
      }

      private void btnLoad_Click(object sender, EventArgs e)
      {
         LoadCsv();
      }

      private void chFirstRowHeader_CheckedChanged(object sender, EventArgs e)
      {

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
      }

      private void LoadCsv()
      {
         var linesValues = LoadCsvFile(txtFile.Text);

         //gridCSV.SuspendLayout();

         foreach (var lineValues in linesValues)
         {
            //MatchColumnsGrid(lineValues.Length);
            //AddRowToGrid(lineValues);
         }

         //gridCSV.ResumeLayout(true);

         EnableControls();
      }

      private void EnableControls()
      {
         chFirstRowHeader.Enabled = btnOk.Enabled = true;
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
   }
}
