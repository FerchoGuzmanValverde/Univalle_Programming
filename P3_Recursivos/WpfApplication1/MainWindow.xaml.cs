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

namespace WpfApplication1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] vec = { 12, 45, 81, 23, 4, 1, 7, 5 };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnYap_Click(object sender, RoutedEventArgs e)
        {
            //Mostrar(10);
            //txtFinal.Text = " " +  Factorial(5);
            //txtFinal.Text = " " + Fibonacci(4);
            //txtFinal.Text = " " + SumaCorrelativos(10);
            OrdenarRecursiva(vec, vec.Length);
            for (int i = 0; i < vec.Length; i++)
            {
                txtFinal.AppendText(" " + vec[i]);
            }
        }

        public void Mostrar(int n)
        {
            //txtFinal.AppendText(n + "");
            if(n > 0) Mostrar (n - 1);
            txtFinal.AppendText(n + "");
        }

        public int Factorial(int x)
        {
            if (x == 1) return 1;
            int f = x * Factorial(x - 1);
            return f;
        }

        public int Fibonacci(int pos)
        {
            if (pos == 0 || pos == 1) return 1;
            int f = Fibonacci(pos - 2) + Fibonacci(pos - 1);
            return f;
        }

        public int SumaCorrelativos(int n)
        {
            if (n == 1) return 1;
            int f = n + SumaCorrelativos(n - 1);
            return f;
        }

        public void OrdenarRecursiva(int[] vec, int tam)
        {
            if (tam > 1)
            {
                for (int i = 0; i < tam - 1; i++)
                {
                    if (vec[i + 1] < vec[i])
                    {
                        int tem = vec[i + 1];
                        vec[i + 1] = vec[i];
                        vec[i] = tem;
                    }
                    OrdenarRecursiva(vec, tam - 1);
                }
            }
        }


    }
}
