using NeuralNetwork.Model.Layers;
using NeuralNetwork.Model.Nodes;
using NeuralNetwork.Visualizer;
using System.Linq;

namespace NeuralNetworkMaker.Selection.Properties
{
   public class PropertyObjectFactory : IPropertyObjectFactory
   {
      private readonly NeuralNetworkVisualizerControl _neuralNetworkVisualizerControl;

      public PropertyObjectFactory(NeuralNetworkVisualizerControl neuralNetworkVisualizerControl)
      {
         _neuralNetworkVisualizerControl = neuralNetworkVisualizerControl;
      }

      public object GetObject(SelectionType selectionType)
      {
         object obj = null;

         switch (selectionType)
         {
            case SelectionType.InputLayer:
            case SelectionType.SingleNode:
            case SelectionType.SingleEdge:
               obj = _neuralNetworkVisualizerControl.SelectedElements.Single();
               break;
            case SelectionType.SingleHiddenLayer:
            case SelectionType.OutputLayer:
               obj = new NeuronLayerProperties(_neuralNetworkVisualizerControl.SelectedElements.Single() as NeuronLayer);
               break;
            case SelectionType.NodesOnManyLayers:
            case SelectionType.NodesInLayer:
               obj = new ManyNodesProperties(_neuralNetworkVisualizerControl.SelectedElements.Cast<NodeBase>());
               break;
            case SelectionType.ManyLayersWithInputLayer:
            case SelectionType.ManyHiddenLayers:
            case SelectionType.AllNeuronLayers:
               obj = new ManyNeuronLayersProperties(_neuralNetworkVisualizerControl.SelectedElements.OfType<NeuronLayer>());
               break;
            case SelectionType.ManyEdges:
               obj = new ManyEdgesProperties(_neuralNetworkVisualizerControl.SelectedElements.Cast<Edge>());
               break;
            case SelectionType.None:
            case SelectionType.Mixed:
            default:
               break;
         }

         return obj;
      }
   }
}
