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

namespace Vivorita
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer vivora = new DispatcherTimer();
        int a = 0, px = 0, py = 0, aux = 50 ;
        public MainWindow()
        {
            vivora.Interval = TimeSpan.FromMilliseconds(30);
            vivora.Tick += corredor;
            InitializeComponent();
        }

        private void corredor(object sender, EventArgs e)
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

        private void izquierda()
        {
            if (px < aux)
            {
                pelotita.Margin = new Thickness(px, py, 0, 0);
                px += 5;
            }
            else
            {
                a = 0;
                aux += 50;
            }
        }

        private void bajar()
        {
            if (py > 0)
            {
                pelotita.Margin = new Thickness(px, py, 0, 0);
                py -= 5;
            }
            else
            {
                a = 3;
            }
        }

        private void derecha()
        {
            if (px < aux)
            {
                pelotita.Margin = new Thickness(px, py, 0, 0);
                px += 5;
            }
            else
            {
                a = 2;
                aux += 50;
            }
        }

        private void subir()
        {
            if (py < margen.Height - 50)
            {
                pelotita.Margin = new Thickness(px, py, 0, 0);
                py += 5;
            }
            else
            {
                a = 1;
            }
        }

        private void margen_Loaded(object sender, RoutedEventArgs e)
        {
            vivora.Start();
        }
    }
}
