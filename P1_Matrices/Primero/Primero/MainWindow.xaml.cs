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

namespace Primero
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[,] datos = new int[2, 3];
        int[,] datos2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Random n = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnnuevo_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < datos.GetLength(0); i++)
            {
                for (int j = 0; j < datos.GetLength(1); j++)
                {
                    datos[i, j] = n.Next(1, 21);
                    txtmostrador.AppendText(datos[i, j] + "\t");
                }
                txtmostrador.AppendText("\n");
            }
        }

        private void btnsuma_Click(object sender, RoutedEventArgs e)
        {
            Suma_de_Matrices nuevo = new Suma_de_Matrices();
            nuevo.Show();
        }
    }
}
