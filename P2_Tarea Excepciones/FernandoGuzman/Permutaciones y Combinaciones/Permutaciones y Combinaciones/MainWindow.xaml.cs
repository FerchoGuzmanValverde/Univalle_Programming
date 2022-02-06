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

namespace Permutaciones_y_Combinaciones
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
            int num1, num2;
            try
            {
                num1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Popularidad: ", "Poblacion"));
                num2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Numero de grupos: ", "Grupos"));
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Solo puede ingresar enteros, por favor intente de nuevo. " + ex.Message);
                return;
            }
            try
            {
                if (rbtpermutaciones.IsChecked == true)
                    MessageBox.Show(Permutaciones(num1, num2));
                if (rbtcombinaciones.IsChecked == true)
                    MessageBox.Show(Combinaciones(num1, num2));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Necesita seleccionar una operacion antes de calcular, por favor intente de nuevo. " + ex.Message);
            }
        }

        string Combinaciones(int x, int y)
        {
            try
            {
                return "El resultado es: " + (fac(x) / (fac(x - y) * fac(y))).ToString();
            }
            catch(Exception ex)
            {
                return ("Ha ocurrido un error en la operacion. " + ex.Message);
            }
        }

        string Permutaciones(int x, int y)
        {
            try
            {
                return "El resultado es: " + (fac(x) / fac(x - y)).ToString();
            }
            catch(Exception ex)
            {
                return "Ha ocurrido un error. " + ex.Message;
            }
        }

        int fac(int x)
        {
            int res = 1, a = 2;
            for (int i = 1; i < x; i++)
            {
                res = res * a;
                a++;
            }
            return res;
        }
    }
}
