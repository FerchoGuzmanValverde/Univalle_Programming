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
    /// Interaction logic for Ci9.xaml
    /// </summary>
    public partial class Ci9 : Window
    {
        public Ci9()
        {
            InitializeComponent();
        }

        private void btnsuma_Click(object sender, RoutedEventArgs e)
        {
            int num = int.Parse(txtnumero.Text);
            suma(num);
        }

        private void suma(int num)
        {
            int sum = 0, rest;
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
