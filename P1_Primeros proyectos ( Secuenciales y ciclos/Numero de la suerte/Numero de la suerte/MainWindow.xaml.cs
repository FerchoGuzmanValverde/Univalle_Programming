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

namespace Numero_de_la_suerte
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

        private void btnnsuerte_Click(object sender, RoutedEventArgs e)
        {
            int d, m, a, suma, nsuerte = 0, res, num;
            d = int.Parse(txtdia.Text);
            m = int.Parse(txtmes.Text);
            a = int.Parse(txtyear.Text);
            suma = (d + m) + a;
            while (suma > 0)
            {
                res = suma % 10;
                num = suma / 10;
                nsuerte = nsuerte + res;
            }
            MessageBox.Show("tu numero de la suerte es: " +nsuerte);
        }
    }
}
