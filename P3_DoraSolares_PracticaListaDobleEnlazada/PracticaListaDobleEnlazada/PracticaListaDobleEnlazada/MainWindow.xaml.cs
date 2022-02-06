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

namespace PracticaListaDobleEnlazada
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Nodo p;
        byte con = 0;
        public MainWindow()
        {
            InitializeComponent();
            p = new Nodo();
            p.sig = null;
            p.ant = null;
            p.info = 0;
        }

        private void btnInsertar_Click(object sender, RoutedEventArgs e)
        {
            int val = int.Parse(txtinfo.Text);
            if (con == 0)
            {
                p.info = val;
                con++;
            }
            else
            {
                if (val != p.info)
                {
                    Nodo q = new Nodo();
                    if (val < p.info)
                    {
                        q.info = val;
                        q.sig = p;
                        p.ant = q;
                        q.ant = null;
                        p = q;
                    }
                    else
                    {
                        q = p;
                        while (q.sig != null)
                        {
                            if (val != q.sig.info)
                            {
                                if (val < q.sig.info)
                                {
                                    Nodo r = new Nodo();
                                    Nodo s = new Nodo();
                                    s = q.sig;
                                    r.info = val;
                                    r.ant = q;
                                    r.sig = s;
                                    q.sig = r;
                                    s.ant = r;
                                    break;
                                }
                                q = q.sig;
                            }
                            else
                            {
                                MessageBox.Show("El valor ya existe en la lista.");
                                break;
                            }
                        }
                        if (q.sig == null)
                        {
                            if (val != q.info)
                            {
                                Nodo n = new Nodo();
                                n.info = val;
                                n.sig = null;
                                n.ant = q;
                                q.sig = n;
                            }
                            else
                            {
                                MessageBox.Show("El valor ya existe en la lista.");
                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("El valor ya existe en la lista.");
                }
            }
            Mostrar();
        }

        public void Mostrar()
        {
            txtmostrar.Clear();
            Nodo q = p;
            while (q != null)
            {
                txtmostrar.AppendText("" + q.info + "\n");
                q = q.sig;
            }
        }

        private void btndescendente_Click(object sender, RoutedEventArgs e)
        {
            int val = int.Parse(txtinfo.Text);
            if (con == 0)
            {
                p.info = val;
                con++;
            }
            else
            {
                if (val != p.info)
                {
                    Nodo q = new Nodo();
                    if (val > p.info)
                    {
                        q.info = val;
                        q.sig = p;
                        p.ant = q;
                        q.ant = null;
                        p = q;
                    }
                    else
                    {
                        q = p;
                        while (q.sig != null)
                        {
                            if (val != q.sig.info)
                            {
                                if (val > q.sig.info)
                                {
                                    Nodo r = new Nodo();
                                    Nodo s = new Nodo();
                                    s = q.sig;
                                    r.info = val;
                                    r.ant = q;
                                    r.sig = s;
                                    q.sig = r;
                                    s.ant = r;
                                    break;
                                }
                                q = q.sig;
                            }
                            else
                            {
                                MessageBox.Show("El valor ya existe en la lista.");
                                break;
                            }
                        }
                        if (q.sig == null)
                        {
                            if (val != q.info)
                            {
                                Nodo n = new Nodo();
                                n.info = val;
                                n.sig = null;
                                n.ant = q;
                                q.sig = n;
                            }
                            else
                            {
                                MessageBox.Show("El valor ya existe en la lista.");
                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("El valor ya existe en la lista.");
                }
            }
            Mostrar();
        }
    }
}
