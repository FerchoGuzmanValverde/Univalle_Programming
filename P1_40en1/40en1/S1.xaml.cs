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
    /// Interaction logic for S1.xaml
    /// </summary>
    public partial class S1 : Window
    {
        Secuenciales E1 = new Secuenciales();
        public S1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            validar();
            nuevo();
        }

        private void nuevo()
        {
            txtpago.Clear();
            txtdia.Clear();
            txtdia.Focus();
        }

        private void validar()
        {
            if(txtdia.Text == "")
            {
                MessageBox.Show("Porfavor ingrese numero de dias trabajados");
            }
            else if(txtpago.Text == "")
            {
                MessageBox.Show("Porfavor ingrese pago por dia");
            }
            else
            {
                MessageBox.Show("El salario es: " + E1.salario(int.Parse(txtdia.Text), int.Parse(txtpago.Text)));
            }
        }
    }
}
