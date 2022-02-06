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
using System.IO;

namespace archivos_binarios
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Persona[] personas = new Persona[10];
        int cont;
        Persona person;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAlmacenar_Click(object sender, RoutedEventArgs e)
        {
            person = new Persona(txtci.Text, txtnombre.Text);
            person.almacenar();
            enLista();
            MessageBox.Show("Se ha almacenado la persona");
        }

        private void btnRecuperar_Click(object sender, RoutedEventArgs e)
        {
            person = new Persona(txtci.Text, txtnombre.Text);
            listNombre.Items.Clear();
            listCi.Items.Clear();
            listNombre.Items.Add(person.NOMBRE);
            listCi.Items.Add(person.CARNET);
        }

        private void btnsalir_Click(object sender, RoutedEventArgs e)
        {
            FileStream f = null;
            BinaryWriter bw = null;
            int aux = 0;
            f = new FileStream("d:/vector.data", FileMode.Append, FileAccess.Write);
            bw = new BinaryWriter(f);
            while (aux < personas.Length)
            {
                bw.Write(personas[aux].NOMBRE);
                bw.Write(personas[aux].CARNET);
                aux++;
            }

            if (bw != null)
            {
                bw.Close();
            }
            if (f != null)
            {
                f.Close();
            }
        }

        private void enLista()
        {
            personas[cont] = person;
            cont++;
        }

        private void btnrescuperarLista_Click(object sender, RoutedEventArgs e)
        {
            int aux = 0;
            FileStream f = null;
            BinaryReader br = null;
            f = new FileStream("d:/vector.data", FileMode.Open);
            br = new BinaryReader(f);

            while (br.PeekChar() != -1)
            {
                personas[aux].NOMBRE = br.ReadString();
                personas[aux].CARNET = br.ReadString();
            }

            mostrar();

            if (br != null)
            {
                br.Close();
            }
            if (f != null)
            {
                f.Close();
            }
        }

        private void mostrar()
        {
            int aux = 0;
            while (aux < personas.Length)
            {
                lstNombres.Items.Add(personas[aux].NOMBRE);
                lstNombres.Items.Add(personas[aux].CARNET);
                aux++;
            }
        }
    }
}
