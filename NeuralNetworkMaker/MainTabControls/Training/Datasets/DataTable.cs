using System.Collections.Generic;

namespace NeuralNetworkMaker.MainTabControls.Training.Datasets
{
   public class DataTable<T>
   {
      public DataTable(IEnumerable<string> columns, IEnumerable<T[]> rows)
      {
         this.Columns = columns;
         this.Rows = rows;
      }

      public IEnumerable<string> Columns { get; }
      public IEnumerable<T[]> Rows { get; }
   }
}
