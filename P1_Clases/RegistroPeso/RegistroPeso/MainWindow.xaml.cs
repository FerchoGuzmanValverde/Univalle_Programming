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
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Reflection;

namespace RegistroPeso
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Persona nueva = new Persona();
        float x, y;
        string j;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            j = txtnombre.Text;
            x = nueva.Peso = float.Parse(txtpeso.Text);
            y = nueva.Estatura = float.Parse(txtaltura.Text);
            validaciones();
        }

        private void validaciones()
        {
            if (x < 1)
            {
                MessageBox.Show("El valor de peso es invalido", "Error");
                txtpeso.Clear();
                txtpeso.Focus();
            }
            else if (y < 1 || y > 4)
            {
                MessageBox.Show("El valor de la estatura es invalido", "Error");
                txtaltura.Clear();
                txtaltura.Focus();
            }
            else if (j == "")
            {
                MessageBox.Show("Nombre no tiende contenido", "Error");
                txtnombre.Focus();
            }
            else
            {
                lstdetalles1.Items.Add(txtnombre.Text + "\t\t" + nueva.Ideal().ToString("N2") + "\t\t" + nueva.categorizar());
                nuevo();
                auxiliar();
            }
        }

        private void auxiliar()
        {
            List<Bar> _bar = new List<Bar>();
            _bar.Add(new Bar() { BarName = "C1", Value = nueva.C1() });
            _bar.Add(new Bar() { BarName = "C2", Value = nueva.C2() });
            _bar.Add(new Bar() { BarName = "C3", Value = nueva.C3() });
            _bar.Add(new Bar() { BarName = "C4", Value = nueva.C4() });
            _bar.Add(new Bar() { BarName = "C5", Value = nueva.C5() });
            _bar.Add(new Bar() { BarName = "C6", Value = nueva.C6() });
            _bar.Add(new Bar() { BarName = "C7", Value = nueva.C7() });
            _bar.Add(new Bar() { BarName = "C8", Value = nueva.C8() });
            this.DataContext = new RecordCollection(_bar);
        }

        private void btngenerales_Click(object sender, RoutedEventArgs e)
        {
            txtgenerales1.Text = "Categoria: Ingreso a hospital \t" + nueva.C1() + "\n" +
            "Categoria: Infrapeso \t\t" + nueva.C2() + "\n" +
            "Categoria: Bajo Peso \t\t" + nueva.C3() + "\n" +
            "Categoria: Peso Normal \t\t" + nueva.C4() + "\n" +
            "Categoria: Sobrepeso \t\t" + nueva.C5() + "\n" +
            "Categoria: Sobrepeso Cronico \t" + nueva.C6() + "\n" +
            "Categoria: Obesidad Pre-Morbida \t" + nueva.C7() + "\n" +
            "Categoria: Obesidad Morbida \t" + nueva.C8() + "\n";
        }

        private void nuevo()
        {
            txtnombre.Clear();
            txtaltura.Clear();
            txtpeso.Clear();
            txtnombre.Focus();
        }

        

        class RecordCollection : ObservableCollection<Record>
        {

            public RecordCollection(List<Bar> barvalues)
            {
                Random rand = new Random();
                BrushCollection brushcoll = new BrushCollection();

                foreach (Bar barval in barvalues)
                {
                    int num = rand.Next(brushcoll.Count / 3);
                    Add(new Record(barval.Value, brushcoll[num], barval.BarName));
                }
            }
        }
        class BrushCollection : ObservableCollection<Brush>
        {
            public BrushCollection()
            {
                Type _brush = typeof(Brushes);
                PropertyInfo[] props = _brush.GetProperties();
                foreach (PropertyInfo prop in props)
                {
                    Brush _color = (Brush)prop.GetValue(null, null);
                    if (_color != Brushes.LightSteelBlue && _color != Brushes.White &&
                         _color != Brushes.WhiteSmoke && _color != Brushes.LightCyan &&
                         _color != Brushes.LightYellow && _color != Brushes.Linen)
                        Add(_color);
                }
            }
        }

        class Bar
        {

            public string BarName { set; get; }

            public int Value { set; get; }

        }

        class Record : INotifyPropertyChanged
        {
            public Brush Color { set; get; }

            public string Name { set; get; }

            private int _data;
            public int Data
            {
                set
                {
                    if (_data != value)
                    {
                        _data = value;

                    }
                }
                get
                {
                    return _data;
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            public Record(int value, Brush color, string name)
            {
                Data = value;
                Color = color;
                Name = name;
            }

            protected void PropertyOnChange(string propname)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propname));
                }
            }
        }
    }
}
