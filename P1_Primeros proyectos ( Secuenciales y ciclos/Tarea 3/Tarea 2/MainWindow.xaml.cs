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

namespace Tarea_2
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
            txtrespuesta.Clear();
            int num1, num2, res = 1;
            num1 = int.Parse(txtnumero1.Text);
            num2 = int.Parse(txtnumero2.Text);
            for (int i = 1; i <= num2; i++)
            {
                res = res * num1;
            }
            txtrespuesta.AppendText(res.ToString());
        }
    }
}
