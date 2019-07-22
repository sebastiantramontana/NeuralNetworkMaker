using NeuralNetwork.Model;
using NeuralNetwork.Model.Layers;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworkMaker.Selection.Properties
{
   public class ManyNeuronLayersProperties : ObjectPropertiesBase
   {
      private readonly IEnumerable<NeuronLayer> _layers;

      public ManyNeuronLayersProperties(IEnumerable<NeuronLayer> layers)
         : base("Many Layers")
      {
         _layers = layers;
      }

      private ActivationFunction? _ActivationFunction = null;
      public ActivationFunction? ActivationFunction
      {
         get
         {
            if (_ActivationFunction.HasValue)
            {
               return _ActivationFunction.Value;
            }
            else
            {
               var sameActFunc = _layers.SelectMany(l => l.Nodes).GetSameForAll(n => n.ActivationFunction);
               return sameActFunc.IsTheSame ? sameActFunc.Object : (ActivationFunction?)null;
            }
         }
         set
         {
            _ActivationFunction = value;

            foreach (var layer in _layers)
            {
               foreach (var node in layer.Nodes)
               {
                  node.ActivationFunction = _ActivationFunction ?? NeuralNetwork.Model.ActivationFunction.None;
               }
            }
         }
      }
   }
}
