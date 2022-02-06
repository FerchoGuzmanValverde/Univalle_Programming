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

namespace CA_5to
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
            int num = int.Parse(txtnumero.Text);
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    txtfigura.AppendText("*");
                }
                txtfigura.AppendText("\n");
   
            }
            for (int i = 1; i <= num; i++)
            {
                for (int j = num-1; j >= i; j--)
                {
                    txtfigura.AppendText("*");
                }
                txtfigura.AppendText("\n");
            }
        }
    }
}
