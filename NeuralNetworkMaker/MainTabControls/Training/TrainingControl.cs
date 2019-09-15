using NeuralNetwork.Visualizer;
using NeuralNetworkMaker.MainTabControls.Training.AlgorithmParams;
using NeuralNetworkMaker.MainTabControls.Training.Datasets;
using NeuralNetworkMaker.Preferences.Extensions;
using NeuralNetworkNET.APIs.Enums;
using NeuralNetworkNET.SupervisedLearning.Algorithms;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace NeuralNetworkMaker.MainTabControls.Training
{
   public partial class TrainingControl : UserControl
   {
      public TrainingControl()
      {
         InitializeComponent();
      }

      private NeuralNetworkVisualizerControl _visualizerControl;
      [Browsable(false)]
      public NeuralNetworkVisualizerControl VisualizerControl
      {
         get => _visualizerControl;
         set
         {
            _visualizerControl = value;

            if (_visualizerControl?.InputLayer != null)
               _visualizerControl.InputLayer.PropertyChanged += InputLayer_PropertyChanged;
         }
      }

      private void TrainingControl_Load(object sender, System.EventArgs e)
      {
         Initialize();
      }

      private void InputLayer_PropertyChanged(object sender, PropertyChangedEventArgs e)
      {
         LoadCostFunction();
      }

      private void Initialize()
      {
         LoadDatasetLoading();
         LoadInitializationWeights();
         LoadInitializationBiases();
         LoadCostFunction();
         LoadSettingsAlgorithm();
      }

      private void LoadDatasetLoading()
      {
         btnDatasetLoad.AddItem("CSV", "CSV...");
         btnDatasetLoad.AddItem("SQLServer", "SQL Server...");
      }

      private void LoadSettingsAlgorithm()
      {
         cboSettingsAlgorithm.Load<TrainingAlgorithmType>();
         cboSettingsAlgorithm.SelectedItem = TrainingAlgorithmType.Momentum;

         propSettingsAlgorithmParams.SelectedObject = new Momentum
         {
            LearningRate = 0.003f,
            Regularization = 0.5f,
            Coefficient = 0.1f
         };
      }

      private void LoadCostFunction()
      {
         var costs = _visualizerControl?.InputLayer?.GetAllowedCostFunctions();

         if (costs == null || costs.Count() == 0)
         {
            cboSettingsCostFunction.Items.Clear();
            cboSettingsCostFunction.Enabled = false;
         }
         else
         {
            cboSettingsCostFunction.Enabled = true;
            cboSettingsCostFunction.Reload(costs);
            cboSettingsCostFunction.SelectedItem = costs.First();
         }
      }

      private void LoadInitializationBiases()
      {
         cboInitializationBiases.Load<BiasInitializationMode>();
         cboInitializationBiases.SelectedItem = BiasInitializationMode.Gaussian;
      }

      private void LoadInitializationWeights()
      {
         cboInitializationWeights.Load<WeightsInitializationMode>();
         cboInitializationWeights.SelectedItem = WeightsInitializationMode.LeCunUniform;
      }

      private void btnDatasetLoad_ItemClick(object sender, ItemClickEventArgs e)
      {
         switch(e.Key)
         {
            case "CSV":
               LoadCsv();
               break;
         }
      }

      private void LoadCsv()
      {
         using (var dialog = new frmLoadCSV())
         {
            dialog.ShowDialog(this);
         }
      }
   }
}
