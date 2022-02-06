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
    /// Interaction logic for Se5.xaml
    /// </summary>
    public partial class Se5 : Window
    {
        Secuenciales op = new Secuenciales();
        public Se5()
        {
            InitializeComponent();
        }

        private void btnnuevo_Click(object sender, RoutedEventArgs e)
        {
            lblantiguedad.Content = "";
            lblbruto.Content = "";
            lbldescuento.Content = "";
            lblneto.Content = "";
            lblnombre.Content = "";
            lblvhora.Content = "";
            txtantiguedad.Clear();
            txthtrabajadas.Clear();
            txtnombre.Clear();
            txtvhora.Clear();
            txtnombre.Focus();
        }

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            validar();
        }

        private void validar()
        {
            if (txtantiguedad.Text == "" || txthtrabajadas.Text == "" || txtnombre.Text == "" || txtvhora.Text == "")
            {
                MessageBox.Show("Porfavor complete todos los espacios");
            }
            else
            {
                operacion();
            }
        }

        private void operacion()
        {
            float x = op.total(int.Parse(txtvhora.Text), int.Parse(txthtrabajadas.Text), int.Parse(txtantiguedad.Text));
            lblnombre.Content = txtnombre.Text;
            lblantiguedad.Content = txtantiguedad.Text;
            lblvhora.Content = txtvhora.Text;
            lblbruto.Content = x.ToString();
            lbldescuento.Content = (x * 0.13).ToString();
            lblneto.Content = (x * 0.87).ToString();
        }
    }
}
