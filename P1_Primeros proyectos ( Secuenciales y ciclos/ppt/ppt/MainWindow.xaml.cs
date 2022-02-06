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

namespace ppt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random num = new Random();
        int numpc;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnpiedra_Click(object sender, RoutedEventArgs e)
        {
            numpc = num.Next(1, 4);

            if (numpc == 1)
            {
                MessageBox.Show("Juego igualado");
            }
            else
            {
                if (numpc == 2)
                {
                    MessageBox.Show("pc=papel, perdiste");
                }
                else
                {
                    if (numpc == 3)
                    {
                        MessageBox.Show("Pc=Tijera, Ganaste");
                    }
                }
            }
        }

        private void btnpapel_Click(object sender, RoutedEventArgs e)
        {
            numpc = num.Next(1, 4);

            if (numpc == 1)
            {
                MessageBox.Show("Pc=piedra, ganaste");
            }
            else
            {
                if (numpc == 2)
                {
                    MessageBox.Show("pc=papel, Empate");
                }
                else
                {
                    if (numpc == 3)
                    {
                        MessageBox.Show("Pc=Tijera, Perdiste");
                    }
                }
            }
        }

        private void btntijera_Click(object sender, RoutedEventArgs e)
        {
            numpc = num.Next(1, 4);

            if (numpc == 1)
            {
                MessageBox.Show("Pc=piedra, Perdiste");
            }
            else
            {
                if (numpc == 2)
                {
                    MessageBox.Show("pc=papel, Ganaste");
                }
                else
                {
                    if (numpc == 3)
                    {
                        MessageBox.Show("Pc=Tijera, Empatado");
                    }
                }
            }
        }
    }
}
