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

namespace PracticaEventos
{
    /// <summary>
    /// Lógica de interacción para Tele.xaml
    /// </summary>
    public partial class Tele : Window
    {
        int canal = 0, volumen = 0;
        public Tele()
        {
            InitializeComponent();
        }

        public void SubirVolumen()
        {
            volumen += 1;
            lblVolumen.Content = volumen;
        }
        public void BajarVolumen()
        {
            volumen -= 1;
            lblVolumen.Content = volumen;
        }
        public void SubirCanal()
        {
            canal += 1;
            lblCanal.Content = "Canal: " + canal;
        }
        public void BajarCanal()
        {
            canal -= 1;
            lblCanal.Content = "Canal: " + canal;
        }
        public void Encender()
        {
            gridM.Background = Brushes.Aqua;
        }
        public void Apagar()
        {
            gridM.Background = Brushes.Black;
        }
    }
}
