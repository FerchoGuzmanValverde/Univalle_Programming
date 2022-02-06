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

namespace Eficiencia_de_operario_de_Fabrica
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

        private void txtcalcular_Click(object sender, RoutedEventArgs e)
        {
            int producidos, defectuosos;
            string eficiencia;
            producidos = int.Parse(txtproducidos.Text);
            defectuosos = int.Parse(txtdefectuosos.Text);
            if (producidos > 10000 && defectuosos < 200)
                eficiencia = "Grado 8";
            else
            {
                if (producidos > 10000 && defectuosos >= 200)
                    eficiencia = "Grado 7";
                else
                {
                    if (producidos < 10000 && defectuosos < 200)
                        eficiencia = "Grado 6";
                    else
                        eficiencia = "Grado 5";
                }
            }
            lblrespuesta.Content = ("Su nivel de eficiencia es: " + eficiencia);
        }
    }
}
