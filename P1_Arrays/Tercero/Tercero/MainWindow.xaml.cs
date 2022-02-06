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

namespace Tercero
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] vec = new int[10];
        Random num = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnllenar_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                vec[i] = num.Next(1, 10);
            }
        }

        private void btnmostrar_Click(object sender, RoutedEventArgs e)
        {
            int num1 = int.Parse(txtn.Text);
            if(num1 > 0 && num1 < 11)
            MessageBox.Show("El valor es: " + vec[num1]);
            else { MessageBox.Show("El numero es invalido"); }
        }
    }
}
