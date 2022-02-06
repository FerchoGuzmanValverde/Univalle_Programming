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
//importar la libreria
using System.IO;

namespace ArchivosNro1
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            //crear objeto file Stream y Stream Writer
            FileStream file;
            StreamWriter esbribidor;

            //crear el nuevo archivo
            file = new FileStream("F:/ArchivosNro1/texto.txt", FileMode.Append, FileAccess.Write);

            //enlazar el escribidor con el archivo
            esbribidor = new StreamWriter(file);

            //Escribir en el archivo
            esbribidor.Write(txtArchivo1.Text);
            //tambien se puede poner otras extenciones como .doc
        }
    }
}
