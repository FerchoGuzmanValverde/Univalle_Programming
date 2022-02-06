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

namespace temperatura
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random temp = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            int valor = 0, i = 0, max = 0, c = 0, promedio = 0;
            while(i<7)
            {
                valor = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("ingrese valor"));
                if (valor > max)
                    max = valor;
                if (valor > 25)
                    c++;
                promedio = promedio + valor;
                i++;
            }
            promedio = promedio / 7;
            MessageBox.Show("temperatura maxima: " + max + "\nNumero de dias que superaron los 25 grados: " + c + "\nPromedio: " + promedio);
                       
        }
    }
}
