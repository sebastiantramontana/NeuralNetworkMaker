using System;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworkMaker.MainTabControls.Training.Datasets.Encoding
{
   internal class Binary : EncoderBase
   {
      internal Binary() : base("Binary")
      {
      }

      public override IEnumerable<AttributeValues> Encode(string originalColumnName, IEnumerable<string> categoricalValues)
      {
         var distinctValues = categoricalValues
                           .Select(cv => cv.Trim())
                           .Where(cv => !string.IsNullOrWhiteSpace(cv))
                           .Distinct();

         var columnCount = CalculateColumnCount(distinctValues.Count());

         var valuesDict = distinctValues
                           .Select((dv, i) => new KeyValuePair<string, int>(dv, i))
                           .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

         var encodedValues = new Dictionary<string, ICollection<double>>();

         for (int i = 0; i < columnCount; i++)
         {
            encodedValues.Add($"{originalColumnName}_{i}", new List<double>(categoricalValues.Count()));
         }

         foreach (var catValue in categoricalValues)
         {
            for (int i = 0; i < columnCount; i++)
            {
               var value = valuesDict[catValue] & 1;
               encodedValues.ElementAt(i).Value.Add(value);
            }
         }

         return encodedValues.Select(ev => new AttributeValues(ev.Key, ev.Value));
      }

      private int CalculateColumnCount(int distinctValues)
      {
         var log = Math.Log(distinctValues, 2);
         var count = (int)Math.Ceiling(log);

         return count;
      }
   }
}
