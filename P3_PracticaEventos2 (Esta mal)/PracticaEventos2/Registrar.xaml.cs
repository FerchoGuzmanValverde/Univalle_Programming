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
using System.Windows.Shapes;

namespace PracticaEventos2
{
    /// <summary>
    /// Lógica de interacción para Registrar.xaml
    /// </summary>
    public partial class Registrar : Window
    {
        public delegate void MiDelegado2();
        public event MiDelegado2 miEvento2;
        string nombre; int ci, edad;
        Persona person = new Persona();
        List<Persona> lista = new List<Persona>();
        MainWindow ventana1;


        public Registrar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            miEvento2 = Cancelar;
            miEvento2();
            miEvento2 = mostrarDatos;
        }

        private void Cancelar()
        {
            person.Nombre = null;
            person.Edad = 0;
            person.CI = 0;
        }

        private void txtOk_Click(object sender, RoutedEventArgs e)
        {
            miEvento2 = nuevo;
            miEvento2();
            miEvento2 = mostrarDatos;
        }

        private void nuevo()
        {
            person.Nombre = nombre;
            person.Edad = edad;
            person.CI = ci;
            lista.Add(person);
        }

        private void txtNombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            miEvento2 = verificarN;
            miEvento2();
            miEvento2 = null;
        }

        private void txtCI_TextChanged(object sender, TextChangedEventArgs e)
        {
            miEvento2 = verificarC;
            miEvento2();
            miEvento2 = null;
        }

        private void txtEdad_TextChanged(object sender, TextChangedEventArgs e)
        {
            miEvento2 = verificarE;
            miEvento2();
            miEvento2 = null;
        }

        public void verificarN()
        {
            ventana1 = new MainWindow();
            try
            {
                nombre = txtNombre.Text;
                if (nombre.Length < 2)
                { ventana1.lblStatus.Content = "El nombre es incorrecto"; }
                else
                {
                   
                    ventana1.lblStatus.Content = "El nombre es correcto"; }
            }
            catch (FormatException ex)
            { MessageBox.Show("Ingrese datos validos, caracteres"); }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        public void verificarE()
        {
            ventana1 = new MainWindow();
            try
            {
                edad = int.Parse(txtEdad.Text);
                if (edad < 18 || edad > 120)
                { ventana1.lblStatus.Content = "La edad es incorrecta"; }
                else
                {
                    
                    ventana1.lblStatus.Content = "La edad es correcta"; }
            }
            catch (FormatException ex)
            { MessageBox.Show("Ingrese enteros en la edad"); }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        public void verificarC()
        {
            ventana1 = new MainWindow();
            try
            {
                ci = int.Parse(txtCI.Text);
                if (1000000 > ci || ci > 9999999)
                { ventana1.lblStatus.Content = "El CI es incorrecto"; }
                else
                {
                    ventana1.lblStatus.Content = "El CI es correcto"; }
            }
            catch (FormatException ex)
            { MessageBox.Show("Ingrese numeros"); }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void mostrarDatos()
        {
            ventana1 = new MainWindow();
            for (int i = 0; i < lista.Count; i++)
            {

                ventana1.lstRegistro.Items.Add(lista[i].Nombre + ", Edad = " + lista[i].Edad + ", CI: " + lista[i].CI);
            }
        }

    }
}
