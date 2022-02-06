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

namespace N_primo_1_al_100
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

        private void btnmostrar_Click(object sender, RoutedEventArgs e)
        {
            int mod, con;
            for (int i = 1; i <= 100; i++)
            {
                con = 0;
                for (int j = 2; j < i; j++)
                {
                    mod = i % j;
                    if (mod == 0)
                    {
                        con++;
                        j = i;
                    }
                }
                if (con <= 0)
                {
                    txtmostrar.AppendText(i.ToString());
                    txtmostrar.AppendText("\n");
                }
            }
        }
    }
}
