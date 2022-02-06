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

namespace Rombo_con_Whiles
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

        private void btndibujar_Click(object sender, RoutedEventArgs e)
        {
            int num = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese numero"));
            int f = (num / 2), a, b = 1, c = 0;
            while (f >= 0)
            { 
                b = 1 + c;
                a = (f - 1);
                while (a >= 0)
                {
                    txtfigura.AppendText(" ");
                    a--;
                }
                while (b >= 1)
                {
                    txtfigura.AppendText("*");
                    b--;
                }
                txtfigura.AppendText("\n");
                c+=2;
                f--;
            }
            int d = (num/2), o, s, h = num - 2;
            while (d >= f && d <= num)
            {
                o = h;
                s = 1;
                while (s < d)
                {
                    txtfigura.AppendText(" ");
                    s++;
                }
                while (o >= 1)
                {
                    txtfigura.AppendText("*");
                    o--;
                }
                txtfigura.AppendText("\n");
                h -= 2;
                d++;
            }
        }
    }
}
