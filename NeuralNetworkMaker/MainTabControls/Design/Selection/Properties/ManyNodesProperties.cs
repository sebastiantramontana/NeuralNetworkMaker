using NeuralNetwork.Model;
using NeuralNetwork.Model.Nodes;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworkMaker.MainTabControls.Design.Selection.Properties
{
   public class ManyNodesProperties : ObjectPropertiesBase
   {
      private readonly IEnumerable<NodeBase> _nodes;

      public ManyNodesProperties(IEnumerable<NodeBase> nodes)
         :base("Many Nodes")
      {
         _nodes = nodes;
      }

      public double? OutputValue
      {
         get
         {
            var values = _nodes.GetSameForAll(n => n.OutputValue);
            return values.IsTheSame ? values.Object : null;
         }
         set
         {
            var outputValue = value;

            foreach (var node in _nodes)
            {
               node.OutputValue = outputValue;
            }
         }
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
               var actFuncs = _nodes.OfType<Neuron>().GetSameForAll(n => n.ActivationFunction);
               return actFuncs.IsTheSame ? actFuncs.Object : (ActivationFunction?)null;
            }
         }
         set
         {
            _ActivationFunction = value;

            var neurons = _nodes.OfType<Neuron>();
            foreach (var neuron in neurons)
            {
               neuron.ActivationFunction = _ActivationFunction ?? NeuralNetwork.Model.ActivationFunction.None;
            }
         }
      }
   }
}
