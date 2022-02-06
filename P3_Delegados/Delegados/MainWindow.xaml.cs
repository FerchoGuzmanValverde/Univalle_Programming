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

namespace Delegados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Declaracion del delegado
        public delegate int Operaciones(int v1, int v2); // Es un objeto que hace referencia a un metodo
        //Declaracion de delegado generico
        //public delegate <T> Delegados(T v1, T v2);
        //Llamada a delegados genericos
        //Delegados <int> Operar = new Delegados <int> (Sumar);

        public MainWindow()
        {
            InitializeComponent();
        }

        public int Sumar(int a, int b)
        {
            return a + b;
        }

        public int Restar(int x, int y)
        {
            return x - y;
        }

        public int Multi(int v1, int v2)
        {
            return v1 * v2;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //En el contructor
            Operaciones Opera = new Operaciones(Restar);
            int aux = Opera(5, 7);
            //Otra forma de declarar el delegado
            Operaciones Operar = Sumar;
            //Concatenar metodos en un delegado
            Operar += Restar; //Se ve en pantalla solo el ultimo delegado, pero ejecuta todos los delegados concatenados.
            //Mas efectivo para metodos void para ejecutar varios metodos y acciones con una sola orden.
            MessageBox.Show(Operar(2, 3).ToString());
        }
    }
}
