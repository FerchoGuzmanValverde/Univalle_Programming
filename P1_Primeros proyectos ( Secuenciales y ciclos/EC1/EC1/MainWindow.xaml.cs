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

namespace EC1
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

        private void btcalcular_Click(object sender, RoutedEventArgs e)
        {
            int num1, num2, repsuesta = 0, con;
            num1 = int.Parse(txtmultiplicando.Text);
            num2 = int.Parse(txtmultiplicador.Text);
            int a = num1, b = num2;
            while (a >= 1)
            {
                if (a % 2 != 0)
                {
                    repsuesta = repsuesta += b;
                }
                b = b * 2;
                a = a / 2;
            }
            lbl_respuesta.Content = repsuesta.ToString();
        }
    }
}
