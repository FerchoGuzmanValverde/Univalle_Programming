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
    /// Interaction logic for Ci5.xaml
    /// </summary>
    public partial class Ci5 : Window
    {
        Ciclos op = new Ciclos();
        public Ci5()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            lblrespuesta.Content = op.raiz(int.Parse(txtnumero.Text));
        }
    }
}
