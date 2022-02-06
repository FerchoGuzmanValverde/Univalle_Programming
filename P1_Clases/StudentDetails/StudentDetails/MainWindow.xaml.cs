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

namespace StudentDetails
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Promedio Alum = new Promedio();
        int n1, n2, n3;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            n1 = int.Parse(txtn1.Text);
            n2 = int.Parse(txtn2.Text);
            n3 = int.Parse(txtn3.Text);
            Alum.Nota1 = n1;
            Alum.Nota2 = n2;
            Alum.Nota3 = n3;
            comprobantes();
        }

        private void comprobantes()
        {
            if(n1>100 || n1 < 1)
            {
                MessageBox.Show("El numero ingresado en nota 1 es invalido, porfavor ingrese otra nota", "Que feo error");
                txtn1.Clear();
                txtn1.Focus();
            }
            else if(n2 > 100 || n2 < 1)
            {
                MessageBox.Show("El numero ingresado en nota 2 es invalido, porfavor ingrese otra nota", "Error en aqui choco");
                txtn2.Clear();
                txtn2.Focus();
            }
            else if(n3>100 || n3 < 1)
            {
                MessageBox.Show("el numero ingresado en nota 3 es invalido, porfavor ingrese nueva  nota", "Que error mas feo");
                txtn3.Clear();
                txtn3.Focus();
            }
            else
            {
                txtresultado.AppendText(txtnombre.Text + "\t" + Alum.promedio() + "\t" + Alum.definir() + "\n");
                nuevo();
            }
        }

        private void nuevo()
        {
            txtn1.Clear();
            txtn2.Clear();
            txtn3.Clear();
            txtnombre.Clear();
            txtnombre.Focus();
        }
    }
}
