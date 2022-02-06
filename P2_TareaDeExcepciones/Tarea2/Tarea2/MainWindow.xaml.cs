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

namespace Tarea2
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

        private void btnconvertir_Click(object sender, RoutedEventArgs e)
        {
            int numero;
            try
            {
                numero = int.Parse(txtnumero.Text);
                if (numero < 1)
                    throw new Exception("No puede ingresar valores menores a 1");
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Solo puede ingresar valores enteros para convertir");
                return;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error.. " + ex.Message);
                return;
            }
            string binario = "0";
            while (numero > 0)
            {
                binario = Convert.ToString(numero % 2) + binario;
                numero = numero / 2;
            }
            MessageBox.Show("El numero es: " + binario);
        }
    }
}
