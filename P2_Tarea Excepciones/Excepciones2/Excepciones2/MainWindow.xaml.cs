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

namespace Excepciones2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] numeros = new int[10];
        int cont = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                numeros[cont] = int.Parse(txtnumero.Text);
                cont++;
            }
            catch(IndexOutOfRangeException exep)
            {
                MessageBox.Show("Usted ha llenado todo el espacio del vector.\n" + exep.Message);
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Solo puede ingresar numeros en el espacio.\n" + ex.Message                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      );
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error.. " + ex.Message);
            }
        }

        private void btnmostrar_Click(object sender, RoutedEventArgs e)
        {
            lstmostrador.Items.Clear();
            for (int i = 0; i <= cont; i++)
            {
                    lstmostrador.Items.Add(numeros[i]);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lstmostrador.Items.Clear();
            for (int i = 0; i <= cont; i++)
            {
                if(numeros[i] % 2 == 0)
                    lstmostrador.Items.Add(numeros[i]);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lstmostrador.Items.Clear();
            for (int i = 0; i <= cont; i++)
            {
                if(numeros[i] % 2 != 0)
                    lstmostrador.Items.Add(numeros[i]);
            }
        }
    }
}
