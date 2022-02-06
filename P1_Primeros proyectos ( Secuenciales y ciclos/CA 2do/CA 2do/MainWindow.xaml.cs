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

namespace CA_2do
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

        private void btncrea_Click(object sender, RoutedEventArgs e)
        {
            int b = int.Parse(txtbase.Text);
            int a = int.Parse(txtaltura.Text);
            char letra = char.Parse("X");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    txtfigura.AppendText(letra.ToString());
                }
                txtfigura.AppendText("\n");

            }
        }
    }
}
