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
using System.Windows.Shapes;

namespace _40en1
{
    /// <summary>
    /// Interaction logic for vec2.xaml
    /// </summary>
    public partial class vec2 : Window
    {
        vectores operacion = new vectores();
        int[] vector;

        public vec2()
        {
            InitializeComponent();
        }

        private void btncrear_Click(object sender, RoutedEventArgs e)
        {
            vector = operacion.crear(int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese tamanio del arreglo")));
        }

        private void btnmostrar_Click(object sender, RoutedEventArgs e)
        {
            mostrar(vector, txthistograma);
        }

        private void mostrar(int[] aux, TextBox name)
        {
            for (int i = 0; i < aux.Length; i++)
            {
                for (int j = 0; j < aux[i]; j++)
                {
                    name.AppendText("*");
                }
                name.AppendText("\n");
            }
        }
    }
}
