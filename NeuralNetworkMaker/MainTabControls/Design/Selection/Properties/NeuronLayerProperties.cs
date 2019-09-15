using NeuralNetwork.Model;
using NeuralNetwork.Model.Layers;

namespace NeuralNetworkMaker.MainTabControls.Design.Selection.Properties
{
   public class NeuronLayerProperties : ObjectPropertiesBase
   {
      private readonly NeuronLayer _layer;

      public NeuronLayerProperties(NeuronLayer layer)
         :base("Neuron Layer")
      {
         _layer = layer;
      }

      public string Id
      {
         get => _layer.Id;
         set => _layer.Id = value;
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
               var sameActFunc = _layer.Nodes.GetSameForAll(n => n.ActivationFunction);
               return sameActFunc.IsTheSame ? sameActFunc.Object : (ActivationFunction?)null;
            }
         }
         set
         {
            _ActivationFunction = value;

            foreach (var node in _layer.Nodes)
            {
               node.ActivationFunction = _ActivationFunction ?? NeuralNetwork.Model.ActivationFunction.None;
            }
         }
      }
   }
}
