using NeuralNetworkNET.APIs;
using NeuralNetworkNET.APIs.Interfaces;
using System.ComponentModel;

namespace NeuralNetworkMaker.MainTabControls.Training.AlgorithmParams
{
    public class StochasticGradientDescent : IAlgorithmParams
   {
        public float LearningRate { get; set; } = 0.01f;
        public float Regularization { get; set; } = 0f;

        public virtual ITrainingAlgorithmInfo GetTrainingAlgorithm()
        {
            return TrainingAlgorithms.StochasticGradientDescent(this.LearningRate, this.Regularization);
        }
    }
}
