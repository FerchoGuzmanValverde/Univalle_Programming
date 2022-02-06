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

namespace Eventos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //declara un delegado
        public delegate void MiManejadorDeEventos();

        MiEvento evt = new MiEvento(); // Instancia

        public MainWindow()
        {
            InitializeComponent();

            //Suscribimos
            evt.AlgunEvento += Handler; //Handler se suscribe a algun evento

            evt.Disara(); //Dispara el evento
        }

        public void Handler()
        {
            MessageBox.Show("Evento Ocurrido!");
        }

        public class MiEvento
        {
            //declaramos evento-delegado
            public event MiManejadorDeEventos AlgunEvento;

            public void Disara()
            {
                if (AlgunEvento != null)
                {
                    AlgunEvento();
                }
            }
        }
    }
}
