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

namespace ejemplo1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }        

        private void DatePicker_DateValidationError(object sender, DatePickerDateValidationErrorEventArgs e)
        {
            DateTime newDate;
            DatePicker datePickerObj = sender as DatePicker;
            DateTime.TryParse(e.Text, out newDate);       
            e.ThrowException = true;
            
        }





        //private void DatePicker_DateValidationError(object sender,DatePickerDateValidationErrorEventArgs e)
        //{
        //    DateTime newDate;
        //    DatePicker datePickerObj = sender as DatePicker;

        //    if (DateTime.TryParse(e.Text, out newDate))
        //    {
        //        if (datePickerObj.BlackoutDates.Contains(newDate))
        //        {
        //            MessageBox.Show(String.Format("The date, {0}, cannot be selected.",e.Text));
        //        }
        //    }
        //    else
        //    {
        //        e.ThrowException = true;
        //    }
        //}
    }
}
