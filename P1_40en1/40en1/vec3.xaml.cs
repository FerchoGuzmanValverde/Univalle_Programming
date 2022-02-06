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
    /// Interaction logic for vec3.xaml
    /// </summary>
    public partial class vec3 : Window
    {
        vectores operacion = new vectores();

        public vec3()
        {
            InitializeComponent();
        }

        private void btngenerar_Click(object sender, RoutedEventArgs e)
        {
            mostrar(operacion.crearaleatorio(), lstmostrador);
        }

        private void mostrar(int[] vector, ListBox name)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                name.Items.Add(vector[i]);
            }
        }
    }
}
