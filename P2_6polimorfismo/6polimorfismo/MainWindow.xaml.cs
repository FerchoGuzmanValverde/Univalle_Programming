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

namespace _6polimorfismo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            double r, a;
            r = Convert.ToDouble(txtr.Text);
            circulo c1 = new circulo(r);
            a = c1.calc_area();
            txta.Text = Convert.ToString(a);
            MessageBox.Show(c1.mostrar());
        }

        private void btnareaC_Click(object sender, RoutedEventArgs e)
        {
            double r, a, ar;
            r = Convert.ToDouble(txtrC.Text);
            a = Convert.ToDouble(txth.Text);
            cilindro ci1 = new cilindro(r, a);
            ar = ci1.calc_area();
            txtaC.Text = Convert.ToString(ar);
            MessageBox.Show(ci1.mostrar());

        }
    }
}
