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

namespace Pelotita_y_Semaforo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer fer = new DispatcherTimer();
        int posx = 0, posy = 0, a = 0;

        private void magen_Loaded(object sender, RoutedEventArgs e)
        {
            fer.Start();
        }

        public MainWindow()
        {
            fer.Interval = TimeSpan.FromMilliseconds(50);
            fer.Tick += nuevo;
            InitializeComponent();
        }

        private void nuevo(object sender, EventArgs e)
        {
            if (a == 0)
            {
                if (posy < magen.Height - 50)
                {
                    punto.Margin = new Thickness(posx, posy, 0, 0);
                    posy+=5;
                }
                else
                {
                    a = 1;
                }
            }
            if (a == 1)
            {
                if (posy > 0)
                {
                    punto.Margin = new Thickness(posx, posy, 0, 0);
                    posy-=5;
                }
                else
                {
                    a = 0;
                }
            }
        }
    }
}
