using NeuralNetwork.Model;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworkMaker.MainTabControls.Design.Selection.Resolvers
{
   internal class ZeroSelectionTypeResolver : SelectionTypeResolverBase
   {
      internal ZeroSelectionTypeResolver(ISelectionTypeResolver nextSelectionTypeSelector) 
         : base(nextSelectionTypeSelector)
      {
      }

      public override SelectionType Resolve(IEnumerable<Element> selectedElements)
      {
         if (selectedElements == null || selectedElements.Count() == 0)
         {
            return SelectionType.None;
         }
         else
         {
            return Pass(selectedElements);
         }
      }
   }
}
