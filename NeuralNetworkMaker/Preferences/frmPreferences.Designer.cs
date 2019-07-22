namespace NeuralNetworkMaker.Preferences
{
    partial class frmPreferences
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
         NeuralNetwork.Visualizer.Preferences.NodePreference nodePreference1 = new NeuralNetwork.Visualizer.Preferences.NodePreference();
         NeuralNetwork.Visualizer.Preferences.NodePreference nodePreference2 = new NeuralNetwork.Visualizer.Preferences.NodePreference();
         NeuralNetwork.Visualizer.Preferences.NodePreference nodePreference3 = new NeuralNetwork.Visualizer.Preferences.NodePreference();
         this.tabMain = new System.Windows.Forms.TabControl();
         this.tabGeneral = new System.Windows.Forms.TabPage();
         this.chkAsyncRedrawOnResize = new System.Windows.Forms.CheckBox();
         this.label3 = new System.Windows.Forms.Label();
         this.cboRenderQuality = new System.Windows.Forms.ComboBox();
         this.spinNodesMargin = new System.Windows.Forms.NumericUpDown();
         this.label1 = new System.Windows.Forms.Label();
         this.tabLayers = new System.Windows.Forms.TabPage();
         this.brushLayersBackgroundSelected = new NeuralNetworkMaker.Preferences.Controls.BrushPreferenceControl();
         this.brushLayersBackground = new NeuralNetworkMaker.Preferences.Controls.BrushPreferenceControl();
         this.label7 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.penLayersBorderSelected = new NeuralNetworkMaker.Preferences.Controls.PenControl();
         this.label5 = new System.Windows.Forms.Label();
         this.penLayersBorder = new NeuralNetworkMaker.Preferences.Controls.PenControl();
         this.label4 = new System.Windows.Forms.Label();
         this.tabInputs = new System.Windows.Forms.TabPage();
         this.prefInputs = new NeuralNetworkMaker.Preferences.Controls.NodePreferenceControl();
         this.tabNeurons = new System.Windows.Forms.TabPage();
         this.label2 = new System.Windows.Forms.Label();
         this.formatterNeuronsSumValue = new NeuralNetworkMaker.Preferences.Controls.ByValueSignTextFormatterControl();
         this.prefNeurons = new NeuralNetworkMaker.Preferences.Controls.NodePreferenceControl();
         this.tabBiases = new System.Windows.Forms.TabPage();
         this.prefBiases = new NeuralNetworkMaker.Preferences.Controls.NodePreferenceControl();
         this.tabEdges = new System.Windows.Forms.TabPage();
         this.formatterEdgesConnectorSelected = new NeuralNetworkMaker.Preferences.Controls.ByValueSignPenFormatterControl();
         this.formatterEdgesConnector = new NeuralNetworkMaker.Preferences.Controls.ByValueSignPenFormatterControl();
         this.spinEdgesRoundingDigits = new System.Windows.Forms.NumericUpDown();
         this.label11 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.formatterEdgesWeight = new NeuralNetworkMaker.Preferences.Controls.ByValueSignTextFormatterControl();
         this.tabMain.SuspendLayout();
         this.tabGeneral.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.spinNodesMargin)).BeginInit();
         this.tabLayers.SuspendLayout();
         this.tabInputs.SuspendLayout();
         this.tabNeurons.SuspendLayout();
         this.tabBiases.SuspendLayout();
         this.tabEdges.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.spinEdgesRoundingDigits)).BeginInit();
         this.SuspendLayout();
         // 
         // tabMain
         // 
         this.tabMain.Controls.Add(this.tabGeneral);
         this.tabMain.Controls.Add(this.tabLayers);
         this.tabMain.Controls.Add(this.tabInputs);
         this.tabMain.Controls.Add(this.tabNeurons);
         this.tabMain.Controls.Add(this.tabBiases);
         this.tabMain.Controls.Add(this.tabEdges);
         this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tabMain.Location = new System.Drawing.Point(0, 0);
         this.tabMain.Margin = new System.Windows.Forms.Padding(2);
         this.tabMain.Name = "tabMain";
         this.tabMain.SelectedIndex = 0;
         this.tabMain.Size = new System.Drawing.Size(899, 560);
         this.tabMain.TabIndex = 0;
         // 
         // tabGeneral
         // 
         this.tabGeneral.Controls.Add(this.chkAsyncRedrawOnResize);
         this.tabGeneral.Controls.Add(this.label3);
         this.tabGeneral.Controls.Add(this.cboRenderQuality);
         this.tabGeneral.Controls.Add(this.spinNodesMargin);
         this.tabGeneral.Controls.Add(this.label1);
         this.tabGeneral.Location = new System.Drawing.Point(4, 22);
         this.tabGeneral.Margin = new System.Windows.Forms.Padding(2);
         this.tabGeneral.Name = "tabGeneral";
         this.tabGeneral.Padding = new System.Windows.Forms.Padding(2);
         this.tabGeneral.Size = new System.Drawing.Size(891, 534);
         this.tabGeneral.TabIndex = 0;
         this.tabGeneral.Text = "General";
         this.tabGeneral.UseVisualStyleBackColor = true;
         // 
         // chkAsyncRedrawOnResize
         // 
         this.chkAsyncRedrawOnResize.AutoSize = true;
         this.chkAsyncRedrawOnResize.Location = new System.Drawing.Point(10, 99);
         this.chkAsyncRedrawOnResize.Margin = new System.Windows.Forms.Padding(8, 2, 2, 2);
         this.chkAsyncRedrawOnResize.Name = "chkAsyncRedrawOnResize";
         this.chkAsyncRedrawOnResize.Size = new System.Drawing.Size(147, 17);
         this.chkAsyncRedrawOnResize.TabIndex = 5;
         this.chkAsyncRedrawOnResize.Text = "Async Redraw On Resize";
         this.chkAsyncRedrawOnResize.UseVisualStyleBackColor = true;
         this.chkAsyncRedrawOnResize.CheckedChanged += new System.EventHandler(this.chkAsyncRedrawOnResize_CheckedChanged);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(10, 53);
         this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 2, 0);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(77, 13);
         this.label3.TabIndex = 4;
         this.label3.Text = "Render Quality";
         // 
         // cboRenderQuality
         // 
         this.cboRenderQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboRenderQuality.FormattingEnabled = true;
         this.cboRenderQuality.Location = new System.Drawing.Point(10, 69);
         this.cboRenderQuality.Margin = new System.Windows.Forms.Padding(8, 2, 2, 8);
         this.cboRenderQuality.Name = "cboRenderQuality";
         this.cboRenderQuality.Size = new System.Drawing.Size(92, 21);
         this.cboRenderQuality.TabIndex = 3;
         this.cboRenderQuality.SelectedIndexChanged += new System.EventHandler(this.cboRenderQuality_SelectedIndexChanged);
         // 
         // spinNodesMargin
         // 
         this.spinNodesMargin.Location = new System.Drawing.Point(10, 27);
         this.spinNodesMargin.Margin = new System.Windows.Forms.Padding(8, 2, 2, 8);
         this.spinNodesMargin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
         this.spinNodesMargin.Name = "spinNodesMargin";
         this.spinNodesMargin.Size = new System.Drawing.Size(90, 20);
         this.spinNodesMargin.TabIndex = 1;
         this.spinNodesMargin.ValueChanged += new System.EventHandler(this.spinNodesMargin_ValueChanged);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(10, 11);
         this.label1.Margin = new System.Windows.Forms.Padding(8, 8, 2, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(93, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Nodes Margin (px)";
         // 
         // tabLayers
         // 
         this.tabLayers.Controls.Add(this.brushLayersBackgroundSelected);
         this.tabLayers.Controls.Add(this.brushLayersBackground);
         this.tabLayers.Controls.Add(this.label7);
         this.tabLayers.Controls.Add(this.label6);
         this.tabLayers.Controls.Add(this.penLayersBorderSelected);
         this.tabLayers.Controls.Add(this.label5);
         this.tabLayers.Controls.Add(this.penLayersBorder);
         this.tabLayers.Controls.Add(this.label4);
         this.tabLayers.Location = new System.Drawing.Point(4, 22);
         this.tabLayers.Margin = new System.Windows.Forms.Padding(2);
         this.tabLayers.Name = "tabLayers";
         this.tabLayers.Padding = new System.Windows.Forms.Padding(2);
         this.tabLayers.Size = new System.Drawing.Size(192, 74);
         this.tabLayers.TabIndex = 1;
         this.tabLayers.Text = "Layers";
         this.tabLayers.UseVisualStyleBackColor = true;
         // 
         // brushLayersBackgroundSelected
         // 
         this.brushLayersBackgroundSelected.Brush = null;
         this.brushLayersBackgroundSelected.Location = new System.Drawing.Point(180, 25);
         this.brushLayersBackgroundSelected.Margin = new System.Windows.Forms.Padding(4, 4, 4, 10);
         this.brushLayersBackgroundSelected.MaximumSize = new System.Drawing.Size(168, 32);
         this.brushLayersBackgroundSelected.MinimumSize = new System.Drawing.Size(168, 32);
         this.brushLayersBackgroundSelected.Name = "brushLayersBackgroundSelected";
         this.brushLayersBackgroundSelected.Size = new System.Drawing.Size(168, 32);
         this.brushLayersBackgroundSelected.TabIndex = 9;
         // 
         // brushLayersBackground
         // 
         this.brushLayersBackground.Brush = null;
         this.brushLayersBackground.Location = new System.Drawing.Point(4, 25);
         this.brushLayersBackground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 10);
         this.brushLayersBackground.MaximumSize = new System.Drawing.Size(168, 32);
         this.brushLayersBackground.MinimumSize = new System.Drawing.Size(168, 32);
         this.brushLayersBackground.Name = "brushLayersBackground";
         this.brushLayersBackground.Size = new System.Drawing.Size(168, 32);
         this.brushLayersBackground.TabIndex = 8;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(177, 8);
         this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(110, 13);
         this.label7.TabIndex = 7;
         this.label7.Text = "Background Selected";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(445, 67);
         this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(83, 13);
         this.label6.TabIndex = 5;
         this.label6.Text = "Border Selected";
         // 
         // penLayersBorderSelected
         // 
         this.penLayersBorderSelected.AutoSize = true;
         this.penLayersBorderSelected.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.penLayersBorderSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.penLayersBorderSelected.Location = new System.Drawing.Point(444, 84);
         this.penLayersBorderSelected.Margin = new System.Windows.Forms.Padding(4);
         this.penLayersBorderSelected.Name = "penLayersBorderSelected";
         this.penLayersBorderSelected.Size = new System.Drawing.Size(432, 261);
         this.penLayersBorderSelected.TabIndex = 4;
         this.penLayersBorderSelected.PenChanged += new System.EventHandler(this.penLayersBorderSelected_PenChanged);
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(7, 67);
         this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(38, 13);
         this.label5.TabIndex = 3;
         this.label5.Text = "Border";
         // 
         // penLayersBorder
         // 
         this.penLayersBorder.AutoSize = true;
         this.penLayersBorder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.penLayersBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.penLayersBorder.Location = new System.Drawing.Point(4, 84);
         this.penLayersBorder.Margin = new System.Windows.Forms.Padding(4);
         this.penLayersBorder.Name = "penLayersBorder";
         this.penLayersBorder.Size = new System.Drawing.Size(432, 261);
         this.penLayersBorder.TabIndex = 2;
         this.penLayersBorder.PenChanged += new System.EventHandler(this.penLayersBorder_PenChanged);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(4, 8);
         this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(65, 13);
         this.label4.TabIndex = 1;
         this.label4.Text = "Background";
         // 
         // tabInputs
         // 
         this.tabInputs.Controls.Add(this.prefInputs);
         this.tabInputs.Location = new System.Drawing.Point(4, 22);
         this.tabInputs.Margin = new System.Windows.Forms.Padding(2);
         this.tabInputs.Name = "tabInputs";
         this.tabInputs.Padding = new System.Windows.Forms.Padding(2);
         this.tabInputs.Size = new System.Drawing.Size(192, 74);
         this.tabInputs.TabIndex = 2;
         this.tabInputs.Text = "Inputs";
         this.tabInputs.UseVisualStyleBackColor = true;
         // 
         // prefInputs
         // 
         this.prefInputs.AutoSize = true;
         this.prefInputs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.prefInputs.Location = new System.Drawing.Point(4, 4);
         this.prefInputs.Margin = new System.Windows.Forms.Padding(4);
         this.prefInputs.Name = "prefInputs";
         nodePreference1.RoundingDigits = ((byte)(3));
         this.prefInputs.NodePreference = nodePreference1;
         this.prefInputs.Size = new System.Drawing.Size(883, 441);
         this.prefInputs.TabIndex = 0;
         this.prefInputs.NodePreferenceChanged += new System.EventHandler(this.prefInputs_NodePreferenceChanged);
         // 
         // tabNeurons
         // 
         this.tabNeurons.Controls.Add(this.label2);
         this.tabNeurons.Controls.Add(this.formatterNeuronsSumValue);
         this.tabNeurons.Controls.Add(this.prefNeurons);
         this.tabNeurons.Location = new System.Drawing.Point(4, 22);
         this.tabNeurons.Margin = new System.Windows.Forms.Padding(2);
         this.tabNeurons.Name = "tabNeurons";
         this.tabNeurons.Padding = new System.Windows.Forms.Padding(2);
         this.tabNeurons.Size = new System.Drawing.Size(192, 74);
         this.tabNeurons.TabIndex = 3;
         this.tabNeurons.Text = "Neurons";
         this.tabNeurons.UseVisualStyleBackColor = true;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(8, 9);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(93, 13);
         this.label2.TabIndex = 2;
         this.label2.Text = "Sum Value Format";
         // 
         // formatterNeuronsSumValue
         // 
         this.formatterNeuronsSumValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.formatterNeuronsSumValue.Location = new System.Drawing.Point(4, 25);
         this.formatterNeuronsSumValue.Margin = new System.Windows.Forms.Padding(4);
         this.formatterNeuronsSumValue.Name = "formatterNeuronsSumValue";
         this.formatterNeuronsSumValue.Size = new System.Drawing.Size(878, 62);
         this.formatterNeuronsSumValue.TabIndex = 1;
         this.formatterNeuronsSumValue.TextFormatterChanged += new System.EventHandler(this.formatterNeuronsSumValue_TextFormatterChanged);
         // 
         // prefNeurons
         // 
         this.prefNeurons.AutoSize = true;
         this.prefNeurons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.prefNeurons.Location = new System.Drawing.Point(4, 90);
         this.prefNeurons.Margin = new System.Windows.Forms.Padding(4);
         this.prefNeurons.Name = "prefNeurons";
         nodePreference2.RoundingDigits = ((byte)(3));
         this.prefNeurons.NodePreference = nodePreference2;
         this.prefNeurons.Size = new System.Drawing.Size(883, 441);
         this.prefNeurons.TabIndex = 0;
         this.prefNeurons.NodePreferenceChanged += new System.EventHandler(this.prefNeurons_NodePreferenceChanged);
         // 
         // tabBiases
         // 
         this.tabBiases.Controls.Add(this.prefBiases);
         this.tabBiases.Location = new System.Drawing.Point(4, 22);
         this.tabBiases.Margin = new System.Windows.Forms.Padding(2);
         this.tabBiases.Name = "tabBiases";
         this.tabBiases.Padding = new System.Windows.Forms.Padding(2);
         this.tabBiases.Size = new System.Drawing.Size(192, 74);
         this.tabBiases.TabIndex = 4;
         this.tabBiases.Text = "Biases";
         this.tabBiases.UseVisualStyleBackColor = true;
         // 
         // prefBiases
         // 
         this.prefBiases.AutoSize = true;
         this.prefBiases.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.prefBiases.Location = new System.Drawing.Point(4, 4);
         this.prefBiases.Margin = new System.Windows.Forms.Padding(4);
         this.prefBiases.Name = "prefBiases";
         nodePreference3.RoundingDigits = ((byte)(3));
         this.prefBiases.NodePreference = nodePreference3;
         this.prefBiases.Size = new System.Drawing.Size(883, 441);
         this.prefBiases.TabIndex = 0;
         this.prefBiases.NodePreferenceChanged += new System.EventHandler(this.prefBiases_NodePreferenceChanged);
         // 
         // tabEdges
         // 
         this.tabEdges.Controls.Add(this.formatterEdgesConnectorSelected);
         this.tabEdges.Controls.Add(this.formatterEdgesConnector);
         this.tabEdges.Controls.Add(this.spinEdgesRoundingDigits);
         this.tabEdges.Controls.Add(this.label11);
         this.tabEdges.Controls.Add(this.label9);
         this.tabEdges.Controls.Add(this.label8);
         this.tabEdges.Controls.Add(this.label10);
         this.tabEdges.Controls.Add(this.formatterEdgesWeight);
         this.tabEdges.Location = new System.Drawing.Point(4, 22);
         this.tabEdges.Margin = new System.Windows.Forms.Padding(2);
         this.tabEdges.Name = "tabEdges";
         this.tabEdges.Padding = new System.Windows.Forms.Padding(2);
         this.tabEdges.Size = new System.Drawing.Size(891, 534);
         this.tabEdges.TabIndex = 5;
         this.tabEdges.Text = "Edges";
         this.tabEdges.UseVisualStyleBackColor = true;
         // 
         // formatterEdgesConnectorSelected
         // 
         this.formatterEdgesConnectorSelected.AutoSize = true;
         this.formatterEdgesConnectorSelected.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.formatterEdgesConnectorSelected.Location = new System.Drawing.Point(446, 160);
         this.formatterEdgesConnectorSelected.Name = "formatterEdgesConnectorSelected";
         this.formatterEdgesConnectorSelected.Size = new System.Drawing.Size(432, 287);
         this.formatterEdgesConnectorSelected.TabIndex = 19;
         this.formatterEdgesConnectorSelected.PenFormatterChanged += new System.EventHandler(this.formatterEdgesConnectorSelected_PenFormatterChanged);
         // 
         // formatterEdgesConnector
         // 
         this.formatterEdgesConnector.AutoSize = true;
         this.formatterEdgesConnector.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.formatterEdgesConnector.Location = new System.Drawing.Point(8, 160);
         this.formatterEdgesConnector.Name = "formatterEdgesConnector";
         this.formatterEdgesConnector.Size = new System.Drawing.Size(432, 287);
         this.formatterEdgesConnector.TabIndex = 18;
         this.formatterEdgesConnector.PenFormatterChanged += new System.EventHandler(this.formatterEdgesConnector_PenFormatterChanged);
         // 
         // spinEdgesRoundingDigits
         // 
         this.spinEdgesRoundingDigits.Location = new System.Drawing.Point(8, 28);
         this.spinEdgesRoundingDigits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 8);
         this.spinEdgesRoundingDigits.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
         this.spinEdgesRoundingDigits.Name = "spinEdgesRoundingDigits";
         this.spinEdgesRoundingDigits.Size = new System.Drawing.Size(90, 20);
         this.spinEdgesRoundingDigits.TabIndex = 17;
         this.spinEdgesRoundingDigits.ValueChanged += new System.EventHandler(this.spinEdgesRoundingDigits_ValueChanged);
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.Location = new System.Drawing.Point(5, 12);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(82, 13);
         this.label11.TabIndex = 16;
         this.label11.Text = "Rounding Digits";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(443, 144);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(193, 13);
         this.label9.TabIndex = 15;
         this.label9.Text = "Connector Selected Format (by Weight)";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(5, 144);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(148, 13);
         this.label8.TabIndex = 13;
         this.label8.Text = "Connector Format (by Weight)";
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Location = new System.Drawing.Point(5, 54);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(76, 13);
         this.label10.TabIndex = 11;
         this.label10.Text = "Weight Format";
         // 
         // formatterEdgesWeight
         // 
         this.formatterEdgesWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.formatterEdgesWeight.Location = new System.Drawing.Point(4, 72);
         this.formatterEdgesWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 10);
         this.formatterEdgesWeight.Name = "formatterEdgesWeight";
         this.formatterEdgesWeight.Size = new System.Drawing.Size(878, 62);
         this.formatterEdgesWeight.TabIndex = 10;
         this.formatterEdgesWeight.TextFormatterChanged += new System.EventHandler(this.formatterEdgesWeight_TextFormatterChanged);
         // 
         // frmPreferences
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
         this.AutoSize = true;
         this.ClientSize = new System.Drawing.Size(899, 560);
         this.Controls.Add(this.tabMain);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmPreferences";
         this.Text = "Preferences";
         this.Load += new System.EventHandler(this.frmPreferences_Load);
         this.tabMain.ResumeLayout(false);
         this.tabGeneral.ResumeLayout(false);
         this.tabGeneral.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.spinNodesMargin)).EndInit();
         this.tabLayers.ResumeLayout(false);
         this.tabLayers.PerformLayout();
         this.tabInputs.ResumeLayout(false);
         this.tabInputs.PerformLayout();
         this.tabNeurons.ResumeLayout(false);
         this.tabNeurons.PerformLayout();
         this.tabBiases.ResumeLayout(false);
         this.tabBiases.PerformLayout();
         this.tabEdges.ResumeLayout(false);
         this.tabEdges.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.spinEdgesRoundingDigits)).EndInit();
         this.ResumeLayout(false);

        }

      #endregion

      private System.Windows.Forms.TabControl tabMain;
      private System.Windows.Forms.TabPage tabGeneral;
      private System.Windows.Forms.NumericUpDown spinNodesMargin;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TabPage tabLayers;
      private System.Windows.Forms.TabPage tabInputs;
      private System.Windows.Forms.TabPage tabNeurons;
      private System.Windows.Forms.TabPage tabBiases;
      private System.Windows.Forms.TabPage tabEdges;
      private System.Windows.Forms.CheckBox chkAsyncRedrawOnResize;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.ComboBox cboRenderQuality;
      private System.Windows.Forms.Label label6;
      private Controls.PenControl penLayersBorderSelected;
      private System.Windows.Forms.Label label5;
      private Controls.PenControl penLayersBorder;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label7;
      private Controls.NodePreferenceControl prefInputs;
      private Controls.NodePreferenceControl prefNeurons;
      private Controls.ByValueSignTextFormatterControl formatterNeuronsSumValue;
      private System.Windows.Forms.Label label2;
      private Controls.NodePreferenceControl prefBiases;
      private System.Windows.Forms.Label label10;
      private Controls.ByValueSignTextFormatterControl formatterEdgesWeight;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.NumericUpDown spinEdgesRoundingDigits;
      private Controls.ByValueSignPenFormatterControl formatterEdgesConnectorSelected;
      private Controls.ByValueSignPenFormatterControl formatterEdgesConnector;
      private Controls.BrushPreferenceControl brushLayersBackgroundSelected;
      private Controls.BrushPreferenceControl brushLayersBackground;
   }
}