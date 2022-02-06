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

namespace MetodosVectores
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Mi_clase Ope = new Mi_clase();
        int[] vec1, vec2, vec3; int num;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btncrear_Click(object sender, RoutedEventArgs e)
        {
            num = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese numero de elementos para vectores"));
            asignar();
            Ope.crear(vec1);
            Ope.crear(vec2);
            Mostrar(vec1, vec2);
        }

        private void asignar()
        {
            vec1 = new int[num];
            vec2 = new int[num];
            vec3 = new int[num + num];
        }

        private void Mostrar(int[] vec, int[] vec1)
        {
            for (int i = 0; i < vec.Length; i++)
            {
                lstvector1.Items.Add("P: " + (i + 1) + "\t= " + vec[i]);
                lstvector2.Items.Add("P: " + (i + 1) + "\t= " + vec1[i]);
            }
        }

        private void btnmostrar_Click(object sender, RoutedEventArgs e)
        {
            seleccion();
        }

        private void seleccion()
        {
            if (rbtburbuja.IsChecked == true)
            {
                Ope.burbuja(vec1);
                MostrarR(vec1);
            }
            else if (rbtsuma.IsChecked == true)
            {
                Ope.suma(vec1, vec2, vec3);
                MostrarR(vec3);
            }
            else if (rbtpromedio.IsChecked == true)
            {
                MostrarR1(Ope.promedio(vec1));
                MostrarR1(Ope.promedio(vec2));
            }
            else if (rbtmaximo.IsChecked == true)
            {
                MostrarR1(Ope.Max(vec1));
                MostrarR1(Ope.Max(vec2));
            }
            else if (rbtminimo.IsChecked == true)
            {
                MostrarR1(Ope.Min(vec1));
                MostrarR1(Ope.Min(vec2));
            }
            else if (rbtunion.IsChecked == true)
            {
                vec3 = Ope.Union(vec1, vec2);
                MostrarR(vec3);
            }
            else if (rbtinterseccion.IsChecked == true)
            {
                MostrarR(Ope.Interseccion(vec1, vec2));
            }
            else if (rbtdiferencia.IsChecked == true)
            {
                vec3 = Ope.diferencia(vec1, vec2);
                MostrarR(vec3);
            }
            else
            { MessageBox.Show("Porfavor seleccione una operacion"); }
        }

        private void MostrarR1(int a)
        {
            lstresultado.Items.Add("resultado: " + a);
        }

        private void MostrarR(int[] vec)
        {
            for (int i = 0; i < vec.Length; i++)
            {
                lstresultado.Items.Add("p: " + (i+1) + "\t= " + vec[i]);
            }
        }

    }
}
