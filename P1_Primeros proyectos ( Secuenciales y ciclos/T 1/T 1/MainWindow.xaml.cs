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

namespace T_1
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
            float sueldo = float.Parse(txtsueldo.Text);
            float bono, descuento1 = 0, descuento2 = 0, descuento3 = 0, Totaldescuento, total;                           
            if (rbtsistemas.IsChecked == true)
            {
                bono = sueldo * 0.02f;
                if (chkiva.IsChecked == true)
                {
                    descuento1 = sueldo * 0.13f;
                }
                if (chksalud.IsChecked == true)
                {
                    descuento2 = sueldo * 0.05f;
                }
                if (chkseguro.IsChecked == true)
                {
                    descuento3 = sueldo * 0.12f;
                }
            }
            else
            {
                bono = sueldo * 0.03f;
                if (chkiva.IsChecked == true)
                {
                    descuento1 = sueldo * 0.13f;
                }
                if (chksalud.IsChecked == true)
                {
                    descuento2 = sueldo * 0.05f;
                }
                if (chkseguro.IsChecked == true)
                {
                    descuento3 = sueldo * 0.12f;
                }
            }
            Totaldescuento = descuento1 + descuento2 + descuento3;
            total = (sueldo + bono) - (descuento1 + descuento2 + descuento3);
            lblbono.Content = bono;
            lbldescuento.Content = Totaldescuento;
            lblganado.Content = total;
            
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hola. que tal?" + "\n" + "Voy a definir detalles de tu sueldo segun los datos que me proveas. Espero ayudar");
        }
    }
}
