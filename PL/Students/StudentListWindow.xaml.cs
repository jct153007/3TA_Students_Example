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
            StatusSelector.ItemsSource = Enum.GetValues(typeof(BO.StudentStatus));
            StudentsListview.ItemsSource = bl.Student.GetAll();
        }

        private void StatusSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BO.StudentStatus status = (BO.StudentStatus)e.AddedItems[0];
            StudentsListview.ItemsSource = bl.Student.GetStudentsByStatus(status);
        }

        private void AddStudentButton_Click(object sender, RoutedEventArgs e) => new StudentWindow().Show();
        
    }
}
