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
    /// Interaction logic for S6.xaml
    /// </summary>
    public partial class S6 : Window
    {
        Secuenciales operar = new Secuenciales();

        public S6()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            validar();
        }

        private void validar()
        {
            if(txtinicial.Text == "" || txtprecio.Text == "")
            { MessageBox.Show("Llene todos los espacios por favor"); }
            else
            {
                double precio, cuota;
                precio = double.Parse(txtprecio.Text);
                cuota = double.Parse(txtinicial.Text);
                lblpcuota.Content = operar.cuota(precio, cuota).ToString("N2");
                lblpfinal.Content = operar.final(precio, cuota).ToString("N2");
                limpiar();
            }
        }

        private void limpiar()
        {
            txtinicial.Clear();
            txtprecio.Clear();
            txtprecio.Focus();
        }
    }
}
