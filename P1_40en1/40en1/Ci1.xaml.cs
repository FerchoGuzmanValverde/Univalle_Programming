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

namespace _40en1
{
    /// <summary>
    /// Interaction logic for Ci1.xaml
    /// </summary>
    public partial class Ci1 : Window
    {
        Ciclos op = new Ciclos();
        int edad, antiguedad;
        public Ci1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            validar();
        }

        private void validar()
        {
            if(txtedad.Text == "" || txtantiguedad.Text == "")
            { MessageBox.Show("Porfavor, rellene los espacios correctamente"); }
            else
            {
                Asignar();
                MessageBox.Show("Sueldo es: " + op.salario(edad, antiguedad));
            }
        }

        private void Asignar()
        {
            edad = int.Parse(txtedad.Text);
            antiguedad = int.Parse(txtantiguedad.Text);
        }
    }
}
