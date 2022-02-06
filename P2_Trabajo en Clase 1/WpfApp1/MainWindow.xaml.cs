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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Persona Usuario = new Persona(txtnombre.Text, int.Parse(txtnacimiento.Text), int.Parse(txtactual.Text));
            lblrespuesta.Content = Usuario.Calcular_edad();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Persona Usuario = new Persona(txtnombre.Text, int.Parse(txtnacimiento.Text), int.Parse(txtactual.Text));
            lblrespuesta.Content = Usuario.Determinar_mayor_edad();
        }

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            Estudiante Alumno = new Estudiante(txtnombre1.Text, int.Parse(txtnota1.Text), int.Parse(txtnota2.Text), int.Parse(txtnota3.Text));
            lblresultado.Content = Alumno.Nota_Final();
        }

        private void btnaprobado_Click(object sender, RoutedEventArgs e)
        {
            Estudiante Alumno = new Estudiante(txtnombre1.Text, int.Parse(txtnota1.Text), int.Parse(txtnota2.Text), int.Parse(txtnota3.Text));
            lblresultado.Content = Alumno.Aprivado_Reprovado();
        }
    }
}
