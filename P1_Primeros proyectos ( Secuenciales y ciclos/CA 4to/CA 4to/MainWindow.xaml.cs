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

namespace CA_4to
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
            int num = 1;
            while (num != 0)
            {
                for (int i = 1; i <= num; i++)
                {
                    num = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("introduzca numeros"));
                    txtgrafico.AppendText(num + "." + " " + "|" + " ");
                    for (int j = 1; j <= num; j++)
                    {
                        txtgrafico.AppendText("*");
                    }
                    txtgrafico.AppendText("\n");
                }
            }
        }
    }
}
