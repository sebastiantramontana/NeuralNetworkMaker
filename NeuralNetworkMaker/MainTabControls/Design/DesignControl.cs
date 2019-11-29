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
         if (this.NNVisualizerControl == null)
            return;

         _designController = new DesignController();
         _designButtonsControlLogic = new DesignButtonsControlLogic(this.NNVisualizerControl, btnAddLayer, btnRemoveSelectedLayers, btnAddNode, btnRemoveSelectedNodes, btnToggleBias);
         _propertyObjectFactory = new PropertyObjectFactory(this.NNVisualizerControl);
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

      public void SelectElement<TElement>()
        where TElement : Element
      {
         var selectionType = this.NNVisualizerControl.GetSelectionType();

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

         var selectionType = this.NNVisualizerControl.GetSelectionType();
         _designButtonsControlLogic.EnableDesign(selectionType);
         PropertyGridDesign.SelectedObject = _propertyObjectFactory.GetObject(selectionType);
      }

      private async Task InsertLayer()
      {
         var lastElement = this.NNVisualizerControl.SelectedElements.LastOrDefault();
         var layer = lastElement?.GetLayerContainer();

         this.NNVisualizerControl.SuspendAutoRedraw();
         _designController.AddLayer(layer);
         await this.NNVisualizerControl.ResumeAutoRedraw();
      }

      private async Task RemoveSelectedLayers()
      {
         var layersToRemove = this.NNVisualizerControl
                              .SelectedElements
                              .Select(e => e.GetLayerContainer())
                              .OfType<NeuronLayer>()
                              .Distinct();

         this.NNVisualizerControl.SuspendAutoRedraw();
         _designController.RemoveLayers(layersToRemove);
         await this.NNVisualizerControl.ResumeAutoRedraw();
      }

      private async Task AddNodes()
      {
         var layers = this.NNVisualizerControl
                        .SelectedElements
                        .Select(e => e.GetLayerContainer())
                        .Distinct();

         this.NNVisualizerControl.SuspendAutoRedraw();
         _designController.AddNodes(layers);
         await this.NNVisualizerControl.ResumeAutoRedraw();
      }

      private async Task RemoveSelectedNodes()
      {
         var nodesToRemove = this.NNVisualizerControl
                        .SelectedElements
                        .OfType<NodeBase>()
                        .Distinct();

         this.NNVisualizerControl.SuspendAutoRedraw();
         _designController.RemoveNodes(nodesToRemove);
         await this.NNVisualizerControl.ResumeAutoRedraw();
      }

      private async Task ToggleBias(bool isAdd)
      {
         var layers = this.NNVisualizerControl
                        .SelectedElements
                        .Select(e => e.GetLayerContainer())
                        .Distinct();

         Action<IEnumerable<LayerBase>> action = ((isAdd) ? new Action<IEnumerable<LayerBase>>(_designController.AddBias) : _designController.RemoveBias);

         this.NNVisualizerControl.SuspendAutoRedraw();
         action(layers);
         await this.NNVisualizerControl.ResumeAutoRedraw();
      }
   }
}
