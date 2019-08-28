namespace NeuralNetworkMaker.MainTabControls.Training.Datasets
{
   partial class frmLoadCSV
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.label1 = new System.Windows.Forms.Label();
         this.txtFile = new System.Windows.Forms.TextBox();
         this.btnFile = new System.Windows.Forms.Button();
         this.chFirstRowHeader = new System.Windows.Forms.CheckBox();
         this.btnCancel = new System.Windows.Forms.Button();
         this.btnOk = new System.Windows.Forms.Button();
         this.btnLoad = new System.Windows.Forms.Button();
         this.datasetGrid1 = new NeuralNetworkMaker.MainTabControls.Training.Datasets.DatasetGrid();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(77, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Select CSV file";
         // 
         // txtFile
         // 
         this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtFile.Location = new System.Drawing.Point(12, 29);
         this.txtFile.Name = "txtFile";
         this.txtFile.Size = new System.Drawing.Size(1159, 20);
         this.txtFile.TabIndex = 1;
         // 
         // btnFile
         // 
         this.btnFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnFile.AutoSize = true;
         this.btnFile.Location = new System.Drawing.Point(1177, 27);
         this.btnFile.Name = "btnFile";
         this.btnFile.Size = new System.Drawing.Size(32, 27);
         this.btnFile.TabIndex = 2;
         this.btnFile.Text = "...";
         this.btnFile.UseVisualStyleBackColor = true;
         this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
         // 
         // chFirstRowHeader
         // 
         this.chFirstRowHeader.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.chFirstRowHeader.AutoSize = true;
         this.chFirstRowHeader.Enabled = false;
         this.chFirstRowHeader.Location = new System.Drawing.Point(12, 55);
         this.chFirstRowHeader.Name = "chFirstRowHeader";
         this.chFirstRowHeader.Size = new System.Drawing.Size(129, 17);
         this.chFirstRowHeader.TabIndex = 3;
         this.chFirstRowHeader.Text = "First row is the header";
         this.chFirstRowHeader.UseVisualStyleBackColor = true;
         this.chFirstRowHeader.CheckedChanged += new System.EventHandler(this.chFirstRowHeader_CheckedChanged);
         // 
         // btnCancel
         // 
         this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.btnCancel.AutoSize = true;
         this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancel.Location = new System.Drawing.Point(1215, 698);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 27);
         this.btnCancel.TabIndex = 9;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         // 
         // btnOk
         // 
         this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.btnOk.AutoSize = true;
         this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.btnOk.Enabled = false;
         this.btnOk.Location = new System.Drawing.Point(1134, 698);
         this.btnOk.Name = "btnOk";
         this.btnOk.Size = new System.Drawing.Size(75, 27);
         this.btnOk.TabIndex = 10;
         this.btnOk.Text = "OK";
         this.btnOk.UseVisualStyleBackColor = true;
         // 
         // btnLoad
         // 
         this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnLoad.AutoSize = true;
         this.btnLoad.Location = new System.Drawing.Point(1215, 29);
         this.btnLoad.Name = "btnLoad";
         this.btnLoad.Size = new System.Drawing.Size(75, 27);
         this.btnLoad.TabIndex = 11;
         this.btnLoad.Text = "Load";
         this.btnLoad.UseVisualStyleBackColor = true;
         this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
         // 
         // datasetGrid1
         // 
         this.datasetGrid1.Location = new System.Drawing.Point(12, 78);
         this.datasetGrid1.Name = "datasetGrid1";
         this.datasetGrid1.Size = new System.Drawing.Size(1278, 602);
         this.datasetGrid1.TabIndex = 12;
         // 
         // frmLoadCSV
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
         this.ClientSize = new System.Drawing.Size(1302, 737);
         this.Controls.Add(this.datasetGrid1);
         this.Controls.Add(this.btnLoad);
         this.Controls.Add(this.btnOk);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.chFirstRowHeader);
         this.Controls.Add(this.btnFile);
         this.Controls.Add(this.txtFile);
         this.Controls.Add(this.label1);
         this.MaximizeBox = false;
         this.Name = "frmLoadCSV";
         this.Text = "Load CSV";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtFile;
      private System.Windows.Forms.Button btnFile;
      private System.Windows.Forms.CheckBox chFirstRowHeader;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.Button btnOk;
      private System.Windows.Forms.Button btnLoad;
      private DatasetGrid datasetGrid1;
   }
}