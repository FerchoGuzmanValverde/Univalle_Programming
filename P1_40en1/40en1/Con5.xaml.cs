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
    /// Interaction logic for Con5.xaml
    /// </summary>
    public partial class Con5 : Window
    {
        Condicionales op = new Condicionales();
        string nombre1, nombre2; char J1, J2;
        public Con5()
        {
            InitializeComponent();
        }

        private void btnjugar_Click(object sender, RoutedEventArgs e)
        {
            validar();
        }

        private void validar()
        {
            if(nombre1 == "" || nombre2 == "")
            { MessageBox.Show("Debe ingresar nombres para jugar"); this.Close(); }
            else
            {
                J1 = char.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingresa Piedra con (R), Papel con (P), Tijera con (T)\nCual elijes?", nombre1));
                J2 = char.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingresa Piedra con (R), Papel con (P), Tijera con (T)\nCual elijes?", nombre2));
                MessageBox.Show(op.ppt(J1, J2, nombre1, nombre2));
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            nombre1 = Microsoft.VisualBasic.Interaction.InputBox("Ingrese nombre del Jugador 1");
            nombre2 = Microsoft.VisualBasic.Interaction.InputBox("Ingrese nombre del Jugador 2");
        }
    }
}
