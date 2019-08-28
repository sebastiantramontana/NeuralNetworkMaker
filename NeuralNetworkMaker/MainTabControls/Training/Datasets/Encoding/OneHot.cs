using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworkMaker.MainTabControls.Training.Datasets.Encoding
{
   internal class OneHot : EncoderBase
   {
      internal OneHot() : base("One Hot")
      {

      }

      public override IEnumerable<AttributeValues> Encode(string originalColumnName, IEnumerable<string> categoricalValues)
      {
         var dictinctValues = categoricalValues
                           .Select(cv => cv.Trim())
                           .Where(cv => !string.IsNullOrWhiteSpace(cv))
                           .Distinct();

         var encodedValues = new Dictionary<string, ICollection<double>>();

         foreach (var distinctValue in dictinctValues)
         {
            encodedValues.Add(distinctValue, new List<double>(categoricalValues.Count()));
         }

         foreach (var categoricalValue in categoricalValues)
         {
            foreach (var distinctValue in dictinctValues)
            {
               var value = (distinctValue == categoricalValue) ? 1.0 : 0.0;
               encodedValues[distinctValue].Add(value);
            }
         }

         return encodedValues.Select(ev => new AttributeValues($"{originalColumnName}_{ev.Key}", ev.Value));
      }
   }
}
