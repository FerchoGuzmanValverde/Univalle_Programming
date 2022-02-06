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

namespace Operaciones_Math
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int num1, num2;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            if (rbtdivition.IsChecked == true)
            {
                txtrespuesta.Clear();
                value2();
                txtrespuesta.AppendText(divition(num1, num2).ToString());
            }
            if (rbtexponential.IsChecked == true)
            {
                txtrespuesta.Clear();
                value2();
                txtrespuesta.AppendText(exponential(num1, num2).ToString());
            }
            if (rbtfactorial.IsChecked == true)
            {
                txtrespuesta.Clear();
                value1();
                txtrespuesta.AppendText(factorial(num1).ToString());
            }
            if (rbtmultiplication.IsChecked == true)
            {
                txtrespuesta.Clear();
                value2();
                txtrespuesta.AppendText(multiplicacion(num1, num2).ToString());
            }
        }

        int divition(int x, int y)
        {
            int res = num1, con = 0;
            while(res > 1)
            {
                res = res - num2;
                con++;
            }
            return con;
        }

        int multiplicacion(int x, int y)
        {
            int res = 0;
            for (int i = 1; i <= num2; i++)
            {
                res = res + num1;
            }
            return res;
        }

        int factorial(int x)
        {
            int res = 1;
            for (int i = 1; i <= num1; i++)
            {
                res = res * i;
            }
            return res;
        }

        int exponential(int x, int y)
        {
            int res = 1;
            for (int i = 0; i < y; i++)
            {
                res = res * x;
            }
            return res;
        }

        private void value1()
        {
            num1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese aqui numero"));
        }

        private void value2()
        {
            num1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese aqui numero"));
            num2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese aqui numero"));
        }
    }
}
