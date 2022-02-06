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

namespace Inverticiones
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] vec1 = new int[10];
        int[] vec2 = new int[10];
        int[] vec3 = new int[10];
        Operaciones op = new Operaciones();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btncrear_Click(object sender, RoutedEventArgs e)
        {
            op.generar(vec1);
            mostrar(vec1, lstvector1);
            op.generar(vec2);
            mostrar(vec2, lstvector2);
            op.generar(vec3);
            mostrar(vec3, lstvector3);
        }

        private void mostrar(int[] vec, ListBox name)
        {
            for (int i = 0; i < vec.Length; i++)
            {
                name.Items.Add("p: " + (1 + i) + "= " + vec[i]);
            }
        }

        private void btninvertir_Click(object sender, RoutedEventArgs e)
        {
            op.invertir(vec3);
            mostrar(vec3, lstinvertido);
        }

        private void btnintercambiar_Click(object sender, RoutedEventArgs e)
        {
            op.intercambiar1(vec1, vec2);
            mostrar(vec1, lstintercambiado1);
            mostrar(vec2, lstintercacmbiado2);
        }
    }
}
