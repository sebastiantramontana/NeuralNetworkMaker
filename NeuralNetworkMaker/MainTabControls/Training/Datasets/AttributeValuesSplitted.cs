using System.Collections.Generic;

namespace NeuralNetworkMaker.MainTabControls.Training.Datasets
{
   public class AttributeValuesSplitted
   {
      public string Attribute { get; }
      public IEnumerable<double> Training { get; }
      public IEnumerable<double> Validation { get; }
      public IEnumerable<double> Test { get; }
   }
}
