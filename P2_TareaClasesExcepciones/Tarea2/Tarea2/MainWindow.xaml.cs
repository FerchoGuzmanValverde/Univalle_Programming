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
        Horas emp;

        private void btnDeterminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                emp.EntradaEmpleado = DateTime.Parse(txthoraEntradaEmpleado.Text);
                emp.SalidaEmpleado = DateTime.Parse(txthoraSalidaEmpleado.Text);
            }
            catch(FormatException ex)
            {
                MessageBox.Show("El formato ingresado de tiempo de empleado es incorrecto.\n" + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un herror.\n" + ex.Message);
            }
            try
            {
                MessageBox.Show(emp.DeterminarEntrada() + "\n" + emp.DeterminarSalida());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error.\n" + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                emp = new Horas(DateTime.Parse(txthoraEntrada.Text), DateTime.Parse(txthoraSalida.Text));
            }
            catch(FormatException ex)
            {
                MessageBox.Show("No ha ingresado el formato correcto de tiempo.\n" + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error.\n" + ex.Message);
            }
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            Prendas ropa = new Prendas(char.Parse(cbmModelo.Text), byte.Parse(cbmTalla.Text), int.Parse(txtprecioTela.Text), byte.Parse(txtCantidadPrendas.Text));
            lblPrecioFinal.Content = ropa.calcularPrecio();
            lblGananciaFinal.Content = ropa.calcularGanancia();
        }
    }
}
