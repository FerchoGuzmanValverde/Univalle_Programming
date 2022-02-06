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

namespace PracticaListaDoble_Agregar
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Nodo p = new Nodo();
        int cont = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if(cont == 0)
            {
                //verificamos si el elemento agregado es el primero
                p.info = int.Parse(txtvalor.Text);
                p.sig = null;
                p.ant = null;
                cont++;
                Mostrar(p);
            }
            else
            {
                // Creamos el nodo q y nuestra variable valor con el elemento a agregar
                Nodo q = p;
                int valor = int.Parse(txtvalor.Text);
                //Verificamos si el valor es mayor a un nodo hasta encontrar un nodo que sea mayor
                while(q != null)
                {
                    if(q.info == valor)
                    {
                        MessageBox.Show("El valor ya existe");
                        break;
                    }
                    q = q.sig;
                }
                q = p;
                while (valor > q.info)
                {
                    //creamos el nuevo nodo
                    Nodo nuevo = new Nodo();
                    nuevo.info = valor;
                    //Caso 1: es el ultimo elemento
                    if(q.sig == null)
                    {
                        nuevo.ant = q;
                        nuevo.sig = null;
                        q.sig = nuevo;
                    }
                    //Caso 2: Elemento en medio
                    else if(q.sig.info > valor)
                    {
                        Nodo s = q.sig;
                        q.sig = nuevo;
                        s.ant = nuevo;
                        nuevo.sig = s;
                        nuevo.ant = q;
                    }
                    //Caso 3: El nodo es menor
                    else
                    {
                        q = q.sig;
                    }
                }
                //Verificamos si el valor es menor hasta encontrar un nodo menor. Es inluye p
                while (valor < q.info)
                {
                    //creamos el nuevo nodo
                    Nodo nuevo = new Nodo();
                    nuevo.info = valor;
                    //Caso 1: Es el primer elemento P
                    if(q.ant == null)
                    {
                        nuevo.sig = q;
                        nuevo.ant = null;
                        p = nuevo;
                        q.ant = nuevo;
                    }
                    //Caso 2: Es un elemento en medio
                    else if(q.ant.info < valor)
                    {
                        Nodo s = new Nodo();
                        s = q.ant;
                        s.sig = nuevo;
                        q.ant = nuevo;
                        nuevo.sig = q;
                        nuevo.ant = s;
                    }
                    //Caso 3: el nodo es menor que el valor
                    else
                    {
                        q = q.ant;
                    }
                }
            }
            Mostrar(p);
        }

        public void Mostrar(Nodo l)
        {
            txtMostrar.Clear();
            Nodo q = l;
            while (q != null)
            {
                txtMostrar.AppendText("" + q.info + "\n");
                q = q.sig;
            }
        }

        public void Mostrar1(Nodo l)
        {
            txtMostrar.Clear();
            Nodo q = l;
            while (q.sig != null)
            {
                q = q.sig;
            }
            while(q != null)
            {
                txtMostrar.AppendText("" + q.info + "\n");
                q = q.ant;
            }
        }

        private void btnDesc_Click(object sender, RoutedEventArgs e)
        {
            if (cont == 0)
            {
                //verificamos si el elemento agregado es el primero
                p.info = int.Parse(txtvalor.Text);
                p.sig = null;
                p.ant = null;
                cont++;
                Mostrar(p);
            }
            else
            {
                // Creamos el nodo q y nuestra variable valor con el elemento a agregar
                Nodo q = p;
                int valor = int.Parse(txtvalor.Text);
                //Verificamos si el valor es mayor a un nodo hasta encontrar un nodo que sea mayor
                while (q != null)
                {
                    if (q.info == valor)
                    {
                        MessageBox.Show("El valor ya existe");
                        break;
                    }
                    q = q.sig;
                }
                q = p;
                while (valor > q.info)
                {
                    //creamos el nuevo nodo
                    Nodo nuevo = new Nodo();
                    nuevo.info = valor;
                    //Caso 1: es el ultimo elemento
                    if (q.sig == null)
                    {
                        nuevo.ant = q;
                        nuevo.sig = null;
                        q.sig = nuevo;
                    }
                    //Caso 2: Elemento en medio
                    else if (q.sig.info > valor)
                    {
                        Nodo s = q.sig;
                        q.sig = nuevo;
                        s.ant = nuevo;
                        nuevo.sig = s;
                        nuevo.ant = q;
                    }
                    //Caso 3: El nodo es menor
                    else
                    {
                        q = q.sig;
                    }
                }
                //Verificamos si el valor es menor hasta encontrar un nodo menor. Es inluye p
                while (valor < q.info)
                {
                    //creamos el nuevo nodo
                    Nodo nuevo = new Nodo();
                    nuevo.info = valor;
                    //Caso 1: Es el primer elemento P
                    if (q.ant == null)
                    {
                        nuevo.sig = q;
                        nuevo.ant = null;
                        p = nuevo;
                        q.ant = nuevo;
                    }
                    //Caso 2: Es un elemento en medio
                    else if (q.ant.info < valor)
                    {
                        Nodo s = new Nodo();
                        s = q.ant;
                        s.sig = nuevo;
                        q.ant = nuevo;
                        nuevo.sig = q;
                        nuevo.ant = s;
                    }
                    //Caso 3: el nodo es menor que el valor
                    else
                    {
                        q = q.ant;
                    }
                }
            }
            Mostrar1(p);
        }
    }
}
