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

namespace Clase_Persona
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Persona p = new Persona();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, RoutedEventArgs e)
        {
            string nombre = txtnombre.Text;
            byte edad = byte.Parse(txtedad.Text);
            p.Nombre = nombre;
            p.Edad = edad;
            MessageBox.Show("" + p.Nombre);
            txtresult.AppendText(p.registrar() + "\n");
        }

        private void limpiar()
        {
            txtnombre.Clear();
            txtedad.Clear();
            txtnombre.Focus();
        }

        private void txtnombre_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
