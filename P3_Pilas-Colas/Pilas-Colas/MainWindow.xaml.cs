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

namespace Pilas_Colas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Nodo p = new Nodo();
        Nodo x = new Nodo(); 
        int cont = 0;
        int cola = 0;
        Nodo q; 
        Nodo y = new Nodo();
        public MainWindow()
        {
            InitializeComponent();
        }

        //PUSH DE PILA
        private void btnPush_Click(object sender, RoutedEventArgs e)
        {
            int info = int.Parse(txtValor.Text);

            if (cont > 4)
            {
                MessageBox.Show("La pila esta llena. No puede ingresar mas valores.");
            }
            else
            {
                if (cont == 0)
                {
                    p.valor = info;
                    p.sig = null;
                    cont++;
                    txtMostrar.AppendText(p.valor.ToString());
                }
                else
                {
                    q = new Nodo();
                    q.sig = p;
                    q.valor = info;
                    p = q;
                    txtMostrar.AppendText(p.valor.ToString());
                    cont++;
                }
            }
        }

        //POP DE PILA
        private void btnPop_Click(object sender, RoutedEventArgs e)
        {
            if(p == null)
            {
                MessageBox.Show("La pila esta vacia.");
                cont = 0;
            }
            else
            {
                txtMostrar.Text = "";
                txtMostrar.Text = p.valor.ToString();

                p = p.sig;
            }
            
        }

        //PUSH DE COLA
        private void btnPushCola_Click(object sender, RoutedEventArgs e)
        {
            int info = int.Parse(txtValor.Text);

            if (cola > 4)
            {
                MessageBox.Show("La pila esta llena. No puede ingresar mas valores.");
            }
            else
            {
                if (cola == 0)
                {
                    x.valor = info;
                    x.sig = null;
                    txtMostrar.AppendText(x.valor.ToString());
                    cola++;
                }
                else
                {
                    y = x;
                    while (y.sig != null)
                    {
                        y = y.sig;
                    }
                    Nodo nuevo = new Nodo();
                    nuevo.valor = info;
                    nuevo.sig = null;
                    y.sig = nuevo;
                    txtMostrar.AppendText(nuevo.valor.ToString());
                    cola++;
                }
            }
        }

        //POP DE COLA
        private void btnPopCola_Click(object sender, RoutedEventArgs e)
        {
            if (x == null)
            {
                MessageBox.Show("La cola esta vacia.");
                cola = 0;
            }
            else
            {
                txtMostrar.Text = "";
                txtMostrar.Text = x.valor.ToString();

                x = x.sig;
            }
        }
    }
}
