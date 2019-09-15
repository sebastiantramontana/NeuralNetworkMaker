using System;
using System.Collections.Generic;
using System.Linq;
using NeuralNetwork.Model;
using NeuralNetwork.Model.Layers;
using NeuralNetwork.Model.Nodes;
using NeuralNetwork.Visualizer;
using NeuralNetworkMaker.MainTabControls.Design.Selection;
using NeuralNetworkMaker.MainTabControls.Design.Selection.Resolvers;

namespace NeuralNetworkMaker
{
   public static class Extensions
   {
      public static IEnumerable<LayerBase> GetLayerContainers(IEnumerable<Element> elements)
      {
         return elements
         .Select(e => e.GetLayerContainer())
         .OfType<LayerBase>()
         .Distinct();
      }

      public static LayerBase GetLayerContainer(this Element element)
      {
         LayerBase layerContainer = null;

         switch (element)
         {
            case LayerBase layer:
               layerContainer = layer;
               break;
            case NodeBase node:
               layerContainer = node.Layer;
               break;
            default:
               layerContainer = null;
               break;
         }

         return layerContainer;
      }

      public static SameObject<TResult> GetSameForAll<TElement, TResult>(this IEnumerable<TElement> elements, Func<TElement, TResult> predicate)
      {
         var distinctElements = elements?.Select(predicate).Distinct();

         bool isTheSame = distinctElements != null && distinctElements.Count() == 1;
         TResult result = isTheSame ? distinctElements.Single() : default;

         return new SameObject<TResult>(isTheSame, result);
      }

      public static SelectionType GetSelectionType(this NeuralNetworkVisualizerControl neuralNetworkVisualizerControl)
      {
         var selector = SelectionTypeResolverFactory.GetInstance(neuralNetworkVisualizerControl.InputLayer);
         return selector.Resolve(neuralNetworkVisualizerControl.SelectedElements);
      }
   }
}
