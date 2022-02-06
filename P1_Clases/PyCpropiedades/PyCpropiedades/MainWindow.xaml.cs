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

namespace PyCpropiedades
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Operaciones ope = new Operaciones();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            ope.Poblacion = int.Parse(txtnum1.Text);
            ope.Grupo = int.Parse(txtnum2.Text);
            if(rbtpermutaciones.IsChecked == true)
            {
                txtresult.AppendText(ope.permutaciones().ToString() + "\n");
            }
            if(rbtcombinaciones.IsChecked == true)
            {
                txtresult.AppendText(ope.combinaciones().ToString() + "\n");
            }

        }
    }
}
