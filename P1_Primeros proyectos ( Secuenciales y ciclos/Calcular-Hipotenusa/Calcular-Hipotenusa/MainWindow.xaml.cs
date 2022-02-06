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

namespace Calcular_Hipotenusa
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

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txtcateto1.Text);
            num2 = Convert.ToDouble(txtcateto2.Text);
            resultado = Math.Sqrt((num1 * num1) + (num2 * num2));
            lblresultado.Content = resultado.ToString();
        }

        private void btnborrar_Click(object sender, RoutedEventArgs e)
        {
            lblresultado.Content = "";
            txtcateto1.Clear();
            txtcateto2.Clear();
        }

        private void btnsalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtcateto1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtcateto2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
