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

namespace Timer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int mili = 0, h=0, m=0, s=0;
        DispatcherTimer tiempo = new DispatcherTimer();
        public MainWindow()
        {
            tiempo.Interval = TimeSpan.FromMilliseconds(1);
            tiempo.Tick += TiempoTick;
            InitializeComponent();
        }

        private void TiempoTick(object sender, EventArgs e)
        {
            if (mili < 100)
            {
                lblmilisegundos.Content = mili;
                mili++;
            }
            else
            {
                mili = 0; lblmilisegundos.Content = 0;
                s = s + 1;
                if (s < 10)
                {
                    lblsegundos.Content = s;
                }
                else
                {
                    s = 0; lblsegundos.Content = 0;
                    m = m + 1;
                    if (m < 10)
                    {
                        lblminutos.Content = m;
                    }
                    else
                    {
                        m = 0; lblminutos.Content = 0;
                        h = h + 1;
                        if(h<10)
                        {
                            lblhoras.Content = h;
                        }
                    }
                }
            }
        }

        private void btniniciar_Click(object sender, RoutedEventArgs e)
        {
            tiempo.Start();
        }

        private void btnpausa_Click(object sender, RoutedEventArgs e)
        {
            tiempo.Stop();
        }

        private void btndetener_Click(object sender, RoutedEventArgs e)
        {
            tiempo.Stop();
            lblmilisegundos.Content = 0;
            lblsegundos.Content = 0;
            lblminutos.Content = 0;
            lblhoras.Content = 0;
            mili = 0;
            s = 0; m = 0; h = 0;
        }

        private void btngrabar_Click(object sender, RoutedEventArgs e)
        {
            lstmostrar.Items.Add("h: "+h+", m: "+m+", s: "+s+", ms: "+mili+"\n");
        }
    }
}
