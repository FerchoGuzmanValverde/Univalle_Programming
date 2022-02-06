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

namespace CA_3ro
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int val1, val2, numeros = 0;
            val1 = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("introduzca valor"));
            val2 = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("introduzca valor"));
            while (val1 <= val2)
            {
                for (int i = val1; i <= val2; i++)
                {
                    numeros = val1;
                    txtnumeros.AppendText(numeros.ToString() + ",");
                    val1++;
                }
            }
            while (val2 <= val1)
            {
                for (int i = val1; i >= val2; i--)
                {
                    numeros = val1;
                    txtnumeros.AppendText(numeros.ToString() + ",");
                    val1--;
                }
            }
        }           
        }
    }

