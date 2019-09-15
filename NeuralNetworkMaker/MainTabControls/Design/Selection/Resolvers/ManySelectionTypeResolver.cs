using NeuralNetwork.Model;
using NeuralNetwork.Model.Layers;
using NeuralNetwork.Model.Nodes;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworkMaker.MainTabControls.Design.Selection.Resolvers
{
   internal class ManySelectionTypeResolver : SelectionTypeResolverBase
   {
      private readonly InputLayer _inputLayer;

      public ManySelectionTypeResolver(ISelectionTypeResolver nextSelectionTypeSelector, InputLayer inputLayer)
         : base(nextSelectionTypeSelector)
      {
         _inputLayer = inputLayer;
      }

      public override SelectionType Resolve(IEnumerable<Element> selectedElements)
      {
         if (selectedElements?.Count() < 2)
         {
            return Pass(selectedElements);
         }
         else if (selectedElements.All(e => e is LayerBase))
         {
            return DecideByLayers(selectedElements);
         }
         else if (selectedElements.All(e => e is NodeBase))
         {
            return DecideByNodes(selectedElements);
         }
         else if (selectedElements.All(e => e is Edge))
         {
            return SelectionType.ManyEdges;
         }
         else
         {
            return SelectionType.Mixed;
         }
      }

      private SelectionType DecideByLayers(IEnumerable<Element> selectedElements)
      {
         if (selectedElements.All(e => e is NeuronLayer))
         {
            if (selectedElements.Count() == _inputLayer.CountLayers() - 1)
            {
               return SelectionType.AllNeuronLayers;
            }
            else
            {
               return SelectionType.ManyHiddenLayers;
            }
         }
         else
         {
            return SelectionType.ManyLayersWithInputLayer;
         }
      }

      private SelectionType DecideByNodes(IEnumerable<Element> selectedElements)
      {
         if (selectedElements.Cast<NodeBase>().GetSameForAll(e => e.Layer).IsTheSame)
         {
            return SelectionType.NodesInLayer;
         }
         else
         {
            return SelectionType.NodesOnManyLayers;
         }
      }
   }
}
