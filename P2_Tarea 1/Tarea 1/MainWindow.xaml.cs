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

namespace Tarea_1
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

        private void btnprimo_Click(object sender, RoutedEventArgs e)
        {
            Numero Digito = new Numero(int.Parse(txtnumero.Text));
            lblresultado.Content = Digito.Determinar_primo();
        }

        private void btnposneg_Click(object sender, RoutedEventArgs e)
        {
            Numero Digito = new Numero(int.Parse(txtnumero.Text));
            lblresultado.Content = Digito.Determinar_pos_neg_cero();
        }

        private void btnparimpar_Click(object sender, RoutedEventArgs e)
        {
            Numero Digito = new Numero(int.Parse(txtnumero.Text));
            lblresultado.Content = Digito.Determinar_par_impar();
        }

        private void btndetalles_Click(object sender, RoutedEventArgs e)
        {
            Vendedor Operario = new Vendedor(txtnombre.Text);
            mostrar_ventas(Operario.Mostrar_venta(), lstventas);
            lblnombre.Content = Operario.Mostrar_Nombre();
            lbltotal.Content = Operario.Sumar_ventas();
        }

        private void mostrar_ventas(double[] ventas, ListBox name)
        {
            for (int i = 0; i < ventas.Length; i++)
            {
                name.Items.Add("Mes " + (i+1) + " = " +ventas[i]);
            }
        }
    }
}
