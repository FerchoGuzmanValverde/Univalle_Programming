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
    /// Interaction logic for vec5.xaml
    /// </summary>
    public partial class vec5 : Window
    {
        vectores operacion = new vectores();
        int[] vectorI;

        public vec5()
        {
            InitializeComponent();
        }

        private void btngenerar_Click(object sender, RoutedEventArgs e)
        {
            vectorI = operacion.crear2(50);
            mostrar(vectorI, lstvector);
        }

        private void mostrar(int[] vecto, ListBox name)
        {
            for (int i = 0; i < vecto.Length; i++)
            {
                name.Items.Add(vecto[i]);
            }
        }

        private void btndetallar_Click(object sender, RoutedEventArgs e)
        {
            lblpromedio.Content = operacion.promedio(vectorI);
            int[] aux = operacion.MayoP(vectorI, operacion.promedio(vectorI));
            mostrar(aux, lstMps);
            lblcantidadmp.Content = aux.Length;
        }
    }
}
