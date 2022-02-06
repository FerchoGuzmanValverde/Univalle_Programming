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
    /// Interaction logic for Ci6.xaml
    /// </summary>
    public partial class Ci6 : Window
    {
        public Ci6()
        {
            InitializeComponent();
        }

        private void btngraficar_Click(object sender, RoutedEventArgs e)
        {
            graficar(int.Parse(txtnumero.Text), txtgrafica);
        }

        private void graficar(int num, TextBox name)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    name.AppendText(j + " ");
                }
                name.AppendText("\n");
            }
        }
    }
}
