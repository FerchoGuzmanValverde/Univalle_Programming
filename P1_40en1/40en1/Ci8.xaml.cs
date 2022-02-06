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
using System.Windows.Shapes;

namespace _40en1
{
    /// <summary>
    /// Interaction logic for Ci8.xaml
    /// </summary>
    public partial class Ci8 : Window
    {
        int num;
        public Ci8()
        {
            InitializeComponent();
        }

        private void btndibujar_Click(object sender, RoutedEventArgs e)
        {
            num = int.Parse(txtnumero.Text);
            dibujar();
        }

        private void dibujar()
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    txtgrafica.AppendText("*");
                }
                txtgrafica.AppendText("\n");
            }
            for (int i = num - 1; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    txtgrafica.AppendText("*");
                }
                txtgrafica.AppendText("\n");
            }
        }
    }
}
