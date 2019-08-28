using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
