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

namespace EnClase1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Vectores op = new Vectores();
        int[] vectores; int num;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btncrear_Click(object sender, RoutedEventArgs e)
        {
            num = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese numero de elementos del vector"));
            vectores = new int[num];
            op.crear(vectores);
            mostrador(vectores, lstoriginal);
        }

        private void mostrador(int[] X, ListBox name)
        {
            for (int i = 0; i < X.Length; i++)
            {
                name.Items.Add("Posicion: " + (i+1) + "\t= " + X[i]);
            }
        }

        private void btndetalles_Click(object sender, RoutedEventArgs e)
        {
            mostrador(op.nor(vectores), lstelementos);
            mostrador(op.contador(vectores), lstcontadores);
            graficador(vectores);
        }

        private void graficador(int[] vec)
        {
            for (int i = 0; i < vec.Length; i++)
            {
                for (int j = 0; j < vec[i]; j++)
                {
                    txtgrafica.AppendText("X ");
                }
                txtgrafica.AppendText("\n");
            }
        }
    }
}
