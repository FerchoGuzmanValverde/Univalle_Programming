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

namespace Formula_de_Peso
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
            Double peso, estatura, pesoI;
            string respuesta;
            peso = Convert.ToDouble(txtpeso.Text);
            estatura = Convert.ToDouble(txtestatura.Text);
            pesoI = peso / Math.Pow(estatura, 2);
            if (pesoI < 16)
                respuesta = "Criterio de ingreso al Hospital";
            else
            {
                if (pesoI == 16 || pesoI == 17 || pesoI == 18)
                    respuesta = "Infrapeso";
                else
                {
                    if (pesoI > 18 && pesoI < 25)
                        respuesta = "Peso normal (Saludable)";
                    else
                    {
                        if (pesoI >= 25 && pesoI < 30)
                            respuesta = "Sobrepeso (Obesidad de grado 1)";
                        else
                        {
                            if (pesoI >= 30 && pesoI < 35)
                                respuesta = "Sobrepeso cronico(Obesidad de grado 2)";
                            else
                            {
                                if (peso >= 35 && pesoI < 40)
                                    respuesta = "Obesidad premorbida (Grado 3)";
                                else
                                    respuesta = "Obesidad morbida (Grado 4)";
                            }
                        }
                    }
                }
            }
            lblrespuesta.Content = respuesta;
        }
    }
}
