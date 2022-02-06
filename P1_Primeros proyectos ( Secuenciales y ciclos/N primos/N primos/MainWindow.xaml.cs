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

namespace N_primos
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

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            int num, mod, con = 0;
            num = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingresa un numero"));
            for (int i = 2; i < num; i++)
            {
                mod = num % i;
                if((mod % num) == 0)
                {
                    con++;
                    i = num;
                }
            }
            if (con >= 1)
            {
                MessageBox.Show("El numero no es primo");
            }
            else
            {
                MessageBox.Show("El numero es primo");
            }
        }
    }
}
