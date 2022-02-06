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

namespace Tarea_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string aux;
        RobotConLimite dispositivo = new RobotConLimite();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnejercicio1_Click(object sender, RoutedEventArgs e)
        {
            dispositivo.X = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese ubicacion inicial sobre X: ","Coordenadas"));
            dispositivo.Y = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese ubicacion inicial sobre Y: ","Coordenadas"));
            dispositivo.Xlim = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese limite de X: ", "Limites"));
            dispositivo.Ylim = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese limite de Y: ", "Limites"));
            avance();
        }

        private void avance()
        {
            while(aux != "Limite")
            {
                MessageBox.Show(dispositivo.avanzar(int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese distancia de avance"))));
            }
        }

        private void btnejercicio2_Click(object sender, RoutedEventArgs e)
        {
            Circulo figura = new Circulo(int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese X")), int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Y")), int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese radio")));
            MessageBox.Show(figura.mostrar() + "\n" + figura.determinarCuadrante() + "\n" + figura.calcularArea() + "\n" + figura.calcularCircunferencia() + "\n" + figura.calcularDiametro(), "Detalles");
        }

        private void btnejercicio3_Click(object sender, RoutedEventArgs e)
        {
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese nombre", "Persona");
            int edad = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese edad", "Persona"));
            double peso = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Peso", "Persona"));
            Persona Primero = new Persona(nombre, edad, peso);
            MessageBox.Show(Primero.mostrar(), "Persona");
            nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese nombre", "Trabajador");
            edad = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese edad", "Trabajador"));
            peso = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Peso", "Trabajador"));
            int antiguedad = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Antiguedad", "Trabajador"));
            int sueldo = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese sueldo", "Trabajador"));
            string area = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Area", "Trabajador");
            Empleado persona = new Empleado(nombre, edad, peso, antiguedad, sueldo, area);
            MessageBox.Show(persona.mostrar(), "Empleado");
            nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese nombre", "Secretario");
            edad = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese edad", "Secretario"));
            peso = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Peso", "Secretario"));
            antiguedad = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Antiguedad", "Secretario"));
            sueldo = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese sueldo", "Secretario"));
            area = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Area", "Secretario");
            int pm = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese cantidad de palabras por minuto", "Secretario"));
            string jefe = Microsoft.VisualBasic.Interaction.InputBox("Ingrese nombre de Jefe", "Secretario");
            Secretario trabajador = new Secretario(nombre, edad, peso, antiguedad, sueldo, area, pm, jefe);
            MessageBox.Show(trabajador.mostrar(), "Secretario");
        }
    }
}
