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

namespace Buscador
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Acciones operacion = new Acciones();
        string nombre, apellido;
        int peso, estatura;
        double imc;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, RoutedEventArgs e)
        {
            validar();
        }

        private void validar()
        {
            if(txtnombre.Text == "" || txtapellido.Text == "" || txtestatura.Text == "" || txtpeso.Text == "")
            {
                MessageBox.Show("Llenar todos los datos para registrar");
            }
            else
            {
                operacion.Nombre = txtnombre.Text;
                operacion.Peso = int.Parse(txtpeso.Text);
                operacion.Estatura = double.Parse(txtestatura.Text);
                operacion.Apellido = txtapellido.Text;
                lstcodigo.Items.Add(operacion.Codigo());
                lstpeso.Items.Add(txtpeso.Text);
                lstestatura.Items.Add(txtestatura.Text);
                lstIMC.Items.Add(operacion.IMC(imc).ToString("N2"));
                lstobservacion.Items.Add(operacion.observacion(operacion.IMC(imc)));
                nuevo();
            }
        }

        private void nuevo()
        {
            txtapellido.Clear();
            txtnombre.Clear();
            txtestatura.Clear();
            txtpeso.Clear();
            txtnombre.Focus();
        }

        private void btnbuscar_Click(object sender, RoutedEventArgs e)
        {
            validarbusca();
            txtbuscar.Clear();
        }

        private void validarbusca()
        {
            if(txtbuscar.Text == "")
            { MessageBox.Show("Necesita ingresar un codigo para la busqueda"); }
            else
            {
                string code = txtbuscar.Text;
                buscar(code);
            }
        }

        private void buscar(string codigo)
        {
            int pos = lstcodigo.Items.IndexOf(codigo);
            MessageBox.Show("Codigo: " + lstcodigo.Items.GetItemAt(pos) + "\nPeso: " + lstpeso.Items.GetItemAt(pos) + "\nEstatura: " + lstestatura.Items.GetItemAt(pos) + "\nIMC: " + lstIMC.Items.GetItemAt(pos) + "\nObservacion: " + lstobservacion.Items.GetItemAt(pos));
        }

        private void btneliminar_Click(object sender, RoutedEventArgs e)
        {
            int idx = lstcodigo.Items.IndexOf(txteliminar.Text);
            lstcodigo.Items.RemoveAt(idx);
            lstestatura.Items.RemoveAt(idx);
            lstIMC.Items.RemoveAt(idx);
            lstobservacion.Items.RemoveAt(idx);
            lstpeso.Items.RemoveAt(idx);
            txteliminar.Clear();
        }

        private void btntotalregistrado_Click(object sender, RoutedEventArgs e)
        {
            lbltotalregistrado.Content = "";
            lbltotalregistrado.Content = lstcodigo.Items.Count;
        }
    }
}
