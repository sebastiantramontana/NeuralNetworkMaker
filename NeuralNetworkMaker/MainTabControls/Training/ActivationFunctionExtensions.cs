using NeuralNetwork.Model;
using NeuralNetwork.Model.Layers;
using NeuralNetworkNET.APIs.Enums;
using NeuralNetworkNET.Networks.Cost;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworkMaker.MainTabControls.Training
{
   public static class ActivationFunctionExtensions
   {
      public static IEnumerable<CostFunctionType> GetAllowedCostFunctions(this InputLayer inputLayer)
      {
         IEnumerable<CostFunctionType> costFunctions;

         if (inputLayer == null)
         {
            costFunctions = new CostFunctionType[] { };
         }
         else
         {
            var outputLayer = inputLayer.SearchOutputLayer();
            var actFunc = outputLayer.Nodes.GetSameForAll(n => n.ActivationFunction);

            if (actFunc.IsTheSame)
            {
               costFunctions = actFunc.Object.GetAllowedCostFunctions();
            }
            else if (outputLayer.Nodes.Any(n => n.ActivationFunction == ActivationFunction.None))
            {
               costFunctions = new CostFunctionType[] { };
            }
            else
            {
               costFunctions = new[] { CostFunctionType.Quadratic };
            }
         }

         return costFunctions;
      }

      private static ActivationFunction Map(this ActivationType activationType)
      {
         switch (activationType)
         {
            case ActivationType.Sigmoid:
               return ActivationFunction.Sigmoid;
            case ActivationType.Tanh:
            case ActivationType.LeCunTanh:
               return ActivationFunction.Tanh;
            case ActivationType.ReLU:
            case ActivationType.ELU:
            case ActivationType.AbsoluteReLU:
            case ActivationType.Softplus:
               return ActivationFunction.Relu;
            case ActivationType.LeakyReLU:
               return ActivationFunction.LeakyRelu;
            case ActivationType.Softmax:
               return ActivationFunction.Softmax;
            case ActivationType.Identity:
               return ActivationFunction.Linear;
            default:
               break;
         }

         throw new NotImplementedException($"Activation function not implemented: {activationType}");
      }

      private static IEnumerable<CostFunctionType> GetAllowedCostFunctions(this ActivationFunction activationFunction)
      {
         switch (activationFunction)
         {
            case ActivationFunction.None:
            case ActivationFunction.BinaryStep:
               return new CostFunctionType[] { };

            case ActivationFunction.Linear:
            case ActivationFunction.Relu:
            case ActivationFunction.LeakyRelu:
            case ActivationFunction.Tanh:
               return new[] { CostFunctionType.Quadratic };

            case ActivationFunction.Sigmoid:
               return new[]
               {
                        CostFunctionType.Quadratic,
                        CostFunctionType.CrossEntropy
               };
            case ActivationFunction.Softmax:
               return new[] { CostFunctionType.LogLikelyhood };
         }

         throw new NotImplementedException($"Cost function not implemented for the activation function: {activationFunction}");
      }
   }
}
