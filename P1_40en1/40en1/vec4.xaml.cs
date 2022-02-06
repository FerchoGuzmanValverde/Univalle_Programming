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
    /// Interaction logic for vec4.xaml
    /// </summary>
    public partial class vec4 : Window
    {
        vectores operar = new vectores();
        int[] vector;

        public vec4()
        {
            InitializeComponent();
        }

        private void btncrear_Click(object sender, RoutedEventArgs e)
        {
            vector = operar.crear2(100);
            mostrar(vector, lstmostrador);
        }

        private void mostrar(int[] vec, ListBox name)
        {
            for (int i = 0; i < vec.Length; i++)
            {
                name.Items.Add(vec[i]);
            }
        }

        private void btnrevisar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(operar.revisar(vector));
        }
    }
}
