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

namespace Tarea1
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

        private void btnComparar_Click(object sender, RoutedEventArgs e)
        {
            DateTime tiempo;
            try
            {
                tiempo = Convert.ToDateTime(txthora.Text);
                if (tiempo.Hour > 23 || tiempo.Hour < 0)
                    throw new Exception("La hora no puede ser mayor a 23 ni menor a 0");
                if (tiempo.Minute > 59 || tiempo.Minute < 0)
                    throw new Exception("El minuto no puede ser mayor a 59 ni menor a 0");
                if (tiempo.Second > 59 || tiempo.Second < 0)
                    throw new Exception("El segundo no puede ser mayor a 59 ni menor a 0");
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Ha ocurrido un error en el formato. " + ex.Message);
                MessageBox.Show("El formato es: hora:minuto:segundo... por favor asegurese de ingresar en este formato.");
                return;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error.. " + ex.Message);
                return;
            }
            DateTime restante = DateTime.MaxValue - tiempo.TimeOfDay;
            MessageBox.Show("El tiempo restante del dia es: " + restante.Hour + ":" + restante.Minute + ":" + restante.Second);
        }

        private void btndigitos_Click(object sender, RoutedEventArgs e)
        {
            int comprobante;
            try
            {
                comprobante = int.Parse(txtdigitos.Text);
                if (comprobante < 0)
                    throw new Exception("No puede ingresar numeros negativos");
                MessageBox.Show("La cifra tiene " + (txtdigitos.Text).Length + " digitos");
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Solo puede ingresar enteros positivos en el cuadro");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error.. " + ex.Message);
            }
        }

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            int nota1, nota2;
            try
            {
                nota1 = int.Parse(txtnota1.Text);
                if (nota1 > 100 || nota1 < 0)
                    throw new Exception("No puede ingresar notas mayores a 100 o menores a 0");
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Solo puede ingresar enteros en la nota 1");
                return;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema.. " + ex.Message);
                return;
            }
            try
            {
                nota2 = int.Parse(txtnota2.Text);
                if (nota1 > 100 || nota1 < 0)
                    throw new Exception("No puede ingresar notas mayores a 100 o menores a 0");
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Solo puede ingresar enteros en la nota 2");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema.. " + ex.Message);
                return;
            }
            try
            {
                float aux = (nota1 + nota2) * 0.7f;
                if (aux >= 51)
                    MessageBox.Show("Ya tienes nota suficiente para aprovar");
                else
                {
                    aux = 51 - aux;
                    MessageBox.Show("Te falta " + aux + " puntos para pasar el curso");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error.. " + ex.Message);
            }
        }

        private void btncalcularCifra_Click(object sender, RoutedEventArgs e)
        {
            int c200 = 0, c100 = 0, c50 = 0, c20 = 0, c10 = 0, c5 = 0, c2 = 0, c1 = 0, cifra;
            try
            {
                cifra = int.Parse(txtcifra.Text);
                if (cifra < 0)
                    throw new Exception("No puede ingresar valores menores a 0");
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Solo puede ingresar valores enteros como cifras.");
                return;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error.. " + ex.Message);
                return;
            }
            while(cifra > 0)
            {
                if(cifra >= 200)
                {
                    cifra -= 200;
                    c200++;
                }
                else if(cifra >= 100)
                {
                    cifra -= 100;
                    c100++;
                }
                else if (cifra >= 50)
                {
                    cifra -= 50;
                    c50++;
                }
                else if (cifra >= 20)
                {
                    cifra -= 20;
                    c20++;
                }
                else if (cifra >= 10)
                {
                    cifra -= 10;
                    c10++;
                }
                else if (cifra >= 5)
                {
                    cifra -= 5;
                    c5++;
                }
                else if (cifra >= 2)
                {
                    cifra -= 2;
                    c2++;
                }
                else
                {
                    cifra -= 1;
                    c1++;
                }
            }
            MessageBox.Show("En total necesita:\n200 $: " + c200 + "\n100 $: " + c100 + "\n50 $: " + c50 + "\n20 $: " + c20 + "\n10 $: " + c10 + "\n5 $:  " + c5 + "\n2 $:  " + c2 + "\n1 $:  " + c1);
        }
    }
}
