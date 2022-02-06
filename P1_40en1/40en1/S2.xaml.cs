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
    /// Interaction logic for S2.xaml
    /// </summary>
    public partial class S2 : Window
    {
        Secuenciales ope = new Secuenciales();
        public S2()
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
            txtparcial1.Clear();
            txtparcial2.Clear();
            txtparcial3.Clear();
            txtparcial1.Focus();
        }

        private void validar()
        {
            if (txtparcial1.Text == "" || txtparcial2.Text == "" || txtparcial3.Text == "")
            {
                MessageBox.Show("Porfavor ingrese todos los valores");
            }
            else
            {
                MessageBox.Show(ope.promedio(float.Parse(txtparcial1.Text), float.Parse(txtparcial2.Text), float.Parse(txtparcial3.Text)).ToString());
            }
        }
    }
}
