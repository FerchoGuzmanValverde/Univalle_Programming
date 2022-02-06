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

namespace Pelotitas_multiples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer m1 = new DispatcherTimer();
        int a = 0, px = 0, py = 0, z = 0, x = 50, y = 50, t = 0;
        public MainWindow()
        {
            m1.Interval = TimeSpan.FromMilliseconds(30);
            m1.Tick += metodo;
            InitializeComponent();
        }

        private void metodo(object sender, EventArgs e)
        {
            if (a == 0)
            {
                subir();
            }
            if (a == 1)
            {
                derecha();
            }
            if (a == 2)
            {
                bajar();
            }
            if (a == 3)
            {
                izquierda();
            }
        }

        private void margen_Loaded(object sender, RoutedEventArgs e)
        {
            m1.Start();
        }

        private void izquierda()
        {
            if (px > t)
            {
                pelotita.Margin = new Thickness(px, py, 0, 0);
                px -= 5;
            }
            else
            {
                a = 0;
                t += 10;
            }
        }

        private void bajar()
        {
            if (py > z)
            {
                pelotita.Margin = new Thickness(px, py, 0, 0);
                py -= 5;
            }
            else
            {
                a = 3;
                z += 10;
            }
        }

        private void derecha()
        {
            if (px < margen.Width - y)
            {
                pelotita.Margin = new Thickness(px, py, 0, 0);
                px += 5;
            }
            else
            {
                a = 2;
                y += 10;
            }
        }

        private void subir()
        {
            if (py < margen.Height - x)
            {
                pelotita.Margin = new Thickness(px, py, 0, 0);
                py += 5;
            }
            else
            {
                a = 1;
                x += 10;
            }
        }
    }
}
