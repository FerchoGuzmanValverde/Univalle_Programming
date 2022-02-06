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
    /// Interaction logic for Con4.xaml
    /// </summary>
    public partial class Con4 : Window
    {
        Condicionales op = new Condicionales();
        int monto;
        public Con4()
        {
            InitializeComponent();
        }

        private void btnsorteo_Click(object sender, RoutedEventArgs e)
        {
            monto = int.Parse(txtmonto.Text);
            validar();
        }

        private void validar()
        {
            if(txtmonto.Text == "")
            { MessageBox.Show("Porfavor, ingrese un monto"); }
            else
            {
                string sorteado = op.sorteo();
                lblcolor.Content = sorteado;
                lbldescuento.Content = op.descuento(monto, sorteado);
                lblmfinal.Content = monto - op.descuento(monto, sorteado);
            }
        }
    }
}
