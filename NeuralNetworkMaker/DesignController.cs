using NeuralNetwork.Model.Layers;
using NeuralNetwork.Model.Nodes;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworkMaker
{
   public class DesignController : IDesignController
   {
      private int _newLayerNumber = 0;

      public void AddBias(IEnumerable<LayerBase> layers)
      {
         foreach (var layer in layers)
         {
            if (layer.Next != null && layer.Bias == null)
            {
               layer.Bias = new Bias($"{layer.Id}_Bias");
            }
         }
      }

      public void RemoveBias(IEnumerable<LayerBase> layers)
      {
         foreach (var layer in layers)
         {
            layer.Bias = null;
         }
      }

      public void AddLayer(LayerBase fromLayer)
      {
         if (fromLayer == null)
         {
            return;
         }

         var nodesToCopy = fromLayer.GetAllNodes().ToArray();
         var newLayer = new NeuronLayer("NewLayer_" + (++_newLayerNumber));

         for (int i = 0; i < nodesToCopy.Length; i++)
         {
            var neuron = new Neuron(BuildNodeId(newLayer.Id, i));
            newLayer.AddNode(neuron);
         }

         fromLayer.Connect(newLayer);
      }

      public void AddNodes(IEnumerable<LayerBase> layers)
      {
         foreach (var layer in layers)
         {
            var id = BuildNodeId(layer.Id, layer.GetAllNodes().Count());

            if (layer is NeuronLayer neuronLayer)
            {
               neuronLayer.AddNode(new Neuron(id));
            }
            else
            {
               var inputLayer = layer as InputLayer;
               inputLayer.AddNode(new Input(id));
            }
         }
      }

      public void RemoveLayers(IEnumerable<NeuronLayer> layersToRemove)
      {
         foreach (var layer in layersToRemove)
         {
            layer.Disconnect();
         }
      }

      public void RemoveNodes(IEnumerable<NodeBase> nodes)
      {
         foreach (var node in nodes)
         {
            var layer = node.Layer;
            layer.RemoveNode(node.Id);
         }
      }

      private string BuildNodeId(string layerId, int nodeIndex)
      {
         return $"{layerId}_{nodeIndex}";
      }
   }
}
