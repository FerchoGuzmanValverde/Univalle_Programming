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

namespace Tarea_2
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

        private void btn_empezar_Click(object sender, RoutedEventArgs e)
        {
            int num1, num2, res = 0;
            num1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("ingrese aqui el numero", "Numero"));
            num2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("ingrese aqui la elevacion", "Elevacion"));
            for (int i = 1; i <= num2; i++)
            {
                res = res += num1;
            }
            lblrespuesta.Content = res.ToString();
        }
    }
}
