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

namespace Primera
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] vector = new int[10];
        int aux;
        Random numero = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnaleatorio_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                vector[i] = numero.Next(1, 10);
            }
        }

        private void btnmanual_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                vector[i] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un numero: "));
            }
        }

        private void btnmostrar_Click(object sender, RoutedEventArgs e)
        {
            txtmostrar.Clear();
            for (int i = 0; i < 10; i++)
            {
                txtmostrar.AppendText("Posicion: " + (i+1) + "\t" + "Valor: " + vector[i]+"\n");
            }
        }
    }
}
