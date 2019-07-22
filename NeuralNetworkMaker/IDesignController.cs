using NeuralNetwork.Model.Layers;
using NeuralNetwork.Model.Nodes;
using System;
using System.Collections.Generic;

namespace NeuralNetworkMaker
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