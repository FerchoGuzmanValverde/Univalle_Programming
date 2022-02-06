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

namespace Pelotita_Vuelta
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer fer = new DispatcherTimer();
        int a = 0, py = 0, px = 0;

        private void margen_Loaded(object sender, RoutedEventArgs e)
        {
            fer.Start();
        }

        public MainWindow()
        {
            fer.Interval = TimeSpan.FromMilliseconds(30);
            fer.Tick += metodo;
            InitializeComponent();
        }

        private void metodo(object sender, EventArgs e)
        {
            if(a == 0)
            {
                if(py < margen.Height - 50)
                {
                    pelotita.Margin = new Thickness(px, py, 0, 0);
                    py += 5;
                }
                else
                {
                    a = 1;
                }
            }
            if(a == 1)
            {
                if(px < margen.Width - 50)
                {
                    pelotita.Margin = new Thickness(px, py, 0, 0);
                    px+=5;
                }
                else
                {
                    a = 2;
                }
            }
            if(a == 2)
            {
                if(py > 0)
                {
                    pelotita.Margin = new Thickness(px, py, 0, 0);
                    py -= 5;
                }
                else
                {
                    a = 3;
                }
            }
            if(a == 3)
            {
                if(px > 0)
                {
                    pelotita.Margin = new Thickness(px, py, 0, 0);
                    px -= 5;
                }
                else
                {
                    a = 0;
                }
            }
        }
    }
}
