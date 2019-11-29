namespace NeuralNetworkMaker
{
   public class SameObject<T>
   {
      public SameObject(bool isTheSame, T value)
      {
         this.IsTheSame = isTheSame;
         this.Value = value;
      }

      public bool IsTheSame { get; }
      public T Value { get; }
   }
}
