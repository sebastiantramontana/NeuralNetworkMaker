using System;
using System.Windows.Forms;
using NeuralNetwork.Model;
using NeuralNetwork.Model.Layers;
using NeuralNetwork.Model.Nodes;
using NeuralNetwork.Visualizer.Drawing;
using NeuralNetwork.Visualizer.Preferences.Text;
using NeuralNetwork.Visualizer.Selection;
using NeuralNetworkMaker.Preferences;

namespace NeuralNetworkMaker
{
   public partial class MainForm : Form
   {
      private InputLayer _inputLayer;

      public MainForm()
      {
         InitializeComponent();

         designControl.NNVisualizerControl = NNVisualizerControl;
         trainingControl.VisualizerControl = NNVisualizerControl;
         trainingControl.DatasetGridControl = datasetGrid;

         ConfigureNNVisualizer();
      }

      private void MainForm_Load(object sender, EventArgs e)
      {
         LoadComboQualityNNVisualizer();
         NewNeuralNetwork();
      }

      private void NewMenuItem_Click(object sender, EventArgs e)
      {
         NewNeuralNetwork();
      }

      private void NewNeuralNetwork()
      {
         _inputLayer = new InputLayer("Input");
         _inputLayer.AddNode(new Input("I1"));
         _inputLayer.AddNode(new Input("I2"));

         var outputLayer = new NeuronLayer("Output");
         outputLayer.AddNode(new Neuron("O") { ActivationFunction = ActivationFunction.Sigmoid });

         _inputLayer.Connect(outputLayer);

         NNVisualizerControl.InputLayer = _inputLayer;
         NNVisualizerControl.Redraw();

         trainingControl.VisualizerControl = NNVisualizerControl;
      }

      private void ConfigureNNVisualizer()
      {
         NNVisualizerControl.Preferences.AutoRedrawMode = AutoRedrawMode.AutoRedrawAsync;
         NNVisualizerControl.Preferences.Quality = RenderQuality.Medium;
         NNVisualizerControl.Selectable = true;
         NNVisualizerControl.Preferences.Layers.Title = null;
         NNVisualizerControl.Preferences.Layers.Border = null;
         NNVisualizerControl.Preferences.Layers.BorderSelected = null;
         NNVisualizerControl.Preferences.InputFontLabel = InputFontLabel.Default;
         NNVisualizerControl.Preferences.OutputFontLabel = OutputFontLabel.Default;

         NNVisualizerControl.SelectInputLayer += NNVisualizerControl_SelectInputLayer;
         NNVisualizerControl.SelectNeuronLayer += NNVisualizerControl_SelectNeuronLayer;
         NNVisualizerControl.SelectBias += NNVisualizerControl_SelectBias;
         NNVisualizerControl.SelectInput += NNVisualizerControl_SelectInput;
         NNVisualizerControl.SelectNeuron += NNVisualizerControl_SelectNeuron;
         NNVisualizerControl.SelectEdge += NNVisualizerControl_SelectEdge;
      }

      private void NNVisualizerControl_SelectEdge(object sender, SelectionEventArgs<Edge> e)
      {
         designControl.SelectElement(e);
      }

      private void NNVisualizerControl_SelectNeuron(object sender, SelectionEventArgs<Neuron> e)
      {
         designControl.SelectElement(e);
      }

      private void NNVisualizerControl_SelectBias(object sender, SelectionEventArgs<Bias> e)
      {
         designControl.SelectElement(e);
      }

      private void NNVisualizerControl_SelectInput(object sender, SelectionEventArgs<Input> e)
      {
         designControl.SelectElement(e);
      }

      private void NNVisualizerControl_SelectNeuronLayer(object sender, SelectionEventArgs<NeuronLayer> e)
      {
         designControl.SelectElement(e);
      }

      private void NNVisualizerControl_SelectInputLayer(object sender, SelectionEventArgs<InputLayer> e)
      {
         designControl.SelectElement(e);
      }

      private void LoadComboQualityNNVisualizer()
      {
         ComboQualityNNVisualizer.Items.Add(RenderQuality.Low);
         ComboQualityNNVisualizer.Items.Add(RenderQuality.Medium);
         ComboQualityNNVisualizer.Items.Add(RenderQuality.High);

         ComboQualityNNVisualizer.SelectedItem = NNVisualizerControl.Preferences.Quality;
      }

      private void ComboQualityNNVisualizer_SelectedIndexChanged(object sender, EventArgs e)
      {
         NNVisualizerControl.Preferences.Quality = (RenderQuality)ComboQualityNNVisualizer.SelectedItem;
         NNVisualizerControl.Redraw();
      }

      private void btnZoomInNNVisualizer_Click(object sender, EventArgs e)
      {
         NNVisualizerControl.Zoom *= 1.1f;
      }

      private void btnZoomOutNNVisualizer_Click(object sender, EventArgs e)
      {
         NNVisualizerControl.Zoom *= 0.9f;
      }

      private void btnExportAsImageNNVisualizer_Click(object sender, EventArgs e)
      {
         ExportNNVisualizerAsImage();
      }

      private void btnPreferencesNNVisualizer_Click(object sender, EventArgs e)
      {
         using (var frm = new frmPreferences(NNVisualizerControl))
         {
            frm.ShowDialog();
         }
      }

      private void tabActions_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (tabActions.SelectedTab == tabTraining)
         {
            ShowDatasetGrid();
         }
         else
         {
            ShowNeuralNetwork();
         }
      }

      private void ShowDatasetGrid()
      {
         SwitchLargePanelShowingControl(false);
      }

      private void ShowNeuralNetwork()
      {
         SwitchLargePanelShowingControl(true);
      }

      private void SwitchLargePanelShowingControl(bool showNeuralNetwork)
      {
         MainContainer.Panel2.SuspendLayout();
         MainContainer.Panel2.Controls[ToolbarNNVisualizer.Name].Visible = showNeuralNetwork;
         MainContainer.Panel2.Controls[NNVisualizerControl.Name].Visible = showNeuralNetwork;
         MainContainer.Panel2.Controls[datasetGrid.Name].Visible = !showNeuralNetwork;
         MainContainer.Panel2.ResumeLayout();
      }

      private void ExportNNVisualizerAsImage()
      {
         string fileName = ShowSaveDialog("PNG files (*.png)|*.png", "PNG files(*.png)|*.png|JPG files (*.jpg)|*.jpg", "Export Neural Network as Image");

         if (string.IsNullOrWhiteSpace(fileName))
            return;

         var image = NNVisualizerControl.Image;

         try
         {
            image.Save(fileName);
         }
         catch (Exception ex)
         {
            MessageBox.Show($"Image couldn't be saved!{Environment.NewLine}{ex.Message}", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
         }

         MessageBox.Show("Image saved succesfully!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }

      private string ShowSaveDialog(string defaultExt, string filter, string title)
      {
         using (var dialog = new SaveFileDialog()
         {
            AddExtension = true,
            CheckFileExists = false,
            CheckPathExists = true,
            CreatePrompt = false,
            FilterIndex = 0,
            DefaultExt = defaultExt,
            Filter = filter,
            OverwritePrompt = true,
            RestoreDirectory = true,
            ValidateNames = true,
            Title = title
         })
         {
            return (dialog.ShowDialog(this) == DialogResult.Cancel) ? string.Empty : dialog.FileName;
         }
      }
   }
}
