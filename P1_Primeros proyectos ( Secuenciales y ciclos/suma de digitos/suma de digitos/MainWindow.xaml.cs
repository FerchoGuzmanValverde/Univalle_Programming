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

namespace suma_de_digitos
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

        private void btnsuma_Click(object sender, RoutedEventArgs e)
        {
            int num, sum = 0, rest;
            num = int.Parse(txtvalor.Text);
            while (num != 0)
            {
                rest = num % 10;
                num = num / 10;
                sum = sum + rest;
            }
            MessageBox.Show("La suma de los digitos es: " + sum);
        }
    }
}
