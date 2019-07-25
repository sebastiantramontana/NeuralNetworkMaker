using NeuralNetworkNET.APIs.Interfaces;

namespace NeuralNetworkMaker.MainTabControls.Training.AlgorithmParams
{
    public interface IAlgorithmParams
   {
        ITrainingAlgorithmInfo GetTrainingAlgorithm();
    }
}