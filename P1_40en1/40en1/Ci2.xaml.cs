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
    /// Interaction logic for Ci2.xaml
    /// </summary>
    public partial class Ci2 : Window
    {
        Ciclos op = new Ciclos();
        int num1, num2;
        public Ci2()
        {
            InitializeComponent();
        }

        private void btnmultiplicar_Click(object sender, RoutedEventArgs e)
        {
            num1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el primer valor: "));
            num2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el segundo valor: "));
            validar();
        }

        private void validar()
        {
            if(num1.ToString() == "" || num2.ToString() == "")
            { MessageBox.Show("Porfavor, ingrese dos valores"); }
            else
            { lblresultado.Content = op.multiplicacion(num1, num2); }
        }
    }
}
