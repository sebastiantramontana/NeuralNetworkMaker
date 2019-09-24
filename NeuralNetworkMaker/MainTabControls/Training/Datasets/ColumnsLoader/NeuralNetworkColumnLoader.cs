using NeuralNetwork.Model.Layers;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworkMaker.MainTabControls.Training.Datasets.ColumnsLoader
{
   public class NeuralNetworkColumnLoader : ColumnLoaderBase
   {
      public NeuralNetworkColumnLoader(InputLayer inputLayer, IColumnLoader nextColumnLoader)
         : base(() => GetColumns(inputLayer), nextColumnLoader)
      {
      }

      private static IEnumerable<string> GetColumns(InputLayer inputLayer)
      {
         return inputLayer?
            .Nodes
            .Select(n => n.Id)
            .Concat(inputLayer?
               .SearchOutputLayer()
               .Nodes
               .Select(n => n.Id));
      }
   }
}
