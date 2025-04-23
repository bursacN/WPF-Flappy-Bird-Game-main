using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for EndScreen.xaml
    /// </summary>
    public partial class EndScreen : Window
    {
        MainWindow mw;
        static string filePath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "scores.txt");

        public EndScreen(MainWindow mw,double score,bool firstGame)
        {
            InitializeComponent();
            this.mw = mw;
            if(firstGame)
            {
                MsgTop.Content = "Welcome ";
                YourScore.Content = "" ;
                HighestScore.Content = "";
            }
            else
            {
                MsgTop.Content = "Game over ";
                YourScore.Content = "Your score: " + score;
                HighestScore.Content = "Highest score: " + GetHighestScore();
            }
             if(score>GetHighestScore())
            {
                MsgTop.Content = "Congrats, you got a new high score!";
                HighestScore.Content= "Highest score: " + score.ToString();
            }
            WriteIntToFile(score);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mw.Close();
            this.Close();
        }
        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.Key == Key.R)
            {
                 this.Close();
               // mw.StartGame();
            }
        }
        public static void WriteIntToFile(double number)
        {
            List<double> list = ReadDoubleListFromFile();
            foreach(double d in list)
            {
                if (d.Equals(number))
                    return;
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(number);
                }
             //   Console.WriteLine("Number written to file successfully.");
            }
            catch (Exception ex)
            {
            //    Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }
        public static List<double> ReadDoubleListFromFile()
        {
          
            List<double> numbers = new List<double>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (double.TryParse(line, out double number))
                        {
                            numbers.Add(number);
                        }
                    }
                }
              //  Console.WriteLine("Numbers read from file successfully.");
            }
            catch (Exception ex)
            {
            //    Console.WriteLine($"Error reading from file: {ex.Message}");
            }

            return numbers;
        }
        private double GetHighestScore()
        {
            List<double> list = ReadDoubleListFromFile();
            if (list != null) 
            { 
                double highest = list.Max();
                return highest; 
            }
            else return 0;
         

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HighScores hs = new HighScores(ReadDoubleListFromFile());
            this.Hide();
            hs.ShowDialog();
            this.Show();
        }
    }
}
