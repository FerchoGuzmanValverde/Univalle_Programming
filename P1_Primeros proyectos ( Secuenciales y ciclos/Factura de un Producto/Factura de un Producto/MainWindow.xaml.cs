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

namespace Factura_de_un_Producto
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
            float cantidad, preciou, monto, preciobruto, descuento;
            cantidad = float.Parse(txtcantidad.Text);
            preciou = float.Parse(txtpreciou.Text);
            monto = preciou * cantidad;
            preciobruto = (monto * 0.16f) + monto;
            if (preciobruto > 50)
                descuento = preciobruto - (preciobruto * 0.05f);
            else
                descuento = preciobruto;
            lblmontofinal.Content = descuento;
            if (preciobruto > 50)
                lbldescuento.Content = "Se le ha hecho un descuento del 5%";
            else
                lbldescuento.Content = "no hay descuento";
            
        }
    }
}
