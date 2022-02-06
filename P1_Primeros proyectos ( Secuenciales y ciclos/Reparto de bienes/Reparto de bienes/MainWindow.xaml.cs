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

namespace Reparto_de_bienes
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
            int cantidad, primero, restante, segundo, tercero;
            cantidad = int.Parse(txtcantidad.Text);
            primero = (cantidad / 100) * 40;
            restante = cantidad - primero;
            segundo = (restante * 70) / 100;
            tercero = restante - segundo;
            lblprimero.Content = primero;
            lblsegundo.Content = segundo;
            lbltercero.Content = tercero;

        }
    }
}
