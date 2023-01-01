using BlApi;
using BlImplementation;
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

namespace PL.Students
{
    /// <summary>
    /// Interaction logic for StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        IBl bl = new BlImplementation.Bl();
        public StudentWindow()
        {
            InitializeComponent();
            Status_ComboBox.ItemsSource = Enum.GetValues(typeof(BO.StudentStatus));
        }

        private void AddStudentButton_Click(object sender, RoutedEventArgs e)
        {
            BO.Student student = new()
            {
                PersonalId = int.Parse(PersonalId_TextBox.Text),
                Name = StudentName_TextBox.Text,
                StartYear = int.Parse(StartYear_TextBox.Text),
                Status = (BO.StudentStatus)Status_ComboBox.SelectedValue,
                BirthDate = DateTime.Parse(BirthDate_TextBox.Text)
            };
            bl.Student.Add(student);
            this.Close();
        }
    }
}
