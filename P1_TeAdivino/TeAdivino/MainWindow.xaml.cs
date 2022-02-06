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

namespace TeAdivino
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Operaciones opera = new Operaciones();
        int num, pos, con = 1,aux1 = 0, con2 = 1, resp = 0;
        char res;
        int[,] tabla; int[] apoyo, com;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btngenerar_Click(object sender, RoutedEventArgs e)
        {
            num = int.Parse(txtnumero.Text);
            int segundo = int.Parse(opera.aDecimal(num).ToString());
            tabla = new int[num, segundo];
            com = new int[num];
            while(con <= num)
            {
                con2 = 1;
                aux1 = 0;
                while(con2  <= segundo)
                {
                    com = opera.aBinario(num, con2);
                    pos = com.Length - con;
                    escribir(pos);
                    con2++;
                }
                con++;
            }
            int a = 1;
            apoyo = new int[num];
            for (int i = 0; i < num; i++)
            {
                apoyo[i] = a;
                a = a * 2;
            }
            escribir2(tabla);
        }

        private void escribir2(int[,] tabla)
        {
            for (int i = 0; i < tabla.GetLength(1); i++)
            {
                for (int j = 0; j < tabla.GetLength(0); j++)
                {
                    if(tabla[j, i] != 0)
                    txttabla.AppendText(tabla[j, i].ToString() + "\t");
                }
                txttabla.AppendText("\n");
            }
        }

        private void escribir(int p)
        {
            if(com[p] == 1)
            {
                tabla[con - 1, aux1] = con2;
                aux1++;
            }
        }

        private void valorar(int[] vec)
        {
            for (int i = 0; i < vec.Length; i++)
            {
                vec[i] = 1;
            }
        }

        private void btnverificar_Click(object sender, RoutedEventArgs e)
        {
            resp = 0;
            for (int i = 0; i < num; i++)
            {
                res = char.Parse(Microsoft.VisualBasic.Interaction.InputBox("Esta tu numero en la columna " + (1 + i) + "?\nIngrese S si esta y N si no."));
                if(res == 'S')
                { resp = resp + apoyo[i]; }
            }
            lblrespuesta.Content = "El numero es: " + resp;
        }

        private void btnnuevo_Click(object sender, RoutedEventArgs e)
        {
            lblrespuesta.Content = "";
            txtnumero.Clear();
            txtnumero.Focus();
            txttabla.Clear();
        }

        private void btncerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
