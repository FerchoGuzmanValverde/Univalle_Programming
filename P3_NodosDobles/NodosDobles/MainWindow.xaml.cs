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

namespace NodosDobles
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Nodo p;
        public MainWindow()
        {
            InitializeComponent();
            p = new Nodo();
            p.sig = null;
            p.ant = null;
            p.info = 0;
        }

        public void Mostrar(Nodo l)
        {
            txtmostrar.Clear();
            Nodo q = l.sig;
            while (q != null)
            {
                txtmostrar.AppendText("" + q.info + "\n");
                q = q.sig;
            }
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Nodo q = p;
            while (q.sig != null)
            {
                q = q.sig;
            }
            Nodo n = new Nodo();
            n.info = Convert.ToInt32(txtvalor.Text);
            n.sig = null;
            n.ant = q;
            q.sig = n;
            Mostrar(p);
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            bool encontrado = false;
            int aux = int.Parse(txtvalor.Text);
            Nodo q = p;
            while (q != null)
            {
                if ( q.info == aux)
                {
                    encontrado = true;
                    break;
                }
                q = q.sig;
            }
            if (encontrado == true)
            {
                if (q.sig == null)
                {
                    Nodo s = q;
                    q = q.ant;
                    q.sig = null;
                    s.ant = null;
                }
                else
                {
                    Nodo r = q;
                    Nodo s = q;
                    r = r.ant;
                    r.sig = q.sig;
                    q = q.sig;
                    q.ant = r;
                    s.sig = null; s.ant = null;
                }
                Mostrar(p);
            }
            else
            {
                MessageBox.Show("El elemento no existe");
            }
        }
    }
}