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

namespace Calificacion_final_MC
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
            int nota1, nota2, nota3, n70, n30, notafinal;
            nota1 = int.Parse(txtnota1.Text);
            nota2 = int.Parse(txtnota2.Text);
            nota3 = int.Parse(txtnota3.Text);
            n70 = nota1 + nota2;
            n30 = (nota3 / 30) * 100;
            notafinal = (n70 + n30) / 3;
            lblnotafinal.Content = notafinal;

        }
    }
}
