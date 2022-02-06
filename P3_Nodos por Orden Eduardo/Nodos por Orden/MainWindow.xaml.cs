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

namespace Nodos_por_Orden
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        nodo p = new nodo();
        int cont = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void mostrar(nodo lista)
        {
            txtLista.Clear();
            nodo s = new nodo();
            s = lista;
            while (s != null)
            {
                txtLista.AppendText("" + s.info + "\n");
                s = s.sig;
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (cont ==0)
            {
                p.info = Convert.ToInt32(txtIngresar.Text);
                p.sig = null;
                p.ant = null;
                cont++;
                mostrar(p);
            }
            else
            {
                nodo q = p;
                while (Convert.ToInt32(txtIngresar.Text) > q.info )
                {
                    if (q.sig==null)
                    {
                        nodo nuevo = new nodo();
                        nuevo.info = Convert.ToInt32(txtIngresar.Text);
                        nuevo.sig = null;
                        nuevo.ant = q;
                        q.sig = nuevo;
                        mostrar(p);
                    }
                    else if(Convert.ToInt32(txtIngresar.Text)<q.sig.info)
                    {
                        nodo entremedio = q;
                        entremedio = entremedio.sig;
                        nodo nuevo = new nodo();
                        nuevo.info = Convert.ToInt32(txtIngresar.Text);
                        nuevo.sig = entremedio;
                        nuevo.ant = q;
                        q.sig = nuevo;
                        entremedio.ant = nuevo;
                        mostrar(p);
                    }
                    else
                    {
                        q = q.sig;
                    }
                }
                while (Convert.ToInt32(txtIngresar.Text) < q.info )
                {
                    if (q.ant==null)
                    {
                        nodo nuevo = new nodo();
                        nuevo.info = Convert.ToInt32(txtIngresar.Text);
                        nuevo.sig = q;
                        nuevo.ant = null;
                        q.ant = nuevo;
                        p = nuevo;
                        mostrar(p);
                    }
                    else if(Convert.ToInt32(txtIngresar.Text) > q.ant.info)
                    {
                        nodo entremedio = q;
                        entremedio = entremedio.ant;
                        nodo nuevo = new nodo();
                        nuevo.info = Convert.ToInt32(txtIngresar.Text);
                        nuevo.sig = q;
                        nuevo.ant = entremedio;
                        q.ant = nuevo;
                        entremedio.sig = nuevo;
                        nodo qwe = p;
                        while (qwe.ant!=null)
                        {
                            qwe = qwe.ant;
                        }
                        p = qwe;
                        mostrar(p);
                    }
                    else
                    {
                        q = q.ant;
                    }
                }

            }
            
        }
    }
}
