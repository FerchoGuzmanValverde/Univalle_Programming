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
using System.Threading;

namespace caballitosHilos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Thread caballo1, caballo2, caballo3;

        static int con1=10,con2=10,con3=10;
        public MainWindow()
        {
            InitializeComponent();
            caballo1 = new Thread(correr1);
            caballo2 = new Thread(correr2);
            caballo3 = new Thread(correr3);
        }

        private void btnIniciar_Click(object sender, RoutedEventArgs e)
        {
            
            con1 = 10; con2 = 10; con3 = 10;
            caballo1.Start();
            caballo2.Start();
            caballo3.Start();
        }

        void correr1()
        {
            while(con1<400)
            {
                Thread.Sleep(300);
                c1.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Render,
                    new Action(delegate()
                    {
                        c1.Margin = new Thickness(con1, 10, 0, 0);
                    }));
                
                con1+=10;
            }
        }

        void correr2()
        {
            while (con2 < 400)
            {
                Thread.Sleep(300);
                c2.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Render,
                    new Action(delegate()
                    {
                        c2.Margin = new Thickness(con2, 106, 0, 0);
                    }));
                con2 += 10;
            }
        }

        void correr3()
        {
            while (con3 < 400)
            {
                Thread.Sleep(300);
                c3.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Render,
                    new Action(delegate()
                    {
                        c3.Margin = new Thickness(con3, 214, 0, 0);
                    }));
                con3 += 10;
            }
        }
    }
}
