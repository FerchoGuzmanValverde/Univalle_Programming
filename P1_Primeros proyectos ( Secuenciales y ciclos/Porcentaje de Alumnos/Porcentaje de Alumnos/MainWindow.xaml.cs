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

namespace Porcentaje_de_Alumnos
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            int num1, num2, varones, mujeres, total;
            num1 = Convert.ToInt32(txtmujeres.Text);
            num2 = Convert.ToInt32(txtvarones.Text);
            total = num1 + num2;
            varones = num2 * 100 / (num1 + num2);
            mujeres = num1 * 100 / (num1 + num2);
            lblmujeres.Content = mujeres.ToString() + "%";
            lblvarones.Content = varones.ToString() + "%";
            lbltotal.Content = total.ToString();
        }

        private void btnlimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtmujeres.Clear();
            txtvarones.Clear();
            lbltotal.Content = "";
            lblmujeres.Content = "";
            lblvarones.Content = "";
        }

        private void btnsalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
