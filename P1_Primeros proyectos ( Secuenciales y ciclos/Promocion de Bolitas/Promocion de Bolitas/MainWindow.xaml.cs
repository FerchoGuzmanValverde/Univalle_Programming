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

namespace Promocion_de_Bolitas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random num1 = new Random();
        string sorteo;
        int numS;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnsortear_Click(object sender, RoutedEventArgs e)
        {
            numS = num1.Next(1, 6);
            if (numS == 1 || numS == 2)
            {
                if (numS == 1)
                {
                    sorteo = "Negro";
                    lblDespecificacion.Content = "10% de descuento";
                }
                else
                {
                    sorteo = "Verde";
                    lblDespecificacion.Content = "25% de descuento";
                }
            }
            else
            {
                if (numS == 3)
                {
                    sorteo = "Amarillo";
                    lblDespecificacion.Content = "50% de descuento";
                }
                else
                {
                    if (numS == 4)
                    {
                        sorteo = "Azul";
                        lblDespecificacion.Content = "75% de descuento";
                    }
                    else
                        sorteo = "Rojo";
                        lblDespecificacion.Content = "100% de descuento";
                }
            }
            lblcolor.Content = sorteo;

        }

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            float montoC, pago;
            montoC = float.Parse(txtmontoi.Text);
            if (numS == 1)
                pago = montoC - (montoC * 0.1f);
            else
            {
                if (numS == 2)
                    pago = montoC - (montoC * 0.25f);
                else
                {
                    if (numS == 3)
                        pago = montoC - (montoC * 0.5f);
                    else
                    {
                        if (montoC == 4)
                            pago = montoC - (montoC * 0.75f);
                        else
                            pago = montoC - montoC;
                    }
                }
            }

            lblnmonto.Content = pago;


            
        }
    }
}
