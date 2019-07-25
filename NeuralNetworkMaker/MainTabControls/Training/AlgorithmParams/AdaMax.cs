﻿using NeuralNetworkNET.APIs;
using NeuralNetworkNET.APIs.Interfaces;

namespace NeuralNetworkMaker.MainTabControls.Training.AlgorithmParams
{
    public class AdaMax : IAlgorithmParams
   {
        public float Eta { get; set; } = 0.002f;
        public float Beta1 { get; set; } = 0.9f;
        public float Beta2 { get; set; } = 0.999f;

        public ITrainingAlgorithmInfo GetTrainingAlgorithm()
        {
            return TrainingAlgorithms.AdaMax(this.Eta, this.Beta1, this.Beta2);
        }
    }
}
