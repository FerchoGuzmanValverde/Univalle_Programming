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
    /// Interaction logic for vec1.xaml
    /// </summary>
    public partial class vec1 : Window
    {
        vectores operar = new vectores();
        int[] vector = new int[10];
        int[] vector2 = new int[10];

        public vec1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            operar.generar(vector);
            mostrar(vector, txtvector);
        }

        private void mostrar(int[] vec, TextBox name)
        {
            for (int i = 0; i < vec.Length; i++)
            {
                name.AppendText(vector[i] + "   ");
            }
        }

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            sinrepetir();
            contadores();
        }

        private void contadores()
        {
            int lee;
            for (int i = 0; i < vector2.Length; i++)
            {
                if (vector2[i] != 0)
                {
                    lee = 0;
                    txtcontar.AppendText(vector2[i] + " = ");
                    for (int j = 0; j < vector.Length; j++)
                    {
                        if (vector2[i] == vector[j])
                        {
                            lee++;
                        }
                    }
                    txtcontar.AppendText(lee + "\n");
                }
            }
        }

        private void sinrepetir()
        {
            int pos = 1, aux = 0, con = 1;
            vector2[0] = vector[0];
            for (int i = 1; i < vector.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (vector[i] == vector2[j])
                    {
                        aux = 1;
                    }
                }
                if (aux == 0)
                {
                    vector2[pos] = vector[i];
                    pos++;
                    con++;
                }
                aux = 0;
            }
            mostraro(vector2, con, txtsinrepetir);
        }

        private void mostraro(int[] vecto, int num, TextBox name)
        {
            for (int i = 0; i < vecto.Length; i++)
            {
                if (vecto[i] != 0)
                {
                    name.AppendText(vecto[i] + "   ");
                }
            }
        }
    }
}
