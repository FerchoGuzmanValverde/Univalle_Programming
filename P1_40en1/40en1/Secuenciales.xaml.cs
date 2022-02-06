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
    /// Interaction logic for Secuenciales.xaml
    /// </summary>
    public partial class Secuenciales : Window
    {
        S1 uno; S2 dos; S3 tres; S4 cuatro; S5 cinco; S6 seis;
        public Secuenciales()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            uno = new S1();
            uno.Show();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            dos = new S2();
            dos.Show();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            tres = new S3();
            tres.Show();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            cuatro = new S4();
            cuatro.Show();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            cinco = new S5();
            cinco.Show();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            seis = new S6();
            seis.Show();
        }
    }
}
