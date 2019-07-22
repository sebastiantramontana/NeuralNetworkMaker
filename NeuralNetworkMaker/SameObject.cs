namespace NeuralNetworkMaker
{
   public class SameObject<T>
   {
      public SameObject(bool isTheSame, T @object)
      {
         this.IsTheSame = isTheSame;
         this.Object = @object;
      }

      public bool IsTheSame { get; }
      public T Object { get; }
   }
}
