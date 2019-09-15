namespace NeuralNetworkMaker.MainTabControls.Design.Selection.Properties
{
   public abstract class ObjectPropertiesBase
   {
      protected ObjectPropertiesBase(string selection)
      {
         this.Selection = selection;
      }

      public string Selection { get; }
   }
}
