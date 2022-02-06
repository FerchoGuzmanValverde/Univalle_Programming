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

namespace Simulador_de_Password
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

        private void btningresar_Click(object sender, RoutedEventArgs e)
        {
            int password;
            password = int.Parse(txtpassword.Password);
            if (password == 123456)
            {
                lblacceso.Content = "Acceso Permitido";
                MessageBox.Show("Welcome to this page");
            }
            else
                lblacceso.Content = "Acceso Denegado";
        }
    }
}
