using System.Collections.Generic;

namespace NeuralNetworkMaker.MainTabControls.Training.Datasets.Encoding
{
   public interface IEncoder
   {
      IEnumerable<AttributeValues> Encode(string originalColumnName, IEnumerable<string> categoricalValues);
   }
}
