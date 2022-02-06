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

namespace Calculadora
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

        private void btnsumar_Click(object sender, RoutedEventArgs e)
        {
            int num1, num2, suma;
            num1 = Convert.ToInt32(txtnumero1.Text);
            num2 = Convert.ToInt32(txtnumero2.Text);
            suma = num1 + num2;
            lblresultado.Content = suma.ToString();
        }

        private void btnrestar_Click(object sender, RoutedEventArgs e)
        {
            int num1, num2, resta;
            num1 = Convert.ToInt32(txtnumero1.Text);
            num2 = Convert.ToInt32(txtnumero2.Text);
            resta = num1 - num2;
            lblresultado.Content = resta.ToString();
        }

        private void btnmultiplicar_Click(object sender, RoutedEventArgs e)
        {
            int num1, num2, multiplicacion;
            num1 = Convert.ToInt32(txtnumero1.Text);
            num2 = Convert.ToInt32(txtnumero2.Text);
            multiplicacion = num1 * num2;
            lblresultado.Content = multiplicacion.ToString();
        }

        private void btndividir_Click(object sender, RoutedEventArgs e)
        {
            double num1, num2, dividir;
            num1 = Convert.ToInt32(txtnumero1.Text);
            num2 = Convert.ToInt32(txtnumero2.Text);
            dividir = num1 / num2;
            lblresultado.Content = dividir.ToString();
        }

        private void btnlimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtnumero1.Text = "";
            txtnumero2.Clear();
            lblresultado.Content = "";
        }

        private void btnsalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
