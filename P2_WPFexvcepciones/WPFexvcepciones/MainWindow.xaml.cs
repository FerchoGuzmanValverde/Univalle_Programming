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

namespace WPFexvcepciones
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] vector = new int[5];
        int i = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void btnVerificar1_Click(object sender, RoutedEventArgs e)
        {
            string cadena=null;
            try
            {
                cadena = txtm.Text;
                MostrarMensaje(cadena);
            }
            catch (ArgumentNullException ae)
            {
                MessageBox.Show("Mensaje de error: "+ ae.Message);
            }
        }
        private static void MostrarMensaje(String mensaje)
        {
            // Se lanza la excepción cuando el argumento `mensaje` 
            // es asociado con una referencia null:
            if (mensaje == null)
            {
                throw new ArgumentNullException("La cadena de texto a mostrar debe ser válida.", "mensaje");
            }
            MessageBox.Show(mensaje);
        }

        private void btnVerificar_Click(object sender, RoutedEventArgs e)
        {
            int n;
            n = Convert.ToInt32(txtn.Text);
            try
            {
                // Aquí la excepción ArgumentException es lanzada debido a que el 
                // dividendo es un número impar:
                MessageBox.Show("n dividido por 2 = "+ DividirPorDos(n));
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show("Mensaje de error: "+ ae.Message);
            }
        }
        // Método para dividir un número par entre 2:
        private static int DividirPorDos(int numero)
        {
            // En caso de que el número no sea par, entonces 
            // se lanzará la excepción `ArgumentException`:
            if ((numero % 2) == 1)
            {
                throw new ArgumentException("El número debe ser par.", "numero");
            }

            return numero / 2;
        }

  

  

        private void btnVector_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                vector[i] = Convert.ToInt32(txtnumero1.Text);
                i++;
                MessageBox.Show("Datos registrado");
            }
           /* catch (FormatException ex1)
            {
                MessageBox.Show("Solo puede ingreasar numeros enteros");
            }
            catch(IndexOutOfRangeException ex)
            {
                MessageBox.Show("Sobrepaso la cantidad de numeros que puede ingresar");
            }*/
            catch(Exception ex)
            {
                MessageBox.Show("ERROR.. " + ex.Message);
            }
          
           
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            list.Items.Clear();
            for (int c = 0; c < i; c++)
                list.Items.Add(vector[c]);
        }

        private void btnVerificarDiv2_Click(object sender, RoutedEventArgs e)
        {
            int a = 0, b = 0, r;
            if(txtn1.Text=="")
                {
                    MessageBox.Show("No puede dejar vacio el primer numero");
                    return;
                }
            if (txtn2.Text == "")
            {
                MessageBox.Show("No puede dejar vacio el segundo numero");
                return;
            }
            try
            {
                a = Convert.ToInt32(txtn1.Text);
                if(a%2==1)
                {
                    throw new Exception("ERROR.. "+a+" no es par");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("ERROR.. el primer numero debe ser un entero");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                b = Convert.ToInt32(txtn2.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("ERROR.. el segundo numero debe ser un entero");
                return;
            }

            try
            {
                if (a % 2 == 0 && b % 2 == 0)
                {
                    r = (a + b) / (a - b);
                    txtr.Text = Convert.ToString(r);
                }
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("ERROR.. intento dividir entre cero" + ex.Message);
                return;
            }
        }
    }
}
