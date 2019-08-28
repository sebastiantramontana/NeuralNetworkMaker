using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkMaker.MainTabControls.Training.Datasets.Encoding
{
   public static class Encoders
   {
      public static IEnumerable<IEncoder> All { get; } = new IEncoder[]
      {
         new OneHot(),
         new Binary()
      };
   }
}
