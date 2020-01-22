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
        private TextBox[] x;
        public MainWindow()
        {
            InitializeComponent();
            x = new TextBox[] { txtNum1, txtNum2, txtNum3, txtNum4, txtNum5, txtNum6 };
        }

        private void ON_Click(object sender, RoutedEventArgs e)
        {
            if (btnOn.Content.ToString() == "ON")
            {
                txtNum1.IsEnabled = true;
                txtNum2.IsEnabled = true;
                txtNum3.IsEnabled = true;
                txtNum4.IsEnabled = true;
                txtNum5.IsEnabled = true;
                txtNum6.IsEnabled = true;
                btnCalcola.IsEnabled = true;
                btnOn.Content = "OFF";
            }
            else
            {
                txtNum1.IsEnabled = false;
                txtNum2.IsEnabled = false;
                txtNum3.IsEnabled = false;
                txtNum4.IsEnabled = false;
                txtNum5.IsEnabled = false;
                txtNum6.IsEnabled = false;
                btnCalcola.IsEnabled = false;
                btnOn.Content = "ON";
            }
        }

        private void Calcola_Click(object sender, RoutedEventArgs e)
        {
            int pari = 0;
            int dispari = 0;
            for (int i = 0; i < x.Length; i++)
            {
                int num = int.Parse(x[i].Text);
                if (num % 2 == 0)
                {
                    pari++;
                }
                else
                {
                    dispari++;
                }
            }
            lblRisultato.Content = $"I numeri pari sono {pari}, i numeri dispari sono {dispari}";
        }
    }
}
