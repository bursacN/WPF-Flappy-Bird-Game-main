using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Flappy_Bird_WPF_MOO_ICT
{
    /// <summary>
    /// Interaction logic for HighScores.xaml
    /// </summary>
    public partial class HighScores : Window
    {
        public HighScores(List<double> scores)
        {
            InitializeComponent();
            DisplayHighScores(scores);
        }

        private void DisplayHighScores(List<double> scores)
        {
            // Sort the scores in descending order
            var sortedScores = scores.OrderByDescending(s => s);

            // Display the scores in the ListBox
            highScoreListBox.ItemsSource = sortedScores.Select((score, index) => $"#{index + 1}: {score}");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
