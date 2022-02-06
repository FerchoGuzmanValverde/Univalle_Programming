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

namespace Porcentajes
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
            double num1, porcentaje, resultado;
            num1 = Convert.ToInt32(txtnumero.Text);
            porcentaje = Convert.ToInt32(txtporcentaje.Text);
            resultado = (num1 * porcentaje) / 100;
            lblresultado.Content = resultado.ToString();
        }

        private void btnborrar_Click(object sender, RoutedEventArgs e)
        {
            txtnumero.Clear();
            txtporcentaje.Clear();
            lblresultado.Content = "";
        }
    }
}
