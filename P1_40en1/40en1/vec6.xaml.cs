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
    /// Interaction logic for vec6.xaml
    /// </summary>
    public partial class vec6 : Window
    {
        int direccion, actual;
        int turno = 0;

        public vec6()
        {
            InitializeComponent();
        }

        private void btnnuevo_Click(object sender, RoutedEventArgs e)
        {
            generar(lstjugador1, lstjugador2);
        }

        private void generar(ListBox name1, ListBox name2)
        {
            for (int i = 0; i < 15; i++)
            {
                name1.Items.Add("***");
                name2.Items.Add("***");
            }
        }

        private void btnatacar_Click(object sender, RoutedEventArgs e)
        {
            direccion = int.Parse(txtdireccion.Text);
            validar(direccion);
        }

        private void validar(int numero1)
        {
            if(numero1 < -14 || numero1 > 15 || numero1.ToString() == "")
            { MessageBox.Show("Ingrese numeros validos porfavor"); }
            else
            {
                if (turno == 0)
                {
                    direccion = (actual + 1) + direccion;
                    atacar(direccion, lstjugador2);
                    turno = 1;
                    revisar(lstjugador2);
                }
                else
                {
                    direccion = (actual + 1) + direccion;
                    atacar(direccion, lstjugador1);
                    turno = 0;
                    revisar(lstjugador1);
                }
            }
        }

        private void revisar(ListBox name)
        {
            bool conf = false;
            for (int i = 0; i < name.Items.Count; i++)
            {
                if(name.Items.GetItemAt(i) == "")
                { conf = true; }
                else
                {
                    conf = false;
                    i = name.Items.Count;
                }
            }
            if(conf == true)
            { MessageBox.Show(name + "se agotaron sus soldados.. \n Has Perdido"); }
        }

        void atacar(int posicion, ListBox name)
        {
            string numero = name.Items.GetItemAt(posicion).ToString();
            name.Items.RemoveAt(posicion);
            name.Items.Insert(posicion, reevaluar(numero));
        }

        private string reevaluar(string numero)
        {
            if(numero == "***")
            { numero = "**"; }
            else if(numero == "**")
            { numero = "*"; }
            else if(numero == "*")
            { numero = ""; }
            else if(numero == "")
            { numero = ""; }
            return numero;
        }
    }
}
