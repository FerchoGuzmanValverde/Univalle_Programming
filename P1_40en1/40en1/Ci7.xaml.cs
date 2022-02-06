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
    /// Interaction logic for Ci7.xaml
    /// </summary>
    public partial class Ci7 : Window
    {
        public Ci7()
        {
            InitializeComponent();
        }

        private void btncomenzar_Click(object sender, RoutedEventArgs e)
        {
            int tam = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese tamanio del histograma"));
            comenzar(tam);
        }

        private void comenzar(int num)
        {
            for (int i = 0; i < num; i++)
            {
                int n = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese numero: "));
                txtgrafica.AppendText(n + " | ");
                for (int j = 0; j < n; j++)
                {
                    txtgrafica.AppendText("*");
                }
                txtgrafica.AppendText("\n");
            }
        }
    }
}
