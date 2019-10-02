using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeuralNetworkMaker.MainTabControls.Training.Datasets.ColumnsLoader
{
   public class ColumnLoaderBase : IColumnLoader
   {
      private readonly Func<IEnumerable<string>> _getColumnsFunc;
      private readonly IColumnLoader _nextColumnLoader;

      protected ColumnLoaderBase(Func<IEnumerable<string>> getColumnsFunc, IColumnLoader nextColumnLoader)
      {
         _getColumnsFunc = getColumnsFunc;
         _nextColumnLoader = nextColumnLoader;
      }

      public IEnumerable<string> GetColumns()
      {
         IEnumerable<string> columns = _getColumnsFunc();

         if (columns == null || columns.Count() == 0)
         {
            columns = _nextColumnLoader?.GetColumns();
         }

         return columns;
      }
   }
}
