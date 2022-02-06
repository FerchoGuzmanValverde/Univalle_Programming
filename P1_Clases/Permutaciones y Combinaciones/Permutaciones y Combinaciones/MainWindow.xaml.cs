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

namespace Permutaciones_y_Combinaciones
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Operaciones nuevo = new Operaciones();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            int num1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Popularidad: ", "Poblacion"));
            int num2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Numero de grupos: ", "Grupos"));
            if (rbtpermutaciones.IsChecked == true)
                MessageBox.Show("Las permutaciones son: " + nuevo.Permutaciones(num1, num2));
            if (rbtcombinaciones.IsChecked == true)
                MessageBox.Show("Las combinaciones son: " + nuevo.Combinaciones(num1, num2));
        }
    }
}
