using System;
using System.Collections.Generic;
using System.Linq;

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

      public (IEnumerable<T[]> Training, IEnumerable<T[]> Validation, IEnumerable<T[]> Test) SplitRows(int trainingPercent, int validationPercent, int testPercent)
      {
         if (trainingPercent + validationPercent + testPercent != 100)
            throw new InvalidOperationException("The sum of percents must be 100");

         var training = GetPercentRows(0, trainingPercent);
         var validation = GetPercentRows(training.Count(), validationPercent);
         var test = GetPercentRows(validation.Count(), testPercent);

         return (training, validation, test);
      }

      private IEnumerable<T[]> GetPercentRows(int skip, int percent)
      {
         var rowsCount = this.Rows.Count();

         double partCount = rowsCount * percent / 100;
         var partRows = this.Rows.Skip(skip).Take((int)Math.Ceiling(partCount));

         return partRows;
      }
   }
}
