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

namespace WpfApp1
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

        private void btntabla_Click(object sender, RoutedEventArgs e)
        {
            int numero, tabla = 0;
            numero = int.Parse(txtnumero.Text);
            while (tabla < 1001)
            {
                tabla = numero *= 1;
            }
            ltstabla.Items.Add(tabla);
        }
    }
}
