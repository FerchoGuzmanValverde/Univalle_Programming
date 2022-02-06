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

namespace Peso_de_alumnos
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

        private void btnclasificar_Click(object sender, RoutedEventArgs e)
        {
            int peso, alumnos1 = 0,alumnos2 = 0, alumnos3 = 0, alumnos4 = 0, contador = 0, i = 0;
            while(i >= 0)
            {
                peso = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox(""));
                if (peso == 0)
                    break;
                if (peso < 40)
                {
                    alumnos1++;
                }
                if (peso >= 40 && peso <= 50) 
                {
                    alumnos2++;
                }
                if (peso > 50 && peso < 60)
                {
                    alumnos3++;
                }
                if (peso >= 60)
                {
                    alumnos4++;
                }
            }
            MessageBox.Show("categoria 1: "+alumnos1.ToString());
            MessageBox.Show("categoria 2: "+alumnos2.ToString());
            MessageBox.Show("categoria 3: "+alumnos3.ToString());
            MessageBox.Show("categoria 4: "+alumnos4.ToString());
        }
    }
}
