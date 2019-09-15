namespace NeuralNetworkMaker.MainTabControls.Design.Selection.Properties
{
   public interface IPropertyObjectFactory
   {
      object GetObject(SelectionType selectionType);
   }
}