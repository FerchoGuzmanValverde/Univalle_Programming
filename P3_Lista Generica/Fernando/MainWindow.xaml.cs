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

namespace Fernando
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BaseDatos db = new BaseDatos();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //consultas


            //NOMBRE APELLIDO Y EDAD PROFESORES

            /*var resultado = from mat in db.Materias
                            group mat by mat.TeacherId into grp
                            join prof in db.Teachers
                            on grp.Key equals prof.Id
                            select new
                            {
                                TeacherName = prof.Nombre,
                                TeacherId = prof.Id,
                                LectureCount = grp.Count()
                            };*/

            /*var resultado = from mat in db.Materias
                            group mat by mat.TeacherId into grp
                            //proyeccion
                            select new
                            {
                                TeacherId = grp.Key,
                                ContadorMaterias = grp.Count()
                            };

            foreach (var r1 in resultado)
            {
                txtR.AppendText("ID = " + r1.TeacherId + " Contador: " r1.ContadorMaterias + "\n");
            }*/

            var resultado = from pro in db.Teachers
                            where pro.Correo.LastIndexOf(".") != -1
                            group pro by pro.Correo.Substring(pro.Correo.LastIndexOf("."));

            foreach (var r1 in resultado)
            {
                txtR.AppendText("Agrupado por ..... " + r1.Key + "\n");
                foreach (var v in r1)
                {
                    txtR.AppendText(" " + v.Nombre + " Correo " + v.Correo + "\n");
                }
            }

            /*var resultado = (from pro in db.Teachers
                             where pro.Edad < 35
                             select pro.Edad).Count();

            txtR.Text = "" + resultado;*/

            /*var resultado = (from pro in db.Teachers

                             select pro.Edad).Average();

            txtR.Text = "" + resultado;
            */
            /*var query = from pro in db.Teachers
                        where
                        //where pro.Edad > 45
                        //where pro.Correo.EndsWith(".edu")
                        select pro;
            foreach (var r1 in query)
            {
                txtR.AppendText("Nombre: "+r1.Nombre+", Apellido: "+r1.Apellido+", Edad: "+r1.Edad+"\n");
            }*/

            //NOMBRE DE LAS MATERIAS
            /*var query = from mat in db.Materias
                        where mat.Nombre.StartsWith("O")
                        //where mat.Nombre.EndsWith("A")
                        orderby mat.Nombre descending
                        select mat.Nombre;
            foreach (var r1 in query)
            {
                txtR.AppendText(" "+r1+"\n");
            }*/
        }
    }
}
