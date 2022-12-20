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
using BlApi;

namespace PL.Students
{
    /// <summary>
    /// Interaction logic for StudentListWindow.xaml
    /// </summary>
    public partial class StudentListWindow : Window
    {
        IBl bl = new BlImplementation.Bl();

        public StudentListWindow()
        {
            InitializeComponent();
            StudentsListview.ItemsSource = bl.Student.GetAll();
        }
    }
}
