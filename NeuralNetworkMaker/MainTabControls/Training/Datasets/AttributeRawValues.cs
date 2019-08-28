using System.Collections.Generic;

namespace NeuralNetworkMaker.MainTabControls.Training.Datasets
{
   public class AttributeRawValues
   {
      public AttributeRawValues(string attribute, IEnumerable<string> values)
      {
         this.Attribute = attribute;
         this.Values = values;
      }

      public string Attribute { get; }
      public IEnumerable<string> Values { get; }
   }
}
