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
    /// Interaction logic for Con1.xaml
    /// </summary>
    public partial class Con1 : Window
    {
        Condicionales op = new Condicionales();
        public Con1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            validar();
            nuevo(txtpeso, txtestatura);
        }

        public void nuevo(TextBox box1, TextBox box2)
        {
            box1.Text = "";
            box2.Clear();
            box1.Focus();
        }

        private void validar()
        {
            if(txtpeso.Text == "" || txtestatura.Text == "")
            {
                MessageBox.Show("Porfavor complete todos los datos");
            }
            else
            {
                MessageBox.Show(op.categorizar(int.Parse(txtpeso.Text), double.Parse(txtestatura.Text)), "Categoria: ");
            }
        }
    }
}
