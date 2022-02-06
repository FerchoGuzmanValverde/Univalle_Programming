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

namespace CalculadoraSistemas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Operaciones Binarios, Decimales, Octal, Hexadecimal;
        string numero;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnconvertir_Click(object sender, RoutedEventArgs e)
        {
            selector();
        }

        private void selector()
        {
            if(rbtbinario1.IsChecked == true)
            {
                Binarios binario = new Binarios();
                binario.Binario = numero;
                if (rbtbinario2.IsChecked == true)
                {
                    MessageBox.Show("No puede seleccionar mismo tipo");
                }
                else if (rbtdecimal2.IsChecked == true)
                {
                    lblrespuesta.Content = binario.ADecimal();
                }
                else if (rbthexadecimal2.IsChecked == true)
                {
                    lblrespuesta.Content = binario.aHexadecimal();
                }
                else if (rbtoctal2.IsChecked == true)
                {
                    lblrespuesta.Content = binario.aOctal();
                }
            }
            else if(rbtdecimal1.IsChecked == true)
            {
                Operaciones Decimales = new Operaciones();
                Decimales.Numero = int.Parse(numero);
                if (rbtbinario2.IsChecked == true)
                {
                    lblrespuesta.Content = Decimales.aBinario();
                }
                else if (rbtdecimal2.IsChecked == true)
                {
                    MessageBox.Show("No puede seleccionar mismo tipo");
                }
                else if (rbthexadecimal2.IsChecked == true)
                {
                    lblrespuesta.Content = Decimales.aHexadecimal();
                }
                else if (rbtoctal2.IsChecked == true)
                {
                    lblrespuesta.Content = Decimales.aOctal();
                }
            }
            else if(rbthexadecimal1.IsChecked == true)
            {
                Hexadecimal Hexa = new Hexadecimal();
                Hexa.Hexade = numero;
                if (rbtbinario2.IsChecked == true)
                {
                    lblrespuesta.Content = Hexa.aBinario();
                }
                else if (rbtdecimal2.IsChecked == true)
                {
                    lblrespuesta.Content = Hexa.ADecimal();
                }
                else if (rbthexadecimal2.IsChecked == true)
                {
                    MessageBox.Show("No puede seleccionar mismo tipo");
                }
                else if (rbtoctal2.IsChecked == true)
                {
                    lblrespuesta.Content = Hexa.aOctal();
                }
            }
            else if(rbtoctal1.IsChecked == true)
            {
                Octal Octa = new Octal();
                Octa.Octa = numero;
                if (rbtbinario2.IsChecked == true)
                {
                    lblrespuesta.Content = Octa.aBinario();
                }
                else if (rbtdecimal2.IsChecked == true)
                {
                    lblrespuesta.Content = Octa.ADecimal();
                }
                else if (rbthexadecimal2.IsChecked == true)
                {
                    lblrespuesta.Content = Octa.aHexadecimal();
                }
                else if (rbtoctal2.IsChecked == true)
                {
                    MessageBox.Show("No puede seleccionar mismo tipo");
                }
            }
        }

        private void btnnumero_Click(object sender, RoutedEventArgs e)
        {
            numero = Microsoft.VisualBasic.Interaction.InputBox("Ingrese numero a convertir");
        }
    }
}
