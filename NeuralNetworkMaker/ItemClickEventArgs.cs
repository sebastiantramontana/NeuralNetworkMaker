using System;

namespace NeuralNetworkMaker
{
   public class ItemClickEventArgs : EventArgs
   {
      public ItemClickEventArgs(string key)
      {
         this.Key = key;
      }

      public string Key { get; }
   }
}