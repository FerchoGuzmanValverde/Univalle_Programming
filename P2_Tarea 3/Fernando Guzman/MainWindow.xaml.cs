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

namespace Fernando_Guzman
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Persona Humano = new Persona(txtnombre.Text, int.Parse(txtañoNacimiento.Text));
                lbledad.Content = Humano.calcularEdad(int.Parse(txtañoActual.Text));
                lblmayoromenor.Content = Humano.determinarMayor();
                Persona Humano2 = new Persona(txtnombre.Text, int.Parse(txtañoNacimiento.Text));
                lbledad2.Content = Humano.calcularEdad(int.Parse(txtañoActual.Text));
                lblmayoromenor2.Content = Humano.determinarMayor();
            }
            catch
            {
                MessageBox.Show("Ocurrio un error. El programa cerrara");
                this.Close();
            }
        }

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Estudiante alumno = new Estudiante(txtnombre.Text, double.Parse(txtparcial1.Text), double.Parse(txtparcial2.Text), double.Parse(txtparcial3.Text));
                lblnota.Content = alumno.calcularNotaFinal(int.Parse(txtp1.Text), int.Parse(txtp2.Text), int.Parse(txtp3.Text));
                lblaprep.Content = alumno.detApRep();
            }
            catch
            {
                MessageBox.Show("Ocurrio un inconveniente. El programa finalizara");
                this.Close();
            }
        }

        private void btnmostrarlos_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Numero digito = new Numero(double.Parse(txtnumero.Text));
                MessageBox.Show(digito.valorAbsoluto() + "\n" +
                    digito.potential(int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese una potencia"))) + "\n" +
                    digito.raizCuadrada() + "\n" + digito.seno() + "\n" + digito.coseno() + "\n" +
                    digito.numMax(int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un numero comparador para maximo"))) + "\n" +
                    digito.numMin(int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un numero comparador para minimo"))) + "\n" +
                    digito.parteEntera() + "\n" + digito.redondeo());
            }
            catch
            {
                MessageBox.Show("A ocurrido un error. El programa finalizara");
                this.Close();
            }
        }
    }
}
