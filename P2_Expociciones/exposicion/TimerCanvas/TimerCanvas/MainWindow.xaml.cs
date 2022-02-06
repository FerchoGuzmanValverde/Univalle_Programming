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

namespace TimerCanvas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        bool keyUp = false;
        bool keyDown = false;
        bool keyLeft = false;
        bool keyRight = false;

        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 10);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            double left = Canvas.GetLeft(circ); 
            double top = Canvas.GetTop(circ); 
            if (keyUp) //Al no colocar "== true" el if lo asume. 
            {
                top -= 5;
            }
            if (keyDown)
            {
                top += 5;
            }
            if (keyLeft)
            {
                left -= 5;
            }
            if (keyRight)
            {
                left += 5;
            }
            Canvas.SetLeft(circ, left);
            Canvas.SetTop(circ, top);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Up:
                    keyUp = true;
                    break;
                case Key.Down:
                    keyDown = true;
                    break;
                case Key.Left:
                    keyLeft = true;
                    break;
                case Key.Right:
                    keyRight = true;
                    break;
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            switch(e.Key)
            {
                case Key.Up:
                    keyUp = false;
                break;
                case Key.Down:
                    keyDown = false;
                break;
                case Key.Left:
                    keyLeft = false;
                break;
                case Key.Right:
                    keyRight = false;
                break;
            }
        }
    }
}
