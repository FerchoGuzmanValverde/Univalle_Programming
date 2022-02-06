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

namespace Ventanas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Ventana2 otro;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnnuevo_Click(object sender, RoutedEventArgs e)
        {
            otro = new Ventana2();
            otro.Show();
        }

        private void btnmostrar_Click(object sender, RoutedEventArgs e)
        {
            otro.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            otro = new Ventana2();
            otro.ShowDialog();
        }
    }
}
