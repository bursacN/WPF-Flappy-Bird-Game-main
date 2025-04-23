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
    /// Interaction logic for StartMenu.xaml
    /// </summary>
    public partial class StartMenu : Window
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             MainWindow mw = new MainWindow();
        
             mw.Show();
    
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HighScores hs = new HighScores(EndScreen.ReadDoubleListFromFile());
            this.Hide();
            hs.ShowDialog();
            this.Show();
       
        }
    }
}
