using NeuralNetwork.Model;
using System;
using System.Collections.Generic;

namespace NeuralNetworkMaker.MainTabControls.Design.Selection.Resolvers
{
   internal abstract class SelectionTypeResolverBase : ISelectionTypeResolver
   {
      private readonly ISelectionTypeResolver _nextSelectionTypeSelector;

      protected SelectionTypeResolverBase(ISelectionTypeResolver nextSelectionTypeSelector)
      {
         _nextSelectionTypeSelector = nextSelectionTypeSelector;
      }

      protected SelectionType Pass(IEnumerable<Element> selectedElements)
      {
         if (_nextSelectionTypeSelector != null)
         {
            return _nextSelectionTypeSelector.Resolve(selectedElements);
         }

         throw new InvalidOperationException("No selection type found for selected items");
      }

      public abstract SelectionType Resolve(IEnumerable<Element> selectedElements);
   }
}
