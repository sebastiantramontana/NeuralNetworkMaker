using System;

namespace NeuralNetworkMaker.MainTabControls.Training.Datasets.ColumnsLoader
{
   public class InvalidColumnLoader : ColumnLoaderBase
   {
      public InvalidColumnLoader()
         : base(() => throw new InvalidOperationException("Unable to load columns"), null)
      {
      }
   }
}
