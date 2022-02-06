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

namespace Estacion_del_Anio
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

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            int num;
            num = int.Parse(txtnumero.Text);
            switch (num)
            {
                case '1':
                case '2':
                case '3':
                    lblestacion.Content = "Es Verano";
                    break;
                case '4':
                case '5':
                case '6':
                    lblestacion.Content = "Es Otono";
                    break;
                case '7':
                case '8':
                case '9':
                    lblestacion.Content = "Es Invierno";
                    break;
                case 10:
                case 11:
                case 12:
                    lblestacion.Content = "Es Primavera";
                    break;
            }
        }
    }
}
