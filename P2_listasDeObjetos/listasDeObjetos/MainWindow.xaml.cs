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

namespace listasDeObjetos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<persona> lista_personas = new List<persona>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            string n;
            int c;
            n = txtnombre.Text;
            c = Convert.ToInt32(txtci.Text);
            persona p = new persona(n, c);
            lista_personas.Add(p);
            MessageBox.Show("Los datos fueron registrados");
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {       
            foreach(persona p in lista_personas)
            {
                lstNombre.Items.Add(p.Nombre);
                lstCi.Items.Add(p.Carnet);
            }
            
            //dataP.ItemsSource = lista_personas;
        }

        private void btnbuscar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(lista_personas.ElementAt(int.Parse(txtbuscar.Text)-1).Nombre + "\n" + lista_personas.ElementAt(int.Parse(txtbuscar.Text)-1).Carnet);
        }

        private void btnmodificar_Click(object sender, RoutedEventArgs e)
        {
            lstNombre.Items.RemoveAt(int.Parse(txtbuscar.Text) - 1);
            lstCi.Items.RemoveAt(int.Parse(txtbuscar.Text) - 1);
            lista_personas.ElementAt(int.Parse(txtbuscar.Text)-1).Nombre = txtnombre.Text;
            lista_personas.ElementAt(int.Parse(txtbuscar.Text)-1).Carnet = int.Parse(txtci.Text);
            lstNombre.Items.Insert(int.Parse(txtbuscar.Text) - 1, txtnombre.Text);
            lstCi.Items.Insert(int.Parse(txtbuscar.Text) - 1, txtci.Text);
        }

        private void btneliminar_Click(object sender, RoutedEventArgs e)
        {
            lstCi.Items.RemoveAt(int.Parse(txtbuscar.Text) - 1);
            lstNombre.Items.RemoveAt(int.Parse(txtbuscar.Text) - 1);
            lista_personas.RemoveAt(int.Parse(txtbuscar.Text) - 1);
        }
    }
}
