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

namespace EC2
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
            int num1, num2, con=0;
            num1 = int.Parse(txtdividendo.Text);
            num2 = int.Parse(txtdivisor.Text);
            int respuesta = num1;
            while (respuesta > 1)
            {
                respuesta = respuesta - num2;
                con++;
            }
            lblrespuesta.Content = "La respuesta es: " + con + "\nEl residuo es: " + respuesta;
        }
    }
}
