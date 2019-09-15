namespace NeuralNetworkMaker.MainTabControls.Training
{
   partial class TrainingControl
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.groupBox4 = new System.Windows.Forms.GroupBox();
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.pinSettingsDropout = new System.Windows.Forms.NumericUpDown();
         this.label1 = new System.Windows.Forms.Label();
         this.cboSettingsCostFunction = new System.Windows.Forms.ComboBox();
         this.label2 = new System.Windows.Forms.Label();
         this.pinSettingsIterations = new System.Windows.Forms.NumericUpDown();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.cboSettingsAlgorithm = new System.Windows.Forms.ComboBox();
         this.propSettingsAlgorithmParams = new System.Windows.Forms.PropertyGrid();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
         this.cboInitializationWeights = new System.Windows.Forms.ComboBox();
         this.cboInitializationBiases = new System.Windows.Forms.ComboBox();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.btnTrain = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.txtLogs = new System.Windows.Forms.TextBox();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.btnDatasetLoad = new NeuralNetworkMaker.DropDownButton();
         this.lblDatasetStatus = new System.Windows.Forms.Label();
         this.btnDatasetView = new System.Windows.Forms.Button();
         this.groupBox4.SuspendLayout();
         this.tableLayoutPanel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pinSettingsDropout)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pinSettingsIterations)).BeginInit();
         this.groupBox1.SuspendLayout();
         this.tableLayoutPanel2.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.SuspendLayout();
         // 
         // groupBox4
         // 
         this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
         this.groupBox4.Controls.Add(this.tableLayoutPanel1);
         this.groupBox4.Location = new System.Drawing.Point(0, 155);
         this.groupBox4.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
         this.groupBox4.Name = "groupBox4";
         this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
         this.groupBox4.Size = new System.Drawing.Size(548, 187);
         this.groupBox4.TabIndex = 3;
         this.groupBox4.TabStop = false;
         this.groupBox4.Text = "Settings";
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.ColumnCount = 2;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.Controls.Add(this.pinSettingsDropout, 0, 5);
         this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.cboSettingsCostFunction, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
         this.tableLayoutPanel1.Controls.Add(this.pinSettingsIterations, 0, 3);
         this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
         this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
         this.tableLayoutPanel1.Controls.Add(this.cboSettingsAlgorithm, 1, 1);
         this.tableLayoutPanel1.Controls.Add(this.propSettingsAlgorithmParams, 1, 2);
         this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 19);
         this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 6;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel1.Size = new System.Drawing.Size(540, 164);
         this.tableLayoutPanel1.TabIndex = 11;
         // 
         // pinSettingsDropout
         // 
         this.pinSettingsDropout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.pinSettingsDropout.DecimalPlaces = 3;
         this.pinSettingsDropout.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
         this.pinSettingsDropout.Location = new System.Drawing.Point(4, 117);
         this.pinSettingsDropout.Margin = new System.Windows.Forms.Padding(4);
         this.pinSettingsDropout.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            196608});
         this.pinSettingsDropout.Name = "pinSettingsDropout";
         this.pinSettingsDropout.Size = new System.Drawing.Size(262, 22);
         this.pinSettingsDropout.TabIndex = 11;
         this.pinSettingsDropout.Value = new decimal(new int[] {
            999,
            0,
            0,
            196608});
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label1.Location = new System.Drawing.Point(0, 0);
         this.label1.Margin = new System.Windows.Forms.Padding(0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(270, 17);
         this.label1.TabIndex = 3;
         this.label1.Text = "Cost Function";
         // 
         // cboSettingsCostFunction
         // 
         this.cboSettingsCostFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.cboSettingsCostFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboSettingsCostFunction.FormattingEnabled = true;
         this.cboSettingsCostFunction.Location = new System.Drawing.Point(4, 21);
         this.cboSettingsCostFunction.Margin = new System.Windows.Forms.Padding(4);
         this.cboSettingsCostFunction.Name = "cboSettingsCostFunction";
         this.cboSettingsCostFunction.Size = new System.Drawing.Size(262, 24);
         this.cboSettingsCostFunction.TabIndex = 4;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label2.Location = new System.Drawing.Point(0, 49);
         this.label2.Margin = new System.Windows.Forms.Padding(0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(270, 17);
         this.label2.TabIndex = 8;
         this.label2.Text = "Iterations";
         // 
         // pinSettingsIterations
         // 
         this.pinSettingsIterations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.pinSettingsIterations.Location = new System.Drawing.Point(4, 70);
         this.pinSettingsIterations.Margin = new System.Windows.Forms.Padding(4);
         this.pinSettingsIterations.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
         this.pinSettingsIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.pinSettingsIterations.Name = "pinSettingsIterations";
         this.pinSettingsIterations.Size = new System.Drawing.Size(262, 22);
         this.pinSettingsIterations.TabIndex = 9;
         this.pinSettingsIterations.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label3.Location = new System.Drawing.Point(0, 96);
         this.label3.Margin = new System.Windows.Forms.Padding(0);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(270, 17);
         this.label3.TabIndex = 10;
         this.label3.Text = "Dropout";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label4.Location = new System.Drawing.Point(270, 0);
         this.label4.Margin = new System.Windows.Forms.Padding(0);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(270, 17);
         this.label4.TabIndex = 12;
         this.label4.Text = "Algorithm";
         // 
         // cboSettingsAlgorithm
         // 
         this.cboSettingsAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.cboSettingsAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboSettingsAlgorithm.FormattingEnabled = true;
         this.cboSettingsAlgorithm.Location = new System.Drawing.Point(274, 21);
         this.cboSettingsAlgorithm.Margin = new System.Windows.Forms.Padding(4);
         this.cboSettingsAlgorithm.Name = "cboSettingsAlgorithm";
         this.cboSettingsAlgorithm.Size = new System.Drawing.Size(262, 24);
         this.cboSettingsAlgorithm.TabIndex = 13;
         // 
         // propSettingsAlgorithmParams
         // 
         this.propSettingsAlgorithmParams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.propSettingsAlgorithmParams.CanShowVisualStyleGlyphs = false;
         this.propSettingsAlgorithmParams.CommandsVisibleIfAvailable = false;
         this.propSettingsAlgorithmParams.HelpVisible = false;
         this.propSettingsAlgorithmParams.Location = new System.Drawing.Point(273, 51);
         this.propSettingsAlgorithmParams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.propSettingsAlgorithmParams.Name = "propSettingsAlgorithmParams";
         this.propSettingsAlgorithmParams.PropertySort = System.Windows.Forms.PropertySort.NoSort;
         this.tableLayoutPanel1.SetRowSpan(this.propSettingsAlgorithmParams, 4);
         this.propSettingsAlgorithmParams.Size = new System.Drawing.Size(264, 120);
         this.propSettingsAlgorithmParams.TabIndex = 14;
         this.propSettingsAlgorithmParams.ToolbarVisible = false;
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Controls.Add(this.tableLayoutPanel2);
         this.groupBox1.Location = new System.Drawing.Point(0, 70);
         this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
         this.groupBox1.Size = new System.Drawing.Size(548, 73);
         this.groupBox1.TabIndex = 4;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Initialization";
         // 
         // tableLayoutPanel2
         // 
         this.tableLayoutPanel2.ColumnCount = 2;
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel2.Controls.Add(this.cboInitializationWeights, 0, 1);
         this.tableLayoutPanel2.Controls.Add(this.cboInitializationBiases, 0, 1);
         this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
         this.tableLayoutPanel2.Controls.Add(this.label7, 1, 0);
         this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 19);
         this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
         this.tableLayoutPanel2.Name = "tableLayoutPanel2";
         this.tableLayoutPanel2.RowCount = 2;
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel2.Size = new System.Drawing.Size(540, 50);
         this.tableLayoutPanel2.TabIndex = 18;
         // 
         // cboInitializationWeights
         // 
         this.cboInitializationWeights.Dock = System.Windows.Forms.DockStyle.Fill;
         this.cboInitializationWeights.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboInitializationWeights.FormattingEnabled = true;
         this.cboInitializationWeights.Location = new System.Drawing.Point(4, 21);
         this.cboInitializationWeights.Margin = new System.Windows.Forms.Padding(4);
         this.cboInitializationWeights.Name = "cboInitializationWeights";
         this.cboInitializationWeights.Size = new System.Drawing.Size(262, 24);
         this.cboInitializationWeights.TabIndex = 13;
         // 
         // cboInitializationBiases
         // 
         this.cboInitializationBiases.Dock = System.Windows.Forms.DockStyle.Fill;
         this.cboInitializationBiases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboInitializationBiases.FormattingEnabled = true;
         this.cboInitializationBiases.Location = new System.Drawing.Point(274, 21);
         this.cboInitializationBiases.Margin = new System.Windows.Forms.Padding(4);
         this.cboInitializationBiases.Name = "cboInitializationBiases";
         this.cboInitializationBiases.Size = new System.Drawing.Size(262, 24);
         this.cboInitializationBiases.TabIndex = 12;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label6.Location = new System.Drawing.Point(0, 0);
         this.label6.Margin = new System.Windows.Forms.Padding(0);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(270, 17);
         this.label6.TabIndex = 9;
         this.label6.Text = "Weights";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label7.Location = new System.Drawing.Point(270, 0);
         this.label7.Margin = new System.Windows.Forms.Padding(0);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(270, 17);
         this.label7.TabIndex = 11;
         this.label7.Text = "Biases";
         // 
         // btnTrain
         // 
         this.btnTrain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
         this.btnTrain.Location = new System.Drawing.Point(4, 352);
         this.btnTrain.Margin = new System.Windows.Forms.Padding(4);
         this.btnTrain.Name = "btnTrain";
         this.btnTrain.Size = new System.Drawing.Size(100, 28);
         this.btnTrain.TabIndex = 14;
         this.btnTrain.Text = "Train";
         this.btnTrain.UseVisualStyleBackColor = false;
         // 
         // btnCancel
         // 
         this.btnCancel.Enabled = false;
         this.btnCancel.Location = new System.Drawing.Point(112, 352);
         this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(100, 28);
         this.btnCancel.TabIndex = 15;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         // 
         // txtLogs
         // 
         this.txtLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtLogs.BackColor = System.Drawing.Color.White;
         this.txtLogs.Location = new System.Drawing.Point(4, 388);
         this.txtLogs.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
         this.txtLogs.Multiline = true;
         this.txtLogs.Name = "txtLogs";
         this.txtLogs.ReadOnly = true;
         this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.txtLogs.Size = new System.Drawing.Size(544, 411);
         this.txtLogs.TabIndex = 16;
         // 
         // groupBox2
         // 
         this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox2.Controls.Add(this.btnDatasetLoad);
         this.groupBox2.Controls.Add(this.lblDatasetStatus);
         this.groupBox2.Controls.Add(this.btnDatasetView);
         this.groupBox2.Location = new System.Drawing.Point(0, 0);
         this.groupBox2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
         this.groupBox2.Size = new System.Drawing.Size(548, 64);
         this.groupBox2.TabIndex = 17;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Dataset";
         // 
         // btnDatasetLoad
         // 
         this.btnDatasetLoad.Location = new System.Drawing.Point(8, 23);
         this.btnDatasetLoad.Margin = new System.Windows.Forms.Padding(4);
         this.btnDatasetLoad.Name = "btnDatasetLoad";
         this.btnDatasetLoad.Size = new System.Drawing.Size(100, 28);
         this.btnDatasetLoad.TabIndex = 19;
         this.btnDatasetLoad.Text = "Load";
         this.btnDatasetLoad.ItemClick += new System.EventHandler<NeuralNetworkMaker.ItemClickEventArgs>(this.btnDatasetLoad_ItemClick);
         // 
         // lblDatasetStatus
         // 
         this.lblDatasetStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.lblDatasetStatus.AutoSize = true;
         this.lblDatasetStatus.Location = new System.Drawing.Point(228, 30);
         this.lblDatasetStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lblDatasetStatus.Name = "lblDatasetStatus";
         this.lblDatasetStatus.Size = new System.Drawing.Size(99, 17);
         this.lblDatasetStatus.TabIndex = 18;
         this.lblDatasetStatus.Text = "Status dataset";
         // 
         // btnDatasetView
         // 
         this.btnDatasetView.Enabled = false;
         this.btnDatasetView.Location = new System.Drawing.Point(120, 23);
         this.btnDatasetView.Margin = new System.Windows.Forms.Padding(4);
         this.btnDatasetView.Name = "btnDatasetView";
         this.btnDatasetView.Size = new System.Drawing.Size(100, 28);
         this.btnDatasetView.TabIndex = 16;
         this.btnDatasetView.Text = "View...";
         this.btnDatasetView.UseVisualStyleBackColor = true;
         // 
         // TrainingControl
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.txtLogs);
         this.Controls.Add(this.btnTrain);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.groupBox4);
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "TrainingControl";
         this.Size = new System.Drawing.Size(553, 800);
         this.Load += new System.EventHandler(this.TrainingControl_Load);
         this.groupBox4.ResumeLayout(false);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pinSettingsDropout)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pinSettingsIterations)).EndInit();
         this.groupBox1.ResumeLayout(false);
         this.tableLayoutPanel2.ResumeLayout(false);
         this.tableLayoutPanel2.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox4;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Button btnTrain;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.TextBox txtLogs;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.Button btnDatasetView;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.NumericUpDown pinSettingsDropout;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ComboBox cboSettingsCostFunction;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.NumericUpDown pinSettingsIterations;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.ComboBox cboSettingsAlgorithm;
      private System.Windows.Forms.PropertyGrid propSettingsAlgorithmParams;
      private System.Windows.Forms.Label lblDatasetStatus;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
      private System.Windows.Forms.ComboBox cboInitializationWeights;
      private System.Windows.Forms.ComboBox cboInitializationBiases;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private DropDownButton btnDatasetLoad;
   }
}
