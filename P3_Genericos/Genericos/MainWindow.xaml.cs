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

namespace Genericos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LlaveValor<int, string> sg1 = new LlaveValor<int, string>(15, "Juan");

        //Crear delegado
        public delegate int Operacion(int val1, int val2);

        //hacer referencia mediante el delegado a los metodos
        Operacion mas = new Operacion(Suma);
        Operacion menos = new Operacion(Resta);
        Operacion por = new Operacion(Multiplicacion);

        public MainWindow()
        {
            InitializeComponent();
            //Estamos haciendo uso del metodo mediante el delegado
            mas(5, 7);

            //Mostrando el struct
            MessageBox.Show("Llave = " + sg1.L + " valor = " + sg1.V);
        }

        //Metodos del delegado
        public static int Suma(int a, int b)
        {
            Console.WriteLine("Ejecutando Suma");
            return a + b;
        }

        public static int Resta(int r, int t)
        {
            Console.WriteLine("Ejecutando Resta");
            return r - t;
        }

        public static int Multiplicacion(int x, int y)
        {
            Console.WriteLine("Ejecutando Multiplicacion");
            return x * y;
        }

        static void Main()
        {
            int[] nums = { 1, 2, 3 }; int[] nums2 = new int[4];

            Console.Write("Contents of nums: ");
            foreach (int x in nums)
                Console.Write(x + " ");

            Console.WriteLine();

            Console.Write("Contents of nums2: ");
            foreach (int x in nums2)
                Console.Write(x + " ");

            Console.WriteLine();


            string[] strs = { "Generics", "are", "powerful." };
            string[] strs2 = new string[4];

            Console.Write("Contents of strs: ");
            foreach (string s in strs)
                Console.Write(s + " ");

            Console.WriteLine();


            Console.Write("Contents of strs2: ");
            foreach (string s in strs2)
                Console.Write(s + " ");

            Console.WriteLine();
        }
    }
}
