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

namespace Sistema_de_Supermercado
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

        private void btndescuento_Click(object sender, RoutedEventArgs e)
        {
            float monto;
            monto = float.Parse(txtmonto.Text);
            if (monto > 5000)
            {
                lblmontoapagar.Content = monto - (monto * 0.3f);
                lbldescuento.Content = "Tiene un descuento del 30%";
            }
            else
            {
                if (monto <= 5000 && monto > 3000)
                {
                    lblmontoapagar.Content = monto - (monto * 0.2f);
                    lbldescuento.Content = "Tiene un descuento del 20%";
                }
                else
                {
                    if (monto <= 3000 && monto > 1000)
                    {
                        lblmontoapagar.Content = monto - (monto * 0.1f);
                        lbldescuento.Content = "Tiene un descuento del 10%";
                    }
                    else
                    {
                        lblmontoapagar.Content = monto;
                        lbldescuento.Content = "Su compra no tiene descuento";
                    }
                }
            }
            
        }
    }
}
