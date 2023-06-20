using Syncfusion.UI.Xaml.Charts;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace ExamScoreChart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumericalAxis_LabelCreated(object sender, LabelCreatedEventArgs e)
        {
            if (e.AxisLabel.LabelContent is string label && label == "0")
            {
                e.AxisLabel.LabelContent = "Persentile Rank";
            }
        }

        private void TextBlock_Loaded(object sender, RoutedEventArgs e)
        {
            if (sender is TextBlock textBlock)
            {
                var text = textBlock.Text;
                var lines = text.Split(new[] { '\r', '\n' });
                if (lines.Length > 1)
                {
                    var lastLine = lines[lines.Length - 1];
                    var lastLineRun = new Run(lastLine) { Foreground = Brushes.Gray };
                    var initialTexts = text.Substring(0, text.Length - lastLine.Length);
                    var initialTextsRun = new Run(initialTexts) { FontWeight = FontWeights.Medium, Foreground = Brushes.Black };
                    textBlock.Inlines.Clear();
                    textBlock.Inlines.Add(initialTextsRun);
                    textBlock.Inlines.Add(lastLineRun);
                }
            }
        }
    }
}
