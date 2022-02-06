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

namespace Multiples_bolitas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer correr = new DispatcherTimer();
        DispatcherTimer correr1 = new DispatcherTimer();
        DispatcherTimer correr2 = new DispatcherTimer();
        string name, p1, p2, p3;
        int n1, n2, n3, n4;
        int a = 0, px = 0, py = 0;
        public MainWindow()
        {
            correr.Interval = TimeSpan.FromMilliseconds(30);
            correr1.Interval = TimeSpan.FromMilliseconds(30);
            correr2.Interval = TimeSpan.FromMilliseconds(30);
            correr.Tick += metodo;
            correr1.Tick += metodo1;
            correr2.Tick += metodo3;
            InitializeComponent();
        }

        private void metodo3(object sender, EventArgs e)
        {
            n1 = 250; n2 = 250; n3 = 200; n4 = 200;
            if (name == p3)
            {
                accion(bolita3);
            }
        }

        private void metodo1(object sender, EventArgs e)
        {
            n1 = 150; n2 = 150; n3 = 100; n4 = 100;
            if (name == p2)
            {
                accion(bolita2);
            }
        }

        private void metodo(object sender, EventArgs e)
        {
            n1 = 50; n2 = 50; n3 = 0; n4 = 0;
            if(name == p1)
            {
                accion(bolita1);
            }
        }

        private void accion(RadioButton x)
        {
            if (a == 0)
            {
                subir(x);
            }
            if (a == 1)
            {
                derecha(x);
            }
            if (a == 2)
            {
                bajar(x);
            }
            if (a == 3)
            {
                izquierda(x);
            }
        }

        private void izquierda(RadioButton y)
        {
            if (px > n4)
            {
                y.Margin = new Thickness(px, py, 0, 0);
                px -= 5;
            }
            else
            {
                a = 0;
            }
        }

        private void bajar(RadioButton y)
        {
            if (py > n3)
            {
                y.Margin = new Thickness(px, py, 0, 0);
                py -= 5;
            }
            else
            {
                a = 3;
            }
        }

        private void derecha(RadioButton y)
        {
            if (px < margen.Width - n2)
            {
                y.Margin = new Thickness(px, py, 0, 0);
                px += 5;
            }
            else
            {
                a = 2;
            }
        }

        private void subir(RadioButton y)
        {
            if (py < margen.Height - n1)
            {
                y.Margin = new Thickness(px, py, 0, 0);
                py += 5;
            }
            else
            {
                a = 1;
            }
        }

        private void margen_Loaded(object sender, RoutedEventArgs e)
        {
            correr.Start();
        }
    }
}
