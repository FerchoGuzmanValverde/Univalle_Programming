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

namespace Promedio_de_Materia
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

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            float n1, n2, n3, promedio;
            n1 = float.Parse(txtnota1.Text);
            n2 = float.Parse(txtnota2.Text);
            n3 = float.Parse(txtnota3.Text);
            promedio = (((n1 + n2) * 0.7f) + (n3 * 0.3f))/3;
            lblpromedio.Content = promedio;
        }
    }
}
