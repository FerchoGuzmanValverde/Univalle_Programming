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

namespace Tarea1
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

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Usuario user = new Usuario(txtnombreUsuario.Text, int.Parse(txtnroPin.Text));
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Ha ocurrido un error con los formatos ingresados.\nPor favor asegurese de estar usando el formato correcto en los campos de relleno");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error. " + ex.Message);
            }
        }

        private void btn_Calcular_Click(object sender, RoutedEventArgs e)
        {
            bool tarjeta = comprobarTarjeta();
            try
            {
                Compra comprita = new Compra(byte.Parse(txtcantidadHamburguesas.Text), char.Parse(combotipo.Text), tarjeta);
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Ha ocurrido un error con el tipo de formato al ingresar los datos.\n" + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error.\n" + ex.Message);
            }
        }

        private bool comprobarTarjeta()
        {
            if (rbtSi.IsChecked == true)
            { return true; }
            else
            { return false; }
        }
    }
}
