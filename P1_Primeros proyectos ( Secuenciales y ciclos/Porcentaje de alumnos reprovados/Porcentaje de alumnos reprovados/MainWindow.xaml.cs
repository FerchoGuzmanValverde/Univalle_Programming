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

namespace Porcentaje_de_alumnos_reprovados
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
            int nota, reprovado = 0, porcentaje, i = 0;
            nota = 0;
            while ( i < 10)
            {
                nota = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox(""));
                if (nota < 70)
                { reprovado++; }
                i++;
            }
            porcentaje = (reprovado * 100) / 10;
            MessageBox.Show("el porcentaje de reprovados es: " + porcentaje);
        }
    }
}
