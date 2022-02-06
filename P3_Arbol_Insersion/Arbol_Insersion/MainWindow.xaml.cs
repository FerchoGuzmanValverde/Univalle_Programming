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

namespace Arbol_Insersion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Nodo raiz = new Nodo();
        Nodo q;
        int primero = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, RoutedEventArgs e)
        {
            int valor = int.Parse(txtIsertar.Text);
            if(primero == 0)
            {
                raiz.valor = valor;
                raiz.derecha = null;
                raiz.izquierda = null;
                primero = 1;
            }
            else
            {
                q = raiz;
                bool insertado = false;
                Nodo nuevo = new Nodo();
                nuevo.valor = valor;
                while(insertado != true)
                {
                    if(nuevo.valor > q.valor)
                    {
                        if(q.derecha == null)
                        {
                            q.derecha = nuevo;
                            nuevo.izquierda = null;
                            nuevo.derecha = null;
                            insertado = true;
                        }
                        else
                        {
                            q = q.derecha;
                        }
                    }
                    else
                    {
                        if(q.izquierda == null)
                        {
                            q.izquierda = nuevo;
                            nuevo.derecha = null;
                            nuevo.izquierda = null;
                            insertado = true;
                        }
                        else
                        {
                            q = q.izquierda;
                        }
                    }
                }
            }
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            PreOrden(raiz);
            txtMostrar.AppendText("\n");
            EnOrden(raiz);
            txtMostrar.AppendText("\n");
            PostOrden(raiz);
        }

        public void PreOrden(Nodo r)
        {
            txtMostrar.AppendText(r.valor.ToString()+" ");
            if (r.izquierda != null)
            {
                PreOrden(r.izquierda);
            }
            if(r.derecha != null)
            { 
                PreOrden(r.derecha);
            }
        }

        public void EnOrden(Nodo r)
        {
            if (r.izquierda != null)
            {
                EnOrden(r.izquierda);
            }
            txtMostrar.AppendText(r.valor.ToString() + " ");
            if (r.derecha != null)
            {
                EnOrden(r.derecha);
            }
        }

        public void PostOrden(Nodo r)
        {
            if (r.izquierda != null)
            {
                PostOrden(r.izquierda);
            }
            if (r.derecha != null)
            {
                PostOrden(r.derecha);
            }
            txtMostrar.AppendText(r.valor.ToString() + " ");
        }
    }
}
