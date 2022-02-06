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

namespace EjemploStackPanel
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

        private void btnmostrar1_Click(object sender, RoutedEventArgs e)
        {
            string nombre;
            int edad;
            edad = int.Parse(txtedad1.Text);
            nombre = txtnombre1.Text;

            txtmostrar1.Text = "El Nombre es: " + nombre + " y su edad es: " + edad;
        }

        private void btnmostrar_Click(object sender, RoutedEventArgs e)
        {
            string nombre1;
            int edad1;
            edad1 = int.Parse(txtedad.Text);
            nombre1 = txtnombre.Text;

            txtmostrar.Text = "El Nombre es: " + nombre1 + " y su edad es: " + edad1;
        }
    }
}
