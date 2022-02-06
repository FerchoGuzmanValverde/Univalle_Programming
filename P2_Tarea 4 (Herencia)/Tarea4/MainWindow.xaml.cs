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

namespace Tarea4
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
            int x = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese coordenada en eje X"));
            int y = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese coordenada en eje y"));
            Punto coordenada = new Punto(x, y);
            MessageBox.Show(coordenada.enEjeX() + "\n" + coordenada.enEjeY(), "Ubicacion del Punto");
            x = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese coordenada en eje X"));
            y = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese coordenada en eje y"));
            int z = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese coordenada en eje Z"));
            Punto3D coordena = new Punto3D(x, y, z);
            MessageBox.Show(coordena.enEjeX() + "\n" + coordena.enEjeY()+"\n"+coordena.enEjeZ(), "Ubicacion del Punto");
        }

        private void btnIniciar_Click(object sender, RoutedEventArgs e)
        {
            double ancho = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese ancho de la caja", "Caja 1"));
            double alto = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese alto de la caja", "Caja 1"));
            double largo = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese largo de la caja", "Caja 1"));
            double peso = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese peso de la caja", "Caja 1"));
            CajaPeso caja1 = new CajaPeso(ancho, alto, largo, peso);
            ancho = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese ancho de la caja", "Caja 2"));
            alto = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese alto de la caja", "Caja 2"));
            largo = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese largo de la caja", "Caja 2"));
            peso = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese peso de la caja", "Caja 2"));
            CajaPeso caja2 = new CajaPeso(ancho, alto, largo, peso);
            if (caja1.Peso > caja2.Peso)
                mostrarcaja(caja1);
            else
                mostrarcaja(caja2);
        }

        private void mostrarcaja(CajaPeso nombre)
        {
            MessageBox.Show("Ancho: " + nombre.Ancho + "\nAlto: " + nombre.Alto + "\nLargo: " + nombre.Largo + "\nPeso: " + nombre.Peso, "Detalles " + nombre);
        }
    }
}
