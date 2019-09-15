using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeuralNetwork.Model;
using NeuralNetwork.Model.Layers;
using NeuralNetwork.Model.Nodes;
using NeuralNetwork.Visualizer;
using NeuralNetwork.Visualizer.Selection;
using NeuralNetworkMaker.MainTabControls.Design.Selection.Properties;

namespace NeuralNetworkMaker.MainTabControls.Design
{
   public partial class DesignControl : UserControl
   {
      private IDesignController _designController;
      private IDesignButtonsControlLogic _designButtonsControlLogic;
      private IPropertyObjectFactory _propertyObjectFactory;
      public DesignControl()
      {
         InitializeComponent();
      }

      private void DesignControl_Load(object sender, EventArgs e)
      {
         if (NNVisualizerControl == null)
            return;

         _designController = new DesignController();
         _designButtonsControlLogic = new DesignButtonsControlLogic(NNVisualizerControl, btnAddLayer, btnRemoveSelectedLayers, btnAddNode, btnRemoveSelectedNodes, btnToggleBias);
         _propertyObjectFactory = new PropertyObjectFactory(NNVisualizerControl);
      }

      private NeuralNetworkVisualizerControl _visualizerControl;
      [Browsable(false)]
      public NeuralNetworkVisualizerControl NNVisualizerControl
      {
         get => _visualizerControl;
         set
         {
            _visualizerControl = value;

            if (_visualizerControl?.InputLayer != null)
               _visualizerControl.InputLayer.PropertyChanged += InputLayer_PropertyChanged;
         }
      }

      public void SelectElement<TElement>(SelectionEventArgs<TElement> e)
        where TElement : Element
      {
         var selectionType = NNVisualizerControl.GetSelectionType();

         _designButtonsControlLogic.EnableDesign(selectionType);
         PropertyGridDesign.SelectedObject = _propertyObjectFactory.GetObject(selectionType);
      }

      private void InputLayer_PropertyChanged(object sender, PropertyChangedEventArgs e)
      {

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
   }
}
