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

namespace Raiz_de_ecuacion_de_2do_grado
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
            double num1, num2, num3, total1, total2;
            try
            {
                num1 = Convert.ToDouble(txtA.Text);
                num2 = Convert.ToDouble(txtB.Text);
                num3 = Convert.ToDouble(txtC.Text);
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Necesita ingresar datos numericos.\n" + ex.Message);
                return;
            }
            try
            {
                total1 = (-num2 + (Math.Sqrt((num2 * num2) - (4 * num1 * num3)))) / (2 * num1);
                total2 = (-num2 - (Math.Sqrt((num2 * num2) - (4 * num1 * num3)))) / (2 * num1);
            }
            catch(DivideByZeroException cero)
            {
                MessageBox.Show("Error.. " + cero.Message);
                return;
            }
            lblX.Content = total1.ToString();
            lblY.Content = total2.ToString();

        }
    }
}
