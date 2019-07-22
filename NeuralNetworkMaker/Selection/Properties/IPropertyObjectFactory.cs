namespace NeuralNetworkMaker.Selection.Properties
{
   public interface IPropertyObjectFactory
   {
      object GetObject(SelectionType selectionType);
   }
}