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

namespace PracticaEventos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Tele tele = new Tele();
        public delegate void MiDelegado();
        public event MiDelegado miEvento;

        public MainWindow()
        {
            InitializeComponent();
            tele.Show();
        }

        private void btnChMas_Click(object sender, RoutedEventArgs e)
        {
            this.miEvento += tele.SubirCanal;
            miEvento();
            this.miEvento -= tele.SubirCanal;
        }

        private void btnChMenos_Click(object sender, RoutedEventArgs e)
        {
            this.miEvento += tele.BajarCanal;
            miEvento();
            this.miEvento -= tele.BajarCanal;
        }

        private void btnVMas_Click(object sender, RoutedEventArgs e)
        {
            this.miEvento += tele.SubirVolumen;
            miEvento();
            this.miEvento -= tele.SubirVolumen;
        }

        private void btnVMenos_Click(object sender, RoutedEventArgs e)
        {
            this.miEvento += tele.BajarVolumen;
            miEvento();
            this.miEvento -= tele.BajarVolumen;
        }

        private void btnEncender_Click(object sender, RoutedEventArgs e)
        {
            this.miEvento += tele.Encender;
            miEvento();
            this.miEvento -= tele.Encender;
        }

        private void btnApagar_Click(object sender, RoutedEventArgs e)
        {
            this.miEvento += tele.Apagar;
            miEvento();
            this.miEvento -= tele.Apagar;
        }
    }
}
