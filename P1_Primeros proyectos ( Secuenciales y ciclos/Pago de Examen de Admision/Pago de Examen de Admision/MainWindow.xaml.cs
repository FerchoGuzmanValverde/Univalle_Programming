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

namespace Pago_de_Examen_de_Admision
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
            string colegio, categoria;
            int pago;
            colegio = txtcolegio.Text;
            categoria = txtcategoria.Text;
            if (colegio == "Estatal")
                if (categoria == "A")
                    pago = 300;
                else
                {
                    if (categoria == "B")
                        pago = 200;
                    else
                        pago = 100;
                }
            else
            {
                if (categoria == "A")
                    pago = 400;
                else
                {
                    if (categoria == "B")
                        pago = 300;
                    else
                        pago = 200;
                }
            }
            lblrespuesta.Content = pago;
        }
    }
}
