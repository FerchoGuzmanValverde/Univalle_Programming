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

namespace FernandoGUZ
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

        private void btnmostrar_Click(object sender, RoutedEventArgs e)
        {
            fecha date = new fecha();
            date.Year = int.Parse(txtanio.Text);
            date.Mes = int.Parse(txtmes.Text);
            date.Dia = int.Parse(txtdia.Text);
            lblbisiesto.Content = date.Bisiesto();
            lblcorto.Content = date.MostrarFechaCorta();
            lbllargo.Content = date.MostrarFechaLarga();
            lblMesLetras.Content = date.MesLetras();
        }
    }
}
