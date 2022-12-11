using System;

namespace DalTest // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DO.Student student = new DO.Student()
                { 
                    BirthDate = new DateTime(1990, 1, 1),
                    personalId = 2000000,
                    StartYear = 2020,
                    Status = DO.StudentStatus.ACTIVE
                };
            Dal.Student dalStudent = new Dal.Student();
            dalStudent.AddStudent(student);
            Console.WriteLine("Hello World!");
        }
    }
}