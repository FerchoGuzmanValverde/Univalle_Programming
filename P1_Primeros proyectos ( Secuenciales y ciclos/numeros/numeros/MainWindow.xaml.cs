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

namespace numeros
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnverificar_Click(object sender, RoutedEventArgs e)
        {
            int total, valores = 0, pares = 0, inpar = 0, suma = 0, i = 0, promedio;
            total = int.Parse(txtcantidadvalores.Text);
            while (i < total)
            {
                valores = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox(""));
                if ((total % 2) == 0)
                    pares++;
                else
                    inpar++;
                suma = suma + valores;
                i++;
            }
            promedio = suma/total;
            MessageBox.Show("tota de pares: " + pares);
            MessageBox.Show("total de inpares: " + inpar);
            MessageBox.Show("promedio: " + promedio);
        }
    }
}
