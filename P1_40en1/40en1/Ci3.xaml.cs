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
    /// Interaction logic for Ci3.xaml
    /// </summary>
    public partial class Ci3 : Window
    {
        Ciclos op = new Ciclos();
        public Ci3()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, RoutedEventArgs e)
        {
            int[] primos = op.primos();
            mostrar(primos);
        }

        private void mostrar(int[] vec)
        {
            for (int i = 0; i < vec.Length; i++)
            {
                lstprimos.Items.Add("P: " + (i + 1) + " = " + vec[i]);
            }
        }
    }
}
