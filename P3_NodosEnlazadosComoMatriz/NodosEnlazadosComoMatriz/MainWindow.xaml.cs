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

namespace NodosEnlazadosComoMatriz
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
            p.inf = null;
            p.info = 0;
            Nodo q = new Nodo();
            q = p;
            for(int i=0; i<4; i++)
            {
                Nodo nuevo = new Nodo();
                q.sig = nuevo;
                q.inf = null;
                nuevo.info = 0;
                q = q.sig;
            }
            q = p;
            for(int i=0; i<4; i++)
            {
                Nodo nuevo = new Nodo();
                q.inf = nuevo;
                nuevo.info = 0;
            }
        }

        private void btnagregar_Click(object sender, RoutedEventArgs e)
        {
            switch(int.Parse(cbxfilaA.SelectedValue.ToString()))
            {
                case 1:
                    switch(cbxcolumnaA.SelectedValue.ToString())
                    {
                        case "A":
                            
                            break;
                        case "B":

                            break;
                        case "C":

                            break;
                        case "D":

                            break;
                        case "E":

                            break;
                    }
                    break;
            }
        }
    }
}
