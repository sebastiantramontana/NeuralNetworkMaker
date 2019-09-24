using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworkMaker.MainTabControls.Training.Datasets.ColumnsLoader
{
   public class DatasetByRowColumnLoader : ColumnLoaderBase
   {
      public DatasetByRowColumnLoader(DataTable<string> dataTable, IColumnLoader nextColumnLoader)
         : base(() => GetColumns(dataTable), nextColumnLoader)
      {
      }

      private static IEnumerable<string> GetColumns(DataTable<string> dataTable)
      {
         return dataTable
            .Rows
            .FirstOrDefault()?
            .Select((row, index) => $"Column_{index}");
      }
   }
}
