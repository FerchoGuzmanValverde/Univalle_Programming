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

namespace Salario_de_un_Trabajador
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
            float horas, tarifa, salario;
            horas = float.Parse(txthoras.Text);
            tarifa = float.Parse(txttarifa.Text);
            if (horas > 40)
                salario = (((horas - 40) * tarifa) * 1.5f) + (40 * tarifa);
            else
                salario = horas * tarifa;
            lblrespuesta.Content = salario;
        }
    }
}
