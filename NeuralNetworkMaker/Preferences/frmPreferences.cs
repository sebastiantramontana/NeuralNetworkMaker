using NeuralNetwork.Visualizer;
using NeuralNetwork.Visualizer.Drawing;
using NeuralNetwork.Visualizer.Preferences.Formatting;
using NeuralNetwork.Visualizer.Preferences.Pens;
using NeuralNetwork.Visualizer.Preferences.Text;
using NeuralNetworkMaker.Preferences.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace NeuralNetworkMaker.Preferences
{
   public partial class frmPreferences : Form
   {
      private readonly NeuralNetworkVisualizerControl _visualizerControl;

      public frmPreferences(NeuralNetworkVisualizerControl visualizerControl)
      {
         InitializeComponent();
         _visualizerControl = visualizerControl;
      }

      private void frmPreferences_Load(object sender, System.EventArgs e)
      {
         Initialize();
      }

      private void Initialize()
      {
         InitializeGeneral();
         InitializeLayers();
         InitializeInputs();
         InitializeNeurons();
         InitializeBiases();
         InitializeEdges();
      }

      private void InitializeGeneral()
      {
         spinNodesMargin.Value = _visualizerControl.Preferences.NodeMargins;
         LoadComboQualityNNVisualizer();
         chkAsyncRedrawOnResize.Checked = _visualizerControl.Preferences.AsyncRedrawOnResize;
      }

      private void InitializeLayers()
      {
         brushLayersBackground.Brush = _visualizerControl.Preferences.Layers.Background;
         brushLayersBackgroundSelected.Brush = _visualizerControl.Preferences.Layers.BackgroundSelected;
         penLayersBorder.Pen = _visualizerControl.Preferences.Layers.Border.CreatePen();
         penLayersBorderSelected.Pen = _visualizerControl.Preferences.Layers.BorderSelected.CreatePen();
      }

      private void InitializeInputs()
      {
         prefInputs.NodePreference = _visualizerControl.Preferences.Inputs;
      }

      private void InitializeNeurons()
      {
         InitializeByValueSignTextFormatterControl(formatterNeuronsSumValue, _visualizerControl.Preferences.Neurons.SumValueFormatter);
         prefNeurons.NodePreference = _visualizerControl.Preferences.Neurons;
      }

      private void InitializeBiases()
      {
         prefBiases.NodePreference = _visualizerControl.Preferences.Biases;
      }

      private void InitializeEdges()
      {
         spinEdgesRoundingDigits.Value = _visualizerControl.Preferences.Edges.RoundingDigits;
         InitializeByValueSignTextFormatterControl(formatterEdgesWeight, _visualizerControl.Preferences.Edges.WeightFormatter);
         InitializeByValueSignPenFormatterControl(formatterEdgesConnector, _visualizerControl.Preferences.Edges.ConnectorFormatter);
         InitializeByValueSignPenFormatterControl(formatterEdgesConnectorSelected, _visualizerControl.Preferences.Edges.ConnectorSelectedFormatter);
      }

      private void InitializeByValueSignTextFormatterControl(ByValueSignTextFormatterControl control, IFormatter<TextPreference> formatter)
      {
         control.ByValueSignTextFormatter = ConvertToByValueSignFormatter(formatter, TextPreference.Null);
      }

      private void InitializeByValueSignPenFormatterControl(ByValueSignPenFormatterControl control, IFormatter<Pen> formatter)
      {
         control.ByValueSignPenFormatter = ConvertToByValueSignFormatter(formatter);
      }

      private ByValueSignFormatter<T> ConvertToByValueSignFormatter<T>(IFormatter<T> formatter, T whenNull = default) where T : class
      {
         ByValueSignFormatter<T> byValueSignFormatter;

         if (formatter is BasicFormatter<T> basicFormatter)
         {
            var whenPositive = basicFormatter.FormaterFunc();
            var whenZero = basicFormatter.FormaterFunc();
            var whenNegative = basicFormatter.FormaterFunc();
            whenNull = whenNull ?? basicFormatter.FormaterFunc();

            byValueSignFormatter = new ByValueSignFormatter<T>(() => whenNegative, () => whenZero, () => whenPositive, () => whenNull);
         }
         else
         {
            byValueSignFormatter = formatter as ByValueSignFormatter<T>;
         }

         return byValueSignFormatter;
      }

      private void chkAsyncRedrawOnResize_CheckedChanged(object sender, System.EventArgs e)
      {
         _visualizerControl.Preferences.AsyncRedrawOnResize = chkAsyncRedrawOnResize.Checked;
      }

      private void LoadComboQualityNNVisualizer()
      {
         cboRenderQuality.Items.Add(RenderQuality.Low);
         cboRenderQuality.Items.Add(RenderQuality.Medium);
         cboRenderQuality.Items.Add(RenderQuality.High);

         cboRenderQuality.SelectedItem = _visualizerControl.Preferences.Quality;
      }

      private void cboRenderQuality_SelectedIndexChanged(object sender, System.EventArgs e)
      {
         _visualizerControl.Preferences.Quality = (RenderQuality)cboRenderQuality.SelectedItem;
         _visualizerControl.Redraw();
      }

      private void spinNodesMargin_ValueChanged(object sender, System.EventArgs e)
      {
         _visualizerControl.Preferences.NodeMargins = (byte)spinNodesMargin.Value;
         _visualizerControl.Redraw();
      }

      private void brushLayersBackground_BrushChanged(object sender, System.EventArgs e)
      {
         _visualizerControl.Preferences.Layers.Background = brushLayersBackground.Brush;
         _visualizerControl.Redraw();
      }

      private void brushLayersBackgroundSelected_BrushChanged(object sender, System.EventArgs e)
      {
         _visualizerControl.Preferences.Layers.BackgroundSelected = brushLayersBackgroundSelected.Brush;
         _visualizerControl.Redraw();
      }

      private void penLayersBorder_PenChanged(object sender, System.EventArgs e)
      {
         _visualizerControl.Preferences.Layers.Border = new SimplePen(penLayersBorder.Pen);
         _visualizerControl.Redraw();
      }

      private void penLayersBorderSelected_PenChanged(object sender, System.EventArgs e)
      {
         _visualizerControl.Preferences.Layers.BorderSelected = new SimplePen(penLayersBorderSelected.Pen);
         _visualizerControl.Redraw();
      }

      private void prefInputs_NodePreferenceChanged(object sender, System.EventArgs e)
      {
         _visualizerControl.Redraw();
      }

      private void prefNeurons_NodePreferenceChanged(object sender, System.EventArgs e)
      {
         _visualizerControl.Redraw();
      }

      private void prefBiases_NodePreferenceChanged(object sender, System.EventArgs e)
      {
         _visualizerControl.Redraw();
      }

      private void formatterNeuronsSumValue_TextFormatterChanged(object sender, System.EventArgs e)
      {
         _visualizerControl.Preferences.Neurons.SumValueFormatter = formatterNeuronsSumValue.ByValueSignTextFormatter;
         _visualizerControl.Redraw();
      }

      private void spinEdgesRoundingDigits_ValueChanged(object sender, System.EventArgs e)
      {
         _visualizerControl.Preferences.Edges.RoundingDigits = (byte)spinEdgesRoundingDigits.Value;
         _visualizerControl.Redraw();
      }

      private void formatterEdgesWeight_TextFormatterChanged(object sender, System.EventArgs e)
      {
         _visualizerControl.Preferences.Edges.WeightFormatter = formatterEdgesWeight.ByValueSignTextFormatter;
         _visualizerControl.Redraw();
      }

      private void formatterEdgesConnector_PenFormatterChanged(object sender, System.EventArgs e)
      {
         _visualizerControl.Preferences.Edges.ConnectorFormatter = formatterEdgesConnector.ByValueSignPenFormatter;
         _visualizerControl.Redraw();
      }

      private void formatterEdgesConnectorSelected_PenFormatterChanged(object sender, System.EventArgs e)
      {
         _visualizerControl.Preferences.Edges.ConnectorSelectedFormatter = formatterEdgesConnectorSelected.ByValueSignPenFormatter;
         _visualizerControl.Redraw();
      }
   }
}
