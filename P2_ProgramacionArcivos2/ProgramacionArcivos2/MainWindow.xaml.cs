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
using System.IO;

namespace ProgramacionArcivos2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //FileStream archivo = null; StreamWriter escribir = null; StreamReader leer = null;

        private void btncrear_Click(object sender, RoutedEventArgs e)
        {
            FileStream archivo = null; StreamWriter escribir = null;
            archivo = new FileStream("F:/ProgramacionArcivos2/archivo.txt", FileMode.Create, FileAccess.Write);
            escribir = new StreamWriter(archivo);
            escribir.Write(txttexto.Text);
            archivo.Close();
        }

        private void btncrearnuevo_Click(object sender, RoutedEventArgs e)
        {
            FileStream archivo = null; StreamWriter escribir = null;
            archivo = new FileStream("F:/ProgramacionArcivos2/archivo.txt", FileMode.CreateNew, FileAccess.Write);
            escribir = new StreamWriter(archivo);
            escribir.Write(txttexto.Text);
            archivo.Close();
        }

        private void btnaniadir_Click(object sender, RoutedEventArgs e)
        {
            FileStream archivo = null; StreamWriter escribir = null;
            archivo = new FileStream("F:/ProgramacionArcivos2/archivo.txt", FileMode.Append, FileAccess.Write);
            escribir = new StreamWriter(archivo);
            escribir.Write(txttexto.Text);
            archivo.Close();
        }

        private void btnreadtoend_Click(object sender, RoutedEventArgs e)
        {
            FileStream archivo = null; StreamReader leer = null;
            archivo = new FileStream("F:/ProgramacionArcivos2/archivo.txt", FileMode.Open, FileAccess.Read);
            leer = new StreamReader(archivo);
            txtmostrar.Clear();
            txtmostrar.Text = leer.ReadToEnd();
            //archivo.Close();
        }

        private void btnreadline_Click(object sender, RoutedEventArgs e)
        {
            FileStream archivo = null; StreamReader leer = null;
            archivo = new FileStream("F:/ProgramacionArcivos2/archivo.txt", FileMode.Open, FileAccess.Read);
            leer = new StreamReader(archivo);
            txtmostrar.Clear();
            string linea = leer.ReadLine();
            while(linea != null)
            {
                txtmostrar.Text = linea + "\n";
                linea = leer.ReadLine();
            }
            //archivo.Close();
        }

        private void btnread_Click(object sender, RoutedEventArgs e)
        {
            FileStream archivo = null; StreamReader leer = null;
            archivo = new FileStream("F:/ProgramacionArcivos2/archivo.txt", FileMode.Open, FileAccess.Read);
            leer = new StreamReader(archivo);
            txtmostrar.Clear();
            int car = leer.Read();
            while (car != -1)
            {
                txtmostrar.Text = Convert.ToChar(car) + "\n";
                car = leer.Read();
            }
            //archivo.Close();
        }

        private void btnreportes_Click(object sender, RoutedEventArgs e)
        {
            FileStream archivo = null; StreamReader leer = null;
            int lines = 0, caracteres = 0, palabras = 0;
            archivo = new FileStream("F:/ProgramacionArcivos2/archivo.txt", FileMode.Open, FileAccess.Read);
            leer = new StreamReader(archivo);
            txtmostrar.Clear();
            int car = leer.Read();
            while (car != -1)
            {
                caracteres++;
                if(car == 32)
                { palabras++; }
                car = leer.Read();
            }
            string linea = leer.ReadLine();
            while (linea != null)
            {
                lines++;
                linea = leer.ReadLine();
            }
            txtmostrar.Text = "Lineas: " + lines + "\n";
            txtmostrar.Text = "Caracteres: " + caracteres + "\n";
            txtmostrar.Text = "Palabras: " + palabras + "\n";
            archivo.Close();
        }
    }
}
