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

namespace Cuarto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] ve1 = new int[20];
        int[] ve2 = new int[20];
        int[] ver = new int[20];
        Random num = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnllenar_Click(object sender, RoutedEventArgs e)
        {
            lstv1.Items.Clear();
            lstv2.Items.Clear();
            for (int i = 0; i < 20; i++)
            {
                ve1[i] = num.Next(1, 50);
                ve2[i] = num.Next(1, 50);
            }
            for (int i = 0; i < 20; i++)
            {
                lstv1.Items.Add("Posicion "+(i+1)+": \t"+ve1[i]+"\n");
                lstv2.Items.Add("Posicion "+(i+1)+": \t"+ve2[i]+"\n");
            }
        }

        private void btnsumar_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                ver[i] = ve1[i] + ve2[i];
            }
            for (int i = 0; i < 20; i++)
            {
                lstresult.Items.Add("Posicion " + (i + 1) + ": \tvalor: " + ver[i] + "\n");
            }
        }
    }
}
