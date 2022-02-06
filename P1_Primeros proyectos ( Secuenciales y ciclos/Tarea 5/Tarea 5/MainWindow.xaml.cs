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

namespace Tarea_5
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

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            int cant, num, pago = 0, cont = 0;
            cant = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingresar cantidad de familias", "Numero de Familias"));
            for (int i = 1; i <= cant; i++)
            {
                num = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese cantidad de litros: ", "Gasto de agua"));
                if (num < 50)
                {
                    pago = 0;
                }
                if (num >= 50 && num <= 200)
                {
                    pago = num;
                }
                if (num > 200)
                {
                    pago = num * 3;
                }
                if (pago > 50 && pago < 100)
                {
                    pago = 100;
                }
                cont++;
                txtrespuesta.AppendText("Familia "+cont+" debe: " + pago.ToString()+" Bs\n");
            }
        }
    }
}
