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
    /// Interaction logic for S3.xaml
    /// </summary>
    public partial class S3 : Window
    {
        Secuenciales op = new Secuenciales();
        float urg, ped, trau;
        public S3()
        {
            InitializeComponent();
        }

        private void btnrespartir_Click(object sender, RoutedEventArgs e)
        {
            validar();
        }

        public void nuevo(Label n1, Label n2, Label n3, TextBox name)
        {
            n1.Content = "";
            n2.Content = "";
            n3.Content = "";
            name.Clear();
            name.Focus();
        }

        private void validar()
        {
            if(txtpresupuesto.Text == "")
            {
                MessageBox.Show("Porfavor ingrese un monto");
            }
            else
            {
                float[] aux = new float[3];
                aux = op.reparto(aux, int.Parse(txtpresupuesto.Text));
                mostrar(lblurgencias, lblpediatria, lbltraumatologia, aux);
            }
        }

        public void mostrar(Label n1, Label n2, Label n3, float[] este)
        {
            n1.Content = este[0];
            n2.Content = este[1];
            n3.Content = este[2];
        }
    }
}
