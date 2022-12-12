using DalApi;
using System;

namespace DalTest // Note: actual namespace depends on the project name.
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            IDal dal = new Dal.DalList();
            int choice = showMenu();

            DO.Student student = new DO.Student()
            {
                BirthDate = new DateTime(1990, 1, 1),
                PersonalId = 2000000,
                StartYear = 2020,
                Status = DO.StudentStatus.ACTIVE
            };

            int newStudentID = dal.Student.Add(student);   //dalStudent.Add(student);
            Console.WriteLine($"New Student ID : {newStudentID}" );
            Console.WriteLine(dal.Student.GetById(student.PersonalId));
        }

        private static int showMenu()
        {
            Console.WriteLine("Please enter \n" +
                        "0 - exit \n" +
                        "1 - Students \n" +
                        "2 - Coureses \n" +
                        "3 - Grades");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}