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
    /// Interaction logic for Ci10.xaml
    /// </summary>
    public partial class Ci10 : Window
    {
        Ciclos op = new Ciclos();
        int peso, opcion1 = 0, opcion2 = 0, opcion3 = 0, opcion4 = 0;
        public Ci10()
        {
            InitializeComponent();
        }

        private void btnempezar_Click(object sender, RoutedEventArgs e)
        {
            peso = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese peso: "));
            while (peso != 0)
            {
                introducir();
                lblp1.Content = opcion1;
                lblp2.Content = opcion2;
                lblp3.Content = opcion3;
                lblp4.Content = opcion4;
                peso = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese peso: "));
            }
        }

        private void introducir()
        {
                if (peso < 40)
                { opcion1++; }
                else if (peso > 39 && peso < 51)
                { opcion2++; }
                else if (peso > 50 && peso < 60)
                { opcion3++; }
                else
                { opcion4++; }
        }
    }
}
