namespace NeuralNetworkMaker.MainTabControls.Training.Datasets.ColumnsLoader
{
   public class DatasetColumnLoader : ColumnLoaderBase
   {
      public DatasetColumnLoader(DataTable<string> dataTable, IColumnLoader nextColumnLoader)
         : base(() => dataTable.Columns, nextColumnLoader)
      {
      }
   }
}
