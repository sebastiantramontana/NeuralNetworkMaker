using NeuralNetworkNET.APIs;
using NeuralNetworkNET.APIs.Interfaces;

namespace NeuralNetworkMaker.MainTabControls.Training.AlgorithmParams
{
    public class Momentum : StochasticGradientDescent
    {
        public float Coefficient { get; set; } = 0.1f;

        public override ITrainingAlgorithmInfo GetTrainingAlgorithm()
        {
            return TrainingAlgorithms.Momentum(this.LearningRate, this.Regularization, this.Coefficient);
        }
    }
}
