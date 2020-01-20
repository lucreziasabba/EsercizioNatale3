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

namespace WpfEsercizioNatale3
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

        private void ON_Click(object sender, RoutedEventArgs e)
        {
            txtNum1.IsEnabled = true;
            txtNum2.IsEnabled = true;
            txtNum3.IsEnabled = true;
            txtNum4.IsEnabled = true;
            txtNum5.IsEnabled = true;
            txtNum6.IsEnabled = true;
            btnOn.Content = "OFF";
        }
        private void OFF_Click(object sender, RoutedEventArgs e)
        {
            txtNum1.IsEnabled = false;
            txtNum2.IsEnabled = false;
            txtNum3.IsEnabled = false;
            txtNum4.IsEnabled = false;
            txtNum5.IsEnabled = false;
            txtNum6.IsEnabled = false;
            btnOn.Content = "ON";
        }

        private void Calcola_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
