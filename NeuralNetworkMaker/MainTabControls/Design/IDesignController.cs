using System.Collections.Generic;
using NeuralNetwork.Model.Layers;
using NeuralNetwork.Model.Nodes;

namespace NeuralNetworkMaker.MainTabControls.Design
{
   public interface IDesignController
   {
      void AddLayer(LayerBase fromLayer);
      void RemoveLayers(IEnumerable<NeuronLayer> layers);
      void AddNodes(IEnumerable<LayerBase> layers);
      void RemoveNodes(IEnumerable<NodeBase> nodes);
      void AddBias(IEnumerable<LayerBase> layers);
      void RemoveBias(IEnumerable<LayerBase> layers);
   }
}