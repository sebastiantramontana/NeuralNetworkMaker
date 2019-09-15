using NeuralNetwork.Model;
using NeuralNetwork.Model.Layers;
using NeuralNetwork.Model.Nodes;
using NeuralNetwork.Visualizer.Drawing;
using NeuralNetwork.Visualizer.Preferences.Text;
using NeuralNetwork.Visualizer.Selection;
using NeuralNetworkMaker.MainTabControls.Training.Datasets;
using NeuralNetworkMaker.Preferences;
using NeuralNetworkMaker.Selection.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetworkMaker
{
   public partial class MainForm : Form
   {
      private InputLayer _inputLayer;
      private readonly IDesignController _designController;
      private readonly IDesignButtonsControlLogic _designButtonsControlLogic;
      private readonly IPropertyObjectFactory _propertyObjectFactory;

      public MainForm()
      {
         InitializeComponent();

         _designController = new DesignController();
         _designButtonsControlLogic = new DesignButtonsControlLogic(NNVisualizerControl, btnAddLayer, btnRemoveSelectedLayers, btnAddNode, btnRemoveSelectedNodes, btnToggleBias);
         _propertyObjectFactory = new PropertyObjectFactory(NNVisualizerControl);

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
         FireSelectElement(e);
      }

      private void NNVisualizerControl_SelectNeuron(object sender, SelectionEventArgs<Neuron> e)
      {
         FireSelectElement(e);
      }

      private void NNVisualizerControl_SelectBias(object sender, SelectionEventArgs<Bias> e)
      {
         FireSelectElement(e);
      }

      private void NNVisualizerControl_SelectInput(object sender, SelectionEventArgs<Input> e)
      {
         FireSelectElement(e);
      }

      private void NNVisualizerControl_SelectNeuronLayer(object sender, SelectionEventArgs<NeuronLayer> e)
      {
         FireSelectElement(e);
      }

      private void NNVisualizerControl_SelectInputLayer(object sender, SelectionEventArgs<InputLayer> e)
      {
         FireSelectElement(e);
      }

      private void FireSelectElement<TElement>(SelectionEventArgs<TElement> e)
         where TElement : Element
      {
         var selectionType = NNVisualizerControl.GetSelectionType();

         _designButtonsControlLogic.EnableDesign(selectionType);
         PropertyGridDesign.SelectedObject = _propertyObjectFactory.GetObject(selectionType);
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

      private void btnPreferencesNNVisualizer_Click(object sender, EventArgs e)
      {
         using (var frm = new frmPreferences(NNVisualizerControl))
         {
            frm.ShowDialog();
         }
      }

      private void btnAddLayer_Click(object sender, EventArgs e)
      {
         ExecuteDesignAction(async () => { await InsertLayer(); });
      }

      private void btnRemoveSelectedLayers_Click(object sender, EventArgs e)
      {
         ExecuteDesignAction(async () => { await RemoveSelectedLayers(); });
      }

      private void btnAddNode_Click(object sender, EventArgs e)
      {
         ExecuteDesignAction(async () => { await AddNodes(); });
      }

      private void btnRemoveSelectedNodes_Click(object sender, EventArgs e)
      {
         ExecuteDesignAction(async () => { await RemoveSelectedNodes(); });
      }

      private void btnToggleBias_Click(object sender, EventArgs e)
      {
         ExecuteDesignAction(async () => { await ToggleBias(btnToggleBias.Checked); });
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

      private void ExecuteDesignAction(Action action)
      {
         action.Invoke();

         var selectionType = NNVisualizerControl.GetSelectionType();
         _designButtonsControlLogic.EnableDesign(selectionType);
         PropertyGridDesign.SelectedObject = _propertyObjectFactory.GetObject(selectionType);
      }

      private async Task InsertLayer()
      {
         var lastElement = NNVisualizerControl.SelectedElements.LastOrDefault();
         var layer = lastElement?.GetLayerContainer();

         NNVisualizerControl.SuspendAutoRedraw();
         _designController.AddLayer(layer);
         await NNVisualizerControl.ResumeAutoRedraw();
      }

      private async Task RemoveSelectedLayers()
      {
         var layersToRemove = NNVisualizerControl
                              .SelectedElements
                              .Select(e => e.GetLayerContainer())
                              .OfType<NeuronLayer>()
                              .Distinct();

         NNVisualizerControl.SuspendAutoRedraw();
         _designController.RemoveLayers(layersToRemove);
         await NNVisualizerControl.ResumeAutoRedraw();
      }

      private async Task AddNodes()
      {
         var layers = NNVisualizerControl
                        .SelectedElements
                        .Select(e => e.GetLayerContainer())
                        .Distinct();

         NNVisualizerControl.SuspendAutoRedraw();
         _designController.AddNodes(layers);
         await NNVisualizerControl.ResumeAutoRedraw();
      }

      private async Task RemoveSelectedNodes()
      {
         var nodesToRemove = NNVisualizerControl
                        .SelectedElements
                        .OfType<NodeBase>()
                        .Distinct();

         NNVisualizerControl.SuspendAutoRedraw();
         _designController.RemoveNodes(nodesToRemove);
         await NNVisualizerControl.ResumeAutoRedraw();
      }

      private async Task ToggleBias(bool isAdd)
      {
         var layers = NNVisualizerControl
                        .SelectedElements
                        .Select(e => e.GetLayerContainer())
                        .Distinct();

         Action<IEnumerable<LayerBase>> action = ((isAdd) ? new Action<IEnumerable<LayerBase>>(_designController.AddBias) : _designController.RemoveBias);

         NNVisualizerControl.SuspendAutoRedraw();
         action(layers);
         await NNVisualizerControl.ResumeAutoRedraw();
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
   }
}
