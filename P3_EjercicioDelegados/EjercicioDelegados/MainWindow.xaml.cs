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

namespace EjercicioDelegados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random numero = new Random();
        int[] lista = new int[10];

        delegate void Operaciones();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOperacion_Click(object sender, RoutedEventArgs e)
        {
            Operaciones Operar = Ordenar;
            Operar += Pares;
            Operar += Cambio;
            Operar();
        }

        private void btnLlenar_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = numero.Next(1, 101);
                lstLlenado.Items.Add(lista[i]);
            }
        }

        public void Ordenar()
        {
            int aux;
            for (int i = 0; i < lista.Length; i++)
            {
                for (int j = i; j < lista.Length; j++)
                {
                    if(lista[i] > lista [j])
                    {
                        aux = lista[i];
                        lista[i] = lista[j];
                        lista[j] = aux;
                    }
                }
                lstOrdenar.Items.Add(lista[i]);
            }
        }
        public void Pares()
        {
            for (int i = 0; i < lista.Length; i++)
            {
                if((lista[i] % 2) == 1)
                {
                    lista[i] += 1;
                }
                lstPares.Items.Add(lista[i]);
            }
        }
        public void Cambio()
        {
            for (int i = 0; i < lista.Length; i++)
            {
                if(lista[i] == 10)
                {
                    lista[i] = 0;
                }
                lstCambio.Items.Add(lista[i]);
            }
        }
    }
}
