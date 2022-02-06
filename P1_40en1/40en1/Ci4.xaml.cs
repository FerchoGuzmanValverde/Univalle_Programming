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
    /// Interaction logic for Ci4.xaml
    /// </summary>
    public partial class Ci4 : Window
    {
        Ciclos op = new Ciclos();
        int total = 0, totalh = 0, totalm = 0, aux1 = 0, aux2 = 0;
        public Ci4()
        {
            InitializeComponent();
        }

        private void btnresgistrar_Click(object sender, RoutedEventArgs e)
        {
            registrar();
        }

        private void registrar()
        {
            int edad = 0, auxe = 0;
            char sexo;
            edad = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese edad: "));
            auxe = edad;
            while(edad != 0)
            {
                sexo = char.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese sexo H/M: "));
                if(edad < 18)
                { MessageBox.Show("No se permiten menores de 18"); }
                else if(edad > 100)
                { MessageBox.Show("Tan viejo y en fiestas?, ingrese una edad valida porfavor"); }
                else
                {
                    total++;
                    if (edad < auxe)
                    { auxe = edad; }
                    if(sexo == 'H')
                    {
                        totalh++; aux1 += edad;
                        lblprohombres.Content = aux1 / totalh;
                    }
                    else if(sexo == 'M')
                    {
                        totalm++; aux2 += edad;
                        lblpromujeres.Content = aux2 / totalm;
                    }
                    lbltotalasistentes.Content = total;
                    lbltotalhombres.Content = totalh;
                    lbltotalmujeres.Content = totalm;
                    lblmasjoven.Content = auxe;
                    edad = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese edad: "));
                }
            }
        }
    }
}
