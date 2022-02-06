using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace progressBarHilos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Thread h1;
        int cont1 = 0;
        public MainWindow()
        {
            InitializeComponent();
            h1 = new Thread(proceso1);
        }

        private void btniniciar_Click(object sender, RoutedEventArgs e)
        {
            h1.Abort();
            cont1 = 0;
            h1.Start();
            
        }

        public void proceso1()
        {
            while(true)
            {
                cont1++;
                if (cont1 > 100) cont1 = 0;
                txtcon.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Render,
                    new Action(delegate
                    {
                        txtcon.Text = "" + cont1;
                        pgb1.Value = cont1;
                    }));
                Thread.Sleep(TimeSpan.FromMilliseconds(500));
            }
            
        }
    }
}
