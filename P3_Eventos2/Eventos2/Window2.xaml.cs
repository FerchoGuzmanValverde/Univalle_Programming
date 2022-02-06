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

namespace Eventos2
{
    /// <summary>
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        public void ReciveEvento(String cad, int c)
        {
            switch (cad)
            {
                case "encendido":
                    txtcadena.Text = "Motor Encendido!";
                    txtentero.Text = "Velocidad = " + c;
                    break;
                case "apagado":
                    txtcadena.Text = "Motor Apagado!";
                    txtentero.Text = "Velocidad = " + c;
                    break;
            }
        }
    }
}
