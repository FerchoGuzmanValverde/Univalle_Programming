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
    /// Lógica de interacción para Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        public void ReciveEvento(String cad, int c)
        {
            switch (cad)
            {
                case "encendido":
                    lbl3.Content = "RECIBIDO.. ON " + c;
                    break;
                case "apagado":
                    lbl3.Content = "Recibido.. OFF " + c;
                    break;
            }
        }
    }
}
