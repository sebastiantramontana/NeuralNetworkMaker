using NeuralNetwork.Model;
using NeuralNetwork.Model.Layers;
using NeuralNetwork.Model.Nodes;
using NeuralNetwork.Visualizer;
using NeuralNetworkMaker.MainTabControls.Design.Selection;
using NeuralNetworkMaker.MainTabControls.Design.Selection.Resolvers;
using System;

namespace NeuralNetworkMaker.MainTabControls.Design
{
   public static class SelectionExtensions
   {
      public static LayerBase GetLayerContainer(this Element element)
      {
         var layerContainer = element switch
         {
            LayerBase layer => layer,
            NodeBase node => node.Layer,
            _ => null,
         };

         return layerContainer;
      }

      public static SelectionType GetSelectionType(this NeuralNetworkVisualizerControl neuralNetworkVisualizerControl)
      {
         if (neuralNetworkVisualizerControl is null)
            throw new ArgumentNullException(nameof(neuralNetworkVisualizerControl));


         var selector = SelectionTypeResolverFactory.GetInstance(neuralNetworkVisualizerControl.InputLayer);
         return selector.Resolve(neuralNetworkVisualizerControl.SelectedElements);
      }
   }
}
