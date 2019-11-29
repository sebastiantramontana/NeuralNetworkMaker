using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NeuralNetwork.Model.Layers;
using NeuralNetwork.Model.Nodes;
using NeuralNetwork.Visualizer;
using NeuralNetworkMaker.MainTabControls.Design.Selection;

namespace NeuralNetworkMaker.MainTabControls.Design
{
   public class DesignButtonsControlLogic : IDesignButtonsControlLogic
   {
      private readonly NeuralNetworkVisualizerControl _neuralNetworkVisualizerControl;
      private readonly ToolStripButton _addLayerControl;
      private readonly ToolStripButton _removeSelectedLayersControl;
      private readonly ToolStripButton _addNodeControl;
      private readonly ToolStripButton _removeSelectedNodesControl;
      private readonly ToolStripButton _toggleBias;

      public DesignButtonsControlLogic(NeuralNetworkVisualizerControl neuralNetworkVisualizerControl, ToolStripButton addLayerControl, ToolStripButton removeSelectedLayersControl, ToolStripButton addNodeControl, ToolStripButton removeSelectedNodesControl, ToolStripButton toggleBias)
      {
         _neuralNetworkVisualizerControl = neuralNetworkVisualizerControl;
         _addLayerControl = addLayerControl;
         _removeSelectedLayersControl = removeSelectedLayersControl;
         _addNodeControl = addNodeControl;
         _removeSelectedNodesControl = removeSelectedNodesControl;
         _toggleBias = toggleBias;
      }

      public void EnableDesign(SelectionType selectionType)
      {
         switch (selectionType)
         {
            case SelectionType.None:
            case SelectionType.Mixed:
            case SelectionType.SingleEdge:
            case SelectionType.ManyEdges:
               DisableAll();
               break;
            case SelectionType.SingleNode:
               EnableBySingleNode();
               break;
            case SelectionType.NodesOnManyLayers:
               EnableByNodesOnManyLayers();
               break;
            case SelectionType.NodesInLayer:
               EnableByNodesInLayer();
               break;
            case SelectionType.InputLayer:
               EnableByInputLayer();
               break;
            case SelectionType.SingleHiddenLayer:
            case SelectionType.ManyHiddenLayers:
               EnableByWhateverHiddenLayer();
               break;
            case SelectionType.OutputLayer:
               EnableByOutputLayer();
               break;
            case SelectionType.ManyLayersWithInputLayer:
            case SelectionType.AllNeuronLayers:
               ManyLayersWithEndingLayers();
               break;
            default:
               throw new NotImplementedException($"Selection type not implemented: {selectionType}");
         }
      }

      private void DisableAll()
      {
         _addLayerControl.Enabled =
         _addNodeControl.Enabled =
         _removeSelectedLayersControl.Enabled =
         _removeSelectedNodesControl.Enabled =
         _toggleBias.Enabled = false;
      }

      private void EnableBySingleNode()
      {
         var selectedNode = _neuralNetworkVisualizerControl.SelectedElements.Single() as NodeBase;
         var inputLayer = _neuralNetworkVisualizerControl.InputLayer;

         EnableToggleBias(new[] { selectedNode });

         _addLayerControl.Enabled = _addNodeControl.Enabled = true;
         _removeSelectedLayersControl.Enabled = inputLayer.CountLayers() > 2 && selectedNode.Layer != inputLayer;
         _removeSelectedNodesControl.Enabled = LayerCanRemoveNodes(selectedNode.Layer, 1);
      }

      private void EnableByNodesOnManyLayers()
      {
         var selectedNodes = _neuralNetworkVisualizerControl.SelectedElements.Cast<NodeBase>();
         var groupedNodes = selectedNodes.GroupBy(n => n.Layer);
         var containerLayers = groupedNodes.Select(g => g.Key);
         var inputLayer = _neuralNetworkVisualizerControl.InputLayer;

         EnableToggleBias(containerLayers);

         _addLayerControl.Enabled = _addNodeControl.Enabled = true;
         _removeSelectedLayersControl.Enabled = (inputLayer.CountLayers() - containerLayers.Count()) > 2 && !containerLayers.Contains(inputLayer);
         _removeSelectedNodesControl.Enabled = groupedNodes.All(g => LayerCanRemoveNodes(g.Key, g.Count()));
      }

      private void EnableByNodesInLayer()
      {
         var selectedNodes = _neuralNetworkVisualizerControl.SelectedElements.Cast<NodeBase>();
         var layer = selectedNodes.First().Layer;
         var inputLayer = _neuralNetworkVisualizerControl.InputLayer;

         EnableToggleBias(new[] { layer });

         _addLayerControl.Enabled = _addNodeControl.Enabled = true;
         _removeSelectedLayersControl.Enabled = inputLayer.CountLayers() > 2 && layer != inputLayer;
         _removeSelectedNodesControl.Enabled = LayerCanRemoveNodes(layer, selectedNodes.Count());
      }

      private void EnableByInputLayer()
      {
         var layer = _neuralNetworkVisualizerControl.SelectedElements.Cast<LayerBase>().Single();
         EnableToggleBias(new[] { layer });

         _addLayerControl.Enabled = _addNodeControl.Enabled = true;
         _removeSelectedLayersControl.Enabled = _removeSelectedNodesControl.Enabled = false;
      }

      private void EnableByWhateverHiddenLayer()
      {
         var layers = _neuralNetworkVisualizerControl.SelectedElements.Cast<LayerBase>();
         EnableToggleBias(layers);

         _addLayerControl.Enabled = _addNodeControl.Enabled = _removeSelectedLayersControl.Enabled = true;
         _removeSelectedNodesControl.Enabled = false;
      }

      private void EnableByOutputLayer()
      {
         var inputLayer = _neuralNetworkVisualizerControl.InputLayer;

         EnableToggleBias(new[] { _neuralNetworkVisualizerControl.InputLayer.SearchOutputLayer() });

         _addLayerControl.Enabled = _addNodeControl.Enabled = true;
         _removeSelectedLayersControl.Enabled = inputLayer.CountLayers() > 2;
         _removeSelectedNodesControl.Enabled = false;
      }

      private void ManyLayersWithEndingLayers()
      {
         var layers = _neuralNetworkVisualizerControl.SelectedElements.Cast<LayerBase>();
         EnableToggleBias(layers);

         _addLayerControl.Enabled = _addNodeControl.Enabled = true;
         _removeSelectedLayersControl.Enabled = _removeSelectedNodesControl.Enabled = false;
      }

      private static bool LayerCanRemoveNodes(LayerBase layer, int nodesToRemove)
      {
         return (layer.GetAllNodes().Count() - ((layer.Bias != null) ? 1 : 0) - nodesToRemove) > 0;
      }

      private void EnableToggleBias(IEnumerable<LayerBase> layers)
      {
         var allBiasNotNull = layers.All(l => l.Bias != null);
         _toggleBias.Checked = allBiasNotNull;
         _toggleBias.Enabled = layers.All(l => l.Next != null) && (allBiasNotNull || layers.All(l => l.Bias == null));
      }

      private void EnableToggleBias(IEnumerable<NodeBase> nodes)
      {
         EnableToggleBias(nodes.Select(n => n.Layer));
      }
   }
}
