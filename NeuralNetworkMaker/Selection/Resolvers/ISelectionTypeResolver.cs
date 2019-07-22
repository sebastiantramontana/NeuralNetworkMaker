using NeuralNetwork.Model;
using System.Collections.Generic;

namespace NeuralNetworkMaker.Selection.Resolvers
{
   internal interface ISelectionTypeResolver
   {
      SelectionType Resolve(IEnumerable<Element> selectedElements);
   }
}
