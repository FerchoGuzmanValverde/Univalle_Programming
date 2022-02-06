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

namespace UltimaExposicion
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

        private void btnagregar_Click(object sender, RoutedEventArgs e)
        {
            string nombrecompleto = txtnombre.Text + " " + txtprimero.Text + " " + txtsegundo.Text;
            MiGrid.Items.Add(nombrecompleto);
        }

        private void btninsertar_Click(object sender, RoutedEventArgs e)
        {
            MiView.Items.Add(txtitem.Text);
        }

        private void btnmostrar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Midate.Text);
        }
    }
}
