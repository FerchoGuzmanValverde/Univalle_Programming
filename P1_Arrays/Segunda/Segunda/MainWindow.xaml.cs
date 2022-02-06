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

namespace Segunda
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] esto = new int[10];
        Random fer = new Random();
        int var;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btniniciar_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                esto[i] = fer.Next(1, 50);
            }
        }

        private void btncomprobar_Click(object sender, RoutedEventArgs e)
        {
            var = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor: "));
            buscar();
        }

        private void buscar()
        {
            for (int i = 0; i < 10; i++)
            {
                if (var == esto[i])
                {
                    MessageBox.Show("El vector esta en la pocision " + i);
                }
                else
                {
                    MessageBox.Show("El vector no esta en el vector");
                }
            }
        }
    }
}
