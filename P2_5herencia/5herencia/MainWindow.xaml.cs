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

namespace _5herencia
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

        private void btnEdad_Click(object sender, RoutedEventArgs e)
        {
            string n;
            int a, e1, aa;
            n = txtnombre.Text;
            a = Convert.ToUInt16(txtan.Text);
            aa = Convert.ToInt16(txtaa.Text);
            //persona p1 = new persona(n, a);
            //e1 = p1.calcular_edad(aa);
            //txtedad.Text = Convert.ToString(e1);

        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            string n;
            int a, e1, aa;
            double s;
            n = txtnombreE.Text;
            a = Convert.ToUInt16(txtanE.Text);
            aa = Convert.ToInt16(txtaaE.Text);
            s = Convert.ToDouble(txts.Text);

            empleado emp = new empleado(n, a, s);

            e1 = emp.calcular_edad(aa);
            txteE.Text = Convert.ToString(e1);
            s = emp.calc_sueldo();
            txtsE.Text = Convert.ToString(s);
        }
    }
}
