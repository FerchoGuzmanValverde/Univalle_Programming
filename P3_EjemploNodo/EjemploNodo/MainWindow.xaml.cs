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

namespace EjemploNodo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Nodo p;
        int cont = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnañadir_Click(object sender, RoutedEventArgs e)
        {
            //boton añadir
            int info = int.Parse(txtIngresar.Text);
            
            if(cont == 0)
            {
                p = new Nodo();
                p.info = info;
                p.sig = null;
                cont++;
            }
            else
            {
                Nodo q = new Nodo();
                q = p;
                //recorremos la lista de nodos
                while (q.sig != null)
                {
                    q = q.sig;
                }
                Nodo nuevo = new Nodo();
                nuevo.info = info;
                nuevo.sig = null;
                q.sig = nuevo;
                cont++;
            }

        }

        private void btnVer_Click(object sender, RoutedEventArgs e)
        {
            txtLista.Text = "";
            Nodo q;
            q = p;
            //recorremos la lista de nodos
            while (q != null)
            {
                txtLista.AppendText(q.info + "\n");
                q = q.sig;
            }
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            int info = int.Parse(txtIngresar.Text);

            if (info == p.info)
            {
                p = p.sig;
            }
            else
            {
                Nodo q = new Nodo();
                Nodo r = new Nodo();
                r = null;
                q = p;
                //recorremos la lista de nodos
                while (q != null)
                {
                    if(q.info == info)
                    {
                        r.sig = q.sig;
                        q.sig = null;
                    }
                    r = q;
                    q = q.sig;
                }
            }
        }
    }
}
