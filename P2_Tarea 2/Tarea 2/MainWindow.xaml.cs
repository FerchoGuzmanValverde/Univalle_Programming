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

namespace Tarea_2
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

        private void btnempezar_Click(object sender, RoutedEventArgs e)
        {
            Entrada ticket = new Entrada();
            try
            {
                ticket.Pelicula = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Pelicula");
                ticket.Genero = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Genero");
                ticket.Edad = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Edad"));
                lblprimero.Content = ticket.calcularPrecio();
                ticket.Pelicula = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Pelicula");
                ticket.Genero = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Genero");
                ticket.Edad = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Edad"));
                lblprimero.Content = ticket.calcularPrecio();
                ticket.Pelicula = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Pelicula");
                ticket.Genero = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Genero");
                ticket.Edad = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Edad"));
                lblprimero.Content = ticket.calcularPrecio();
                ticket.Pelicula = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Pelicula");
                ticket.Genero = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Genero");
                ticket.Edad = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Edad"));
                lblprimero.Content = ticket.calcularPrecio();
            }
            catch
            {
                MessageBox.Show("Algo no anda bien, el programa se cerrara");
                this.Close();
            }
        }

        private void btningresar_Click(object sender, RoutedEventArgs e)
        {
            Reloj hora = new Reloj();
            try
            {
                hora.Hora = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese hora en Formato de 24 hora"));
                hora.Minuto = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese minutos"));
                hora.Segundo = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese segundos"));
                lblformato24.Content = hora.mostrarHoraF24();
                lblformato12.Content = hora.mostrarHoraF12();
            }
            catch
            {
                MessageBox.Show("Algo esta incorrecto el programa se cerrara");
                this.Close();
            }
        }
    }
}
