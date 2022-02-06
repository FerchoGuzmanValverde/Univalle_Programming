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

namespace Salario_Empleado
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

        private void btncalular_Click(object sender, RoutedEventArgs e)
        {
            int num1, num2, total, dies, quince;
            num1 = Convert.ToInt32(txtpago.Text);
            num2 = Convert.ToInt32(txtdias.Text);
            dies = ((num1 * num2) / 100) * 10;
            quince = ((num1 * num2) / 100) * 15;
            total = (num1 * num2) - dies - quince;
            lblpagototal.Content = total.ToString();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtdias.Clear();
            txtpago.Clear();
            lblpagototal.Content = "";
        }

        private void btnsalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtpago_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtdias_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
