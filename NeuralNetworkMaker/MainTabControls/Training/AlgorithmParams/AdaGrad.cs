﻿using NeuralNetworkNET.APIs;
using NeuralNetworkNET.APIs.Interfaces;

namespace NeuralNetworkMaker.MainTabControls.Training.AlgorithmParams
{
    public class AdaGrad : IAlgorithmParams
   {
        public float Eta { get; set; } = 0.01f;
        public float Lambda { get; set; } = 0f;
        public float Epsilon { get; set; } = 1E-08f;

        public ITrainingAlgorithmInfo GetTrainingAlgorithm()
        {
            return TrainingAlgorithms.AdaGrad(this.Eta, this.Lambda, this.Epsilon);
        }
    }
}
