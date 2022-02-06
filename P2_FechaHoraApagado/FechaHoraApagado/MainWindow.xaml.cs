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
using System.Windows.Threading;

namespace FechaHoraApagado
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer tiempo = new DispatcherTimer();
        public MainWindow()
        {
            tiempo.Interval = TimeSpan.FromSeconds(1);
            tiempo.Tick += verificador;
            InitializeComponent();
        }

        private void verificador(object sender, EventArgs e)
        {
            DateTime f = Convert.ToDateTime(fecha.Text);
            int hora = int.Parse(Hora.Text);
            int minuto = int.Parse(Minuto.Text);
            int segundo = int.Parse(Segundo.Text);
            if (DateTime.Now.DayOfYear == f.DayOfYear)
            {
                if(DateTime.Now.Hour == hora)
                {
                    if(DateTime.Now.Minute == minuto)
                    {
                        if(DateTime.Now.Second == segundo)
                        {
                            apagar();
                        }
                    }
                }
            }
        }

        private void apagar()
        {
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo("cmd", "/c shutdown /s");
            System.Diagnostics.Process proceso = new System.Diagnostics.Process();
            proceso.StartInfo = info;
            proceso.Start();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            tiempo.Stop();
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo("cdm", "/c shutdown /a");
            System.Diagnostics.Process proceso = new System.Diagnostics.Process();
            proceso.StartInfo = info;
            proceso.Start();
            MessageBox.Show("Ha cancelado el apagado del equipo");
            lblFechaHoraApagado.Content = "Cancelado";
        }

        private void btnProgramar_Click(object sender, RoutedEventArgs e)
        {
            DateTime f = Convert.ToDateTime(fecha.Text);
            int hora = int.Parse(Hora.Text);
            int minuto = int.Parse(Minuto.Text);
            int segundo = int.Parse(Segundo.Text);
            tiempo.Start();
            MessageBox.Show("Este equipo se apagara el dia " + f.ToLongDateString() + " a las " + Hora.Text + ":" + Minuto.Text + ":" + Segundo.Text);
            lblFechaHoraApagado.Content = f.ToLongDateString() + " a las " + hora + ":" + minuto + ":" + segundo;
        }
    }
}
