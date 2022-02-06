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
        float n1, n2;
        Aritmetica op = new Aritmetica();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            valores();
            if (rbtsumar.IsChecked == true)
                lblrespuesta.Content = op.suma(n1, n2);
            else if (rbtrestar.IsChecked == true)
                lblrespuesta.Content = op.resta(n1, n2);
            else if (rbtmultiplicar.IsChecked == true)
                lblrespuesta.Content = op.multiplicacion(n1, n2);
            else if (rbtdividir.IsChecked == true)
                lblrespuesta.Content = op.divicion(n1, n2);
        }

        void valores()
        {
            n1 = float.Parse(txtn1.Text);
            n2 = float.Parse(txtn2.Text);
        }

    }
}
