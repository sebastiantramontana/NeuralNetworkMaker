using System.Collections.Generic;

namespace NeuralNetworkMaker.MainTabControls.Training.Datasets.Encoding
{
   internal abstract class EncoderBase : IEncoder
   {
      private protected EncoderBase(string name)
      {
         this.Name = name;
      }

      public string Name { get; }

      public abstract IEnumerable<AttributeValues> Encode(string originalColumnName, IEnumerable<string> categoricalValues);
   }
}
