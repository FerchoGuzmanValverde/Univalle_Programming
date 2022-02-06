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

namespace nodos
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int aux_info = Convert.ToInt32(txtm1.Text);
            if (cont==0)
            {
                p = new Nodo();
                p.info = aux_info;
                p.sig = null;
                cont++;
            }
            else
            {
                Nodo q = new Nodo();
                q = p;
                while (q.sig != null)
                {
                    q = q.sig;
                }
                Nodo nuevo = new Nodo();
                nuevo.info = aux_info;
                nuevo.sig = null;
                q.sig = nuevo;
                cont++;
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Nodo q = new Nodo();
            q = p;
            
            while (q != null)
            {
                txtm2.AppendText(q.info + "\n ");
                q = q.sig;
               
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int aux_info = Convert.ToInt32(txteliminar.Text);
            Eliminarnodo(aux_info);
        }
        public void Eliminarnodo(int valor)
        {
            Nodo r = p;
            Nodo q = r.sig;

            if (r.info == valor)
            {
                p = r.sig;
                
            }
            
                while (q.sig != null)
                {
                    if (r.sig.info == valor)
                    {
                        r.sig = q.sig;
                        q.sig = null;
                        r = q;
                        q = q.sig;
                    }
                }
                
            
            while (q!=null)
            {
                
                if (q.info==valor)
                {

                    r.sig=null;
                   

                }
            }
        }
    }
}
