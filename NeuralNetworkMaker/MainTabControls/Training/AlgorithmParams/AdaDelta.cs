﻿using NeuralNetworkNET.APIs;
using NeuralNetworkNET.APIs.Interfaces;

namespace NeuralNetworkMaker.MainTabControls.Training.AlgorithmParams
{
    public class AdaDelta : IAlgorithmParams
   {
        public float Rho { get; set; } = 0.95f;
        public float Epsilon { get; set; } = 1E-08f;
        public float L2 { get; set; } = 0f;

        public ITrainingAlgorithmInfo GetTrainingAlgorithm()
        {
            return TrainingAlgorithms.AdaDelta(this.Rho, this.Epsilon, this.L2);
        }
    }
}
