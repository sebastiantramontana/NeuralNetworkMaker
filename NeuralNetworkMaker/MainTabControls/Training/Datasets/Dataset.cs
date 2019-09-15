using System.Collections.Generic;

namespace NeuralNetworkMaker.MainTabControls.Training.Datasets
{
   public class Dataset
   {
      public Dataset(IEnumerable<string> inputAttributes, IEnumerable<string> outputLabels, IEnumerable<double[]> training, IEnumerable<double[]> validation, IEnumerable<double[]> test)
      {
         this.InputAttributes = inputAttributes;
         this.OutputLabels = outputLabels;
         this.Training = training;
         this.Validation = validation;
         this.Test = test;
      }

      public IEnumerable<string> InputAttributes { get; }
      public IEnumerable<string> OutputLabels { get; }
      public IEnumerable<double[]> Training { get; }
      public IEnumerable<double[]> Validation { get; }
      public IEnumerable<double[]> Test { get; }
   }
}
