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

namespace FernandoGuzmanValverde
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCostoDecoracionN_Click(object sender, RoutedEventArgs e)
        {
            bool dec;
            if(rbtSiDecoracionN.IsChecked == true)
                dec = true;
            else 
                dec = false;
            Fiesta Fest = new Fiesta(int.Parse(txtnroPersonasN.Text), double.Parse(txtsotoComidaN.Text), dec);
            lblDecoracionN.Content = Fest.CalcularCostoDecoracion();
        }

        private void btnCostoComidaN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDestallarN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnComidaG_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDecoracionG_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDetallarG_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDetallarC_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
