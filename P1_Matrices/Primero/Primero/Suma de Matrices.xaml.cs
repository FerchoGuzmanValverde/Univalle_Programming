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

namespace Primero
{
    /// <summary>
    /// Interaction logic for Suma_de_Matrices.xaml
    /// </summary>
    public partial class Suma_de_Matrices : Window
    {
        Operaciones op = new Operaciones();
        int t1, t2;
        int[,] matris1;
        int[,] matris2;
        int[,] suma;
        int[] columnas;
        int[] filas;
        int[] dia = new int[4];

        public Suma_de_Matrices()
        {
            InitializeComponent();
        }

        private void btngenerar_Click(object sender, RoutedEventArgs e)
        {
            limpiar();
            Tamanio();
            matris1 = new int[t1, t2];
            matris2 = new int[t1, t2];
            suma = new int[t1, t2];
            columnas = new int[t1];
            filas = new int[t2];
            op.generar(matris1, matris2);
            mostrar(matris1, txtmatriz1);
            mostrar(matris2, txtmatriz2);
        }

        private void mostrar(int[,] ma, TextBox name)
        {
            for (int i = 0; i < ma.GetLength(0); i++)
            {
                for (int j = 0; j < ma.GetLength(1); j++)
                {
                    name.AppendText(ma[i, j] + "\t");
                }
                name.AppendText("\n");
            }
        }

        private void btnsumacf_Click(object sender, RoutedEventArgs e)
        {
            op.columnas(matris1, columnas);
            op.filas(matris1, filas);
            mastrarvec(columnas, txtsucolumnas);
            mastrarvec(filas, txtsufilas);
        }

        private void mastrarvec(int[] vec, TextBox name)
        {
            for (int i = 0; i < vec.Length; i++)
            {
                name.AppendText(vec[i] + "\t");
            }
        }

        private void limpiar()
        {
            txtmatriz1.Clear();
            txtmatriz2.Clear();
            txtsuma.Clear();
        }

        private void btnsumar_Click(object sender, RoutedEventArgs e)
        {
            op.sumar(matris1, matris2, suma);
            mostrar(suma, txtsuma);
        }

        private void btndiagonales_Click(object sender, RoutedEventArgs e)
        {
            op.diagonales(matris1, matris2, dia);
            lblmd1.Content = dia[0];
            lblmd2.Content = dia[1];
            lblmd3.Content = dia[2];
            lblmd4.Content = dia[3];
        }

        private void Tamanio()
        {
            t1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese numero de filas"));
            t2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese numero de columnas"));
        }
    }
}
