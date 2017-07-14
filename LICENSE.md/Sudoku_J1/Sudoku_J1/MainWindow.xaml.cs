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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sudoku_J1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RandomShowNumber();

        }



        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RandomShowNumber()
        {
            Random rnd = new Random();

            for (int i = 1; i <= 9; i++)
            {

                int test = rnd.Next(1, 9);
                txt1_1.Text = rnd.Next(1, 10).ToString();
                txt1_2.Text = rnd.Next(1, 10).ToString();
                txt1_3.Text = rnd.Next(1, 10).ToString();
                txt1_4.Text = rnd.Next(1, 10).ToString();
                txt1_5.Text = rnd.Next(1, 10).ToString();
                txt1_6.Text = rnd.Next(1, 10).ToString();
                txt1_7.Text = rnd.Next(1, 10).ToString();
                txt1_8.Text = rnd.Next(1, 10).ToString();
                txt1_9.Text = rnd.Next(1, 10).ToString();

            }

    }
    }
}
