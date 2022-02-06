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

namespace Mayor_de_3_numeros
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
            int num1, num2, num3;
            num1 = int.Parse(txtnumero1.Text);
            num2 = int.Parse(txtnumero2.Text);
            num3 = int.Parse(txtnumero3.Text);
            if (num1 > num2 && num1 > 3)
                lblrespuesta.Content = num1;
            else
                if (num2 > num3 && num2 > num1)
                lblrespuesta.Content = num2;
            else
                lblrespuesta.Content = num3;

        }
    }
}
