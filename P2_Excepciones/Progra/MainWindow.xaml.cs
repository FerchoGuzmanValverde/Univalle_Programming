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

namespace Progra
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            int num1, num2;
            try
            {
                num1 = int.Parse(txtnumero1.Text); num2 = int.Parse(txtnumero2.Text);
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Error.. Solo puede ingresar numeros enteros como datos." + ex.Message);
                return;
            }
                if (num1 % 2 == 0 && num2 % 2 == 0)
                {
                    MessageBox.Show(((num1 + num2) / (num1 - num2)).ToString());
                }
        }
    }
}
