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

namespace Fernando_GUZMAN
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int passwor1, passwor2;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, RoutedEventArgs e)
        {
            validar();
        }

        private void validar()
        {
            if (txtdominio.Text == "" || txtdominio2.Text == "" || txtid.Text == "" || txtid2.Text == "" || txtpassword.Text == "" || txtpassword1.Text == "" || txtconfirmar.Text == "" || txtconfirmar1.Text == "")
            {
                MessageBox.Show("Por favor, ingrese todo los datos");
            }
            else if(txtpassword.Text.Length <= 6)
            {
                MessageBox.Show("La contraseña no tiene suficientes caracteres");
            }
            else
            {
                Correo_Electronico Correo = new Correo_Electronico();
                Correo.ID = txtid.Text;
                Correo.Dominio = txtdominio.Text;
                Correo.Password = txtpassword.Text;
                Correo.Comprobante = txtconfirmar.Text;
                MessageBox.Show(Correo.Comprobar());
                lblprimero.Content = Correo.correo();
                Correo.ID = txtid2.Text;
                Correo.Dominio = txtdominio2.Text;
                Correo.Password = txtpassword1.Text;
                Correo.Comprobante = txtconfirmar1.Text;
                MessageBox.Show(Correo.Comprobar());
                lblprimero.Content = Correo.correo();
            }
        }
    }
}
