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
using System.IO;
using Microsoft.Win32;

namespace openFileDialog_y_saveFileDialog_WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string file = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGuardarCreate_Click(object sender, RoutedEventArgs e)
        {
            FileStream f = null;
            StreamWriter sw = null;

            if(file == "")
            {
                MessageBoxResult ms = MessageBox.Show("Would you like to save it?.", "Archivo no esta guardado", MessageBoxButton.YesNoCancel);
                if(ms == MessageBoxResult.Yes)
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Title = "Guardar un archivo de tipo text";
                    saveFileDialog1.DefaultExt = "txt";
                    saveFileDialog1.Filter = "Text files (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

                    if (saveFileDialog1.ShowDialog() == true)
                    {
                        file = saveFileDialog1.FileName;
                        try
                        {
                            f = new FileStream(file, FileMode.Create, FileAccess.Write);
                            sw = new StreamWriter(f);
                            sw.Write("\n");
                            sw.Write(txt1.Text);
                            MessageBox.Show("Los datos fueron almacenados");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            if (sw != null)
                                sw.Close();
                            if (f != null)
                                f.Close();
                        }
                    }
                }
                else if(ms == MessageBoxResult.No)
                {
                    file = "";
                    txt1.Clear();
                }
            }
            else
            {
                try
                {
                    f = new FileStream(file, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(f);
                    sw.Write("\n");
                    sw.Write(txt1.Text);
                    MessageBox.Show("Los datos fueron almacenados");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (sw != null)
                        sw.Close();
                    if (f != null)
                        f.Close();
                }
            }
        }

        private void btnAbrir_Click(object sender, RoutedEventArgs e)
        {
            FileStream f=null;
            StreamReader sr=null;
            string x;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //filtrar para mostrar solo los archivos de tipo texto
            openFileDialog1.Filter = "text|*.txt"; //"Text files (*.txt)|*.txt"   "All files (*.*)|*.*"
            //definir una direccion por defecto
            openFileDialog1.InitialDirectory = @"d:\";
            // mostrar la ventana para que el usuario seleccione el archivo que desea abrir.  
            if (openFileDialog1.ShowDialog() == true) // Test result.
            {

                file = openFileDialog1.FileName;
                try
                {
                    f = new FileStream(file, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(f);
                    x = sr.ReadToEnd();
                    txt1.Text = x;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR " + ex.Message);
                }
                finally
                {
                    if (sr != null)
                        sr.Close();
                    if (f != null)
                        f.Close();
                }

            }
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            FileStream f = null;
            StreamWriter sw = null;
            if (file == "")
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Title = "Guardar un archivo de tipo text";
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.Filter = "Text files (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

                if (saveFileDialog1.ShowDialog() == true)
                {
                    file = saveFileDialog1.FileName;
                    try
                    {
                        f = new FileStream(file, FileMode.Create, FileAccess.Write);
                        sw = new StreamWriter(f);
                        sw.Write("\n");
                        sw.Write(txt1.Text);
                        MessageBox.Show("Los datos fueron almacenados");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (sw != null)
                            sw.Close();
                        if (f != null)
                            f.Close();
                    }
                }
                else
                {
                    try
                    {
                        f = new FileStream(file, FileMode.Create, FileAccess.Write);
                        sw = new StreamWriter(f);
                        sw.Write("\n");
                        sw.Write(txt1.Text);
                        MessageBox.Show("Los datos fueron almacenados");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (sw != null)
                            sw.Close();
                        if (f != null)
                            f.Close();
                    }
                }
            }
        }

        private void btnGuardarComo_Click(object sender, RoutedEventArgs e)
        {
            FileStream f=null;
            StreamWriter sw=null;
            

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Guardar un archivo de tipo text";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == true)
            {
                    file = saveFileDialog1.FileName;
                try
                {
                    f = new FileStream(file, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(f);
                    sw.Write("\n");
                    sw.Write(txt1.Text);
                    MessageBox.Show("Los datos fueron almacenados");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (sw != null)
                        sw.Close();
                    if (f != null)
                        f.Close();
                }
            }
        }
    }
}
