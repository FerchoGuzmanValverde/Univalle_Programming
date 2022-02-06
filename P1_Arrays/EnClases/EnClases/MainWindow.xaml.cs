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

namespace EnClases
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Vectores esto = new Vectores();
        int[] vector, vector1, vector2, vectorf;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btncrear_Click(object sender, RoutedEventArgs e)
        {
            vector = new int[int.Parse(txtnumero.Text)];
            esto.crear(vector);
            lstvector1.Items.Clear(); mostrador(lstvector1, vector);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Los pares son: " + esto.pares(vector) + "\nLos impares son: " + esto.impares(vector) + "\nEl promedio es: " + esto.promedio(vector), "Los detalles");
        }

        private void btngenerar_Click(object sender, RoutedEventArgs e)
        {
            vector1 = new int[20]; vector2 = new int[20];
            MessageBox.Show("Primer vector"); esto.generar(vector1); MessageBox.Show("Segundo vector"); esto.generar(vector2);
            lstv1.Items.Clear(); mostrador(lstv1, vector1);
            lstv2.Items.Clear(); mostrador(lstv2, vector2);
        }

        private void btnmostrar1_Click(object sender, RoutedEventArgs e)
        { MessageBox.Show(esto.comparacion(vector1, vector2), "Resultados"); }

        private void btngenera_Click(object sender, RoutedEventArgs e)
        {
            vectorf = new int[50];
            esto.crear(vectorf);
            lstvectorf.Items.Clear(); mostrador(lstvectorf, vectorf);
        }

        private void btnresult_Click(object sender, RoutedEventArgs e)
        { mayores(vectorf); MessageBox.Show("El promedio es: " + esto.promedio(vectorf)+"\nLos mayores al promedio son: "+esto.mayores(vectorf),"Detalles"); }

        private void mostrador(ListBox nombre, int[] X)
        {
            for (int i = 0; i < X.Length; i++)
            {
                nombre.Items.Add("Posicion: "+ (i + 1) + "\t= " + X[i]);
            }
        }
        private void mayores(int[] X)
        {
            for (int i = 0; i < X.Length; i++)
            {
                if(X[i] > esto.promedio(X))
                    lstresultados.Items.Add("Posicion: " + (i + 1) + "\t= " + X[i]);
            }
        }
    }
}
