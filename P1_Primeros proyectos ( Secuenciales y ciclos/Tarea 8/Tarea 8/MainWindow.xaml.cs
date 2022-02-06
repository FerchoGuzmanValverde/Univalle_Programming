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

namespace Tarea_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btndibujar_Click(object sender, RoutedEventArgs e)
        {
            int alto, ancho;
            alto = int.Parse(txtalto.Text);
            ancho = int.Parse(txtancho.Text);
            for (int i = 1; i <= alto; i++)
            {
                for (int j = 1; j <= ancho; j++)
                {
                    txtdibujo.AppendText("*");
                }
                txtdibujo.AppendText("\n");
            }
        }
    }
}
