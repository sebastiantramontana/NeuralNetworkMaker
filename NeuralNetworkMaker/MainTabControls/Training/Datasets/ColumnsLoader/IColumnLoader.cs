using System.Collections.Generic;

namespace NeuralNetworkMaker.MainTabControls.Training.Datasets.ColumnsLoader
{
   public interface IColumnLoader
   {
      IEnumerable<string> GetColumns();
   }
}
