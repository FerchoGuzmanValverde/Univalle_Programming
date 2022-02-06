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
    /// Interaction logic for Con3.xaml
    /// </summary>
    public partial class Con3 : Window
    {
        Condicionales op = new Condicionales();
        Random num = new Random();
        int random, numero, con = 0;
        public Con3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            random = num.Next(1, 101);
            lblrespuesta1.Content = "-----";
            lblrespuesta2.Content = "-----";
            txtnumero.Clear();
            txtnumero.Focus();
            con = 0;
        }

        private void btncomprobar_Click(object sender, RoutedEventArgs e)
        {
            numero = int.Parse(txtnumero.Text);
            validar();
            limpiar();
        }

        private void limpiar()
        {
            txtnumero.Clear();
            txtnumero.Focus();
        }

        private void validar()
        {
            if(txtnumero.Text == "" || numero <= 0 || numero >= 101)
            {
                MessageBox.Show("Porfavor ingrese un valor valido");
            }
            else
            {
                lblrespuesta1.Content = op.comprobante(numero, random);
                lblrespuesta2.Content = op.operador(con, numero, random);
            }
        }
    }
}
