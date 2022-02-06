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

namespace TareaAbstractos
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

        private void btnejercicio1_Click(object sender, RoutedEventArgs e)
        {
            string color = Microsoft.VisualBasic.Interaction.InputBox("Ingrese color", "Cuadrado");
            double lado = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese lado", "Cuadrado"));
            Cuadrado fig = new Cuadrado(color, lado);
            MessageBox.Show("El color es: " + fig.Color + "\n" + fig.CalcularArea() + "\n" + fig.CalcularPerimetro(), "Cuadrado");
            double Base = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese base: ", "Rectangulo"));
            double Alto = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese alto: ", "Rectangulo"));
            color = Microsoft.VisualBasic.Interaction.InputBox("Ingrese color: ", "Rectangulo");
            Rectangulo fig2 = new Rectangulo(color, Base, Alto);
            MessageBox.Show("El color es: " + fig2.Color + "\n" + fig2.CalcularArea() + "\n" + fig2.CalcularPerimetro());
            Base = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese base: ", "Triangulo"));
            Alto = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese alto: ", "Triangulo"));
            color = Microsoft.VisualBasic.Interaction.InputBox("Ingrese color: ", "Triangulo");
            Triangulo fig3 = new Triangulo(color, Base, Alto);
            MessageBox.Show("El color es: " + fig3.Color + "\n" + fig3.CalcularArea() + "\n" + fig3.CalcularPerimetro(), "Triangulo");
        }
    }
}
