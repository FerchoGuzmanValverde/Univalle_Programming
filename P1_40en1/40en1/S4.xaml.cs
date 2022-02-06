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
    /// Interaction logic for S4.xaml
    /// </summary>
    public partial class S4 : Window
    {
        Secuenciales op = new Secuenciales();
        S3 ope = new S3();
        float[] hijos = new float[3];
        public S4()
        {
            InitializeComponent();
        }

        private void btnrepartir_Click(object sender, RoutedEventArgs e)
        {
            validar();
        }

        private void validar()
        {
            if(txtcapital.Text == "")
            {
                MessageBox.Show("Porfavor ingrese un capital");
            }
            else
            {
                op.hijos(hijos, int.Parse(txtcapital.Text));
                ope.mostrar(lblprimero, lblsegundo, lbltercero, hijos);
            }
        }
    }
}
