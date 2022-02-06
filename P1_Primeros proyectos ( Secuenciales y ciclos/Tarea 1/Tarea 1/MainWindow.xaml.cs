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

namespace Tarea_1
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

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            int cant, nota = 0, promedio, rep = 0, apr = 0, con = 0;
            cant = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese aqui cantidad de estudiantes", "Info"));
            for (int i = 1; i <= cant; i++)
            {
                nota = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingresa aqui las notas", "Notas"));
                con = con += nota;
                if (nota <= 50)
                {
                    rep++;
                }
                else
                {
                    apr++;
                }
            }
            promedio = con / cant;
            MessageBox.Show("El promedio es: "+promedio+"\nReprovados son: "+rep+"\nAprovados son: "+apr, "Detalles");
        }
    }
}
