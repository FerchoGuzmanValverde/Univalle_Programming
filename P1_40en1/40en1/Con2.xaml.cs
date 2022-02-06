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
    /// Interaction logic for Con2.xaml
    /// </summary>
    public partial class Con2 : Window
    {
        Condicionales op = new Condicionales();
        Con1 ope = new Con1();
        public Con2()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            validar();
            ope.nuevo(txtproducidos, txtdefectuosos);
        }

        private void validar()
        {
            if(txtdefectuosos.Text == "" || txtproducidos.Text == "")
            { MessageBox.Show("Porfavor complete todos los espacios"); }
            else
            {
                MessageBox.Show(op.calificar(int.Parse(txtproducidos.Text), int.Parse(txtdefectuosos.Text)), "Categoria: ");
            }
        }
    }
}
