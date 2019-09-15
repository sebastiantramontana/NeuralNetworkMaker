using System.Collections.Generic;

namespace NeuralNetworkMaker.MainTabControls.Training.Datasets
{
   public class AttributeValues
   {
      public AttributeValues(string attribute, IEnumerable<double> values)
      {
         this.Attribute = attribute;
         this.Values = values;
      }

      public string Attribute { get; }
      public IEnumerable<double> Values { get; }
   }
}
