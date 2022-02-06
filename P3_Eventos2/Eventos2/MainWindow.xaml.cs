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

namespace Eventos2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //creamos objeto de la ventana 2
        Window2 mv2;
        Window3 mv3 = new Window3();
        //Creamos el delegado
        public delegate void MiDelegado(String cadena, int comando);
        //Creamos el evento
        public event MiDelegado miEvento;

        public MainWindow()
        {
            InitializeComponent();
            //Intanciamos el objeto de la ventana 2
            mv2 = new Window2();
            //Suscribimos el metodo al evento
            this.miEvento += mv2.ReciveEvento;
            this.miEvento += mv3.ReciveEvento;

            mv3.Show();
            mv2.Show();
        }

        private void btnEncender_Click(object sender, RoutedEventArgs e)
        {
            //Creamos evento para que dispare el metodo
            miEvento("encendido", 15);
        }

        private void btnApagar_Click(object sender, RoutedEventArgs e)
        {
            //Creamos evento para que dispare el metodo
            miEvento("apagado", 0);
        }
    }
}
