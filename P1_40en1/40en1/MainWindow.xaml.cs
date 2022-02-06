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

namespace _40en1
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

        private void btnS1_Click(object sender, RoutedEventArgs e)
        {
            S1 op1 = new S1();
            op1.ShowDialog();
        }

        private void btnS2_Click(object sender, RoutedEventArgs e)
        {
            S2 op2 = new S2();
            op2.ShowDialog();
        }

        private void btnS3_Click(object sender, RoutedEventArgs e)
        {
            S3 op3 = new S3();
            op3.ShowDialog();
        }

        private void btnS4_Click(object sender, RoutedEventArgs e)
        {
            S4 op4 = new S4();
            op4.ShowDialog();
        }

        private void btnS6_Click(object sender, RoutedEventArgs e)
        {
            S6 op6 = new S6();
            op6.ShowDialog();
        }

        private void btnCon1_Click(object sender, RoutedEventArgs e)
        {
            Con1 e1 = new Con1();
            e1.ShowDialog();
        }

        private void btnCon2_Click(object sender, RoutedEventArgs e)
        {
            Con2 e2 = new Con2();
            e2.ShowDialog();
        }

        private void btnCon3_Click(object sender, RoutedEventArgs e)
        {
            Con3 e3 = new Con3();
            e3.ShowDialog();
        }

        private void btnCon4_Click(object sender, RoutedEventArgs e)
        {
            Con4 e4 = new Con4();
            e4.ShowDialog();
        }

        private void btnCon5_Click(object sender, RoutedEventArgs e)
        {
            Con5 e5 = new Con5();
            e5.ShowDialog();
        }

        private void btnCi1_Click(object sender, RoutedEventArgs e)
        {
            Ci1 eje1 = new Ci1();
            eje1.ShowDialog();
        }

        private void btnCi2_Click(object sender, RoutedEventArgs e)
        {
            Ci2 eje2 = new Ci2();
            eje2.ShowDialog();
        }

        private void btnCi3_Click(object sender, RoutedEventArgs e)
        {
            Ci3 eje3 = new Ci3();
            eje3.ShowDialog();
        }

        private void btnCi4_Click(object sender, RoutedEventArgs e)
        {
            Ci4 eje4 = new Ci4();
            eje4.ShowDialog();
        }

        private void btnCi5_Click(object sender, RoutedEventArgs e)
        {
            Ci5 eje5 = new Ci5();
            eje5.ShowDialog();
        }

        private void btnCi6_Click(object sender, RoutedEventArgs e)
        {
            Ci6 eje6 = new Ci6();
            eje6.ShowDialog();
        }

        private void btnCi7_Click(object sender, RoutedEventArgs e)
        {
            Ci7 eje7 = new Ci7();
            eje7.ShowDialog();
        }

        private void btnCi8_Click(object sender, RoutedEventArgs e)
        {
            Ci8 eje8 = new Ci8();
            eje8.ShowDialog();
        }

        private void btnCi9_Click(object sender, RoutedEventArgs e)
        {
            Ci9 eje9 = new Ci9();
            eje9.ShowDialog();
        }

        private void btnCi10_Click(object sender, RoutedEventArgs e)
        {
            Ci10 eje10 = new Ci10();
            eje10.ShowDialog();
        }

        private void btnVe1_Click(object sender, RoutedEventArgs e)
        {
            vec1 ventana1 = new vec1();
            ventana1.ShowDialog();
        }

        private void btnVe2_Click(object sender, RoutedEventArgs e)
        {
            vec2 ventana2 = new vec2();
            ventana2.ShowDialog();
        }

        private void btnVe3_Click(object sender, RoutedEventArgs e)
        {
            vec3 ventana3 = new vec3();
            ventana3.ShowDialog();
        }

        private void btnVe4_Click(object sender, RoutedEventArgs e)
        {
            vec4 ventana4 = new vec4();
            ventana4.ShowDialog();
        }

        private void btnVe5_Click(object sender, RoutedEventArgs e)
        {
            vec5 ventana5 = new vec5();
            ventana5.ShowDialog();
        }

        private void btnVe6_Click(object sender, RoutedEventArgs e)
        {
            vec6 ventana6 = new vec6();
            ventana6.ShowDialog();
        }

        private void btnsecuencial5_Click(object sender, RoutedEventArgs e)
        {
            Se5 secuencial5 = new Se5();
            secuencial5.ShowDialog();
        }
    }
}
