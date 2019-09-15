using NeuralNetwork.Model.Layers;

namespace NeuralNetworkMaker.MainTabControls.Design.Selection.Resolvers
{
   internal class SelectionTypeResolverFactory
   {
      internal static ISelectionTypeResolver GetInstance(InputLayer inputLayer)
      {
         var manySelector = new ManySelectionTypeResolver(null, inputLayer);
         var oneSelector = new OneSelectionTypeResolver(manySelector, inputLayer);
         var zeroSelector = new ZeroSelectionTypeResolver(oneSelector);

         return zeroSelector;
      }
   }
}
