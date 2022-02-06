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

namespace Tarea_4
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
            int num, x = 0, y = 1, var, con = 0;
            num = int.Parse(txtnumero.Text);
            for (int i = 1; i <= num; i++)
            {
                var = x;
                x = y;
                y = var;
                x = x += y;
                con++;
                txtrespuesta.AppendText("f (" + con + "): " + x.ToString() + "\n");
            }
        }
    }
}
