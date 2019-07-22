using NeuralNetwork.Model;
using NeuralNetwork.Model.Layers;
using NeuralNetwork.Model.Nodes;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworkMaker.Selection.Resolvers
{
   internal class OneSelectionTypeResolver : SelectionTypeResolverBase
   {
      private readonly InputLayer _inputLayer;

      internal OneSelectionTypeResolver(ISelectionTypeResolver nextSelectionTypeSelector, InputLayer inputLayer)
         : base(nextSelectionTypeSelector)
      {
         _inputLayer = inputLayer;
      }

      public override SelectionType Resolve(IEnumerable<Element> selectedElements)
      {
         if (selectedElements?.Count() != 1)
         {
            return Pass(selectedElements);
         }

         var element = selectedElements.Single();

         if (element is LayerBase)
         {
            return DecideByLayer(element);
         }
         else if (element is NodeBase)
         {
            return SelectionType.SingleNode;
         }
         else
         {
            return SelectionType.SingleEdge;
         }
      }

      private SelectionType DecideByLayer(Element element)
      {
         if (element == _inputLayer)
         {
            return SelectionType.InputLayer;
         }
         else if (element == _inputLayer?.SearchOutputLayer())
         {
            return SelectionType.OutputLayer;
         }
         else
         {
            return SelectionType.SingleHiddenLayer;
         }
      }
   }
}
