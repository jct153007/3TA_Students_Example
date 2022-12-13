using DO;
using System.Collections.Generic;

namespace Dal;

public static class DataSource
{
    static readonly Random random= new Random();

    internal static List<DO.Student?> students = new List<DO.Student?>();
    internal static List<DO.Course?> courses = new List<DO.Course?>();
    internal static List<DO.GradeInCourse?> grades = new List<DO.GradeInCourse?>();

    internal static class Config
    {
        internal const int s_startStudentId = 1000;
        private static int s_nextStudentId = s_startStudentId;
        internal static int NextStudentId { get => s_nextStudentId++; }

        internal const int s_startGradeId = 1000;
        private static int s_nextGradeId = s_startGradeId;
        internal static int NextGradeId { get => s_nextGradeId++; }
    }

    static DataSource()
    {
        s_initialize();
    }

    private static void s_initialize()
    {
        createStudents();
        createCourses();
        createGrades();
    }

    private static void createGrades()
    {
        for (int i = 0; i < 30; i++)
        {
            grades.Add(
                new DO.GradeInCourse()
                {
                    ID = Config.NextGradeId,
                    StudentID = ((DO.Student)students[random.Next(students.Count)]!).ID,
                    CoruseID = ((DO.Course)courses[random.Next(courses.Count)]!).ID,
                    Grade = random.Next(40, 101)
                }) ;
        }

    }

    private static void createCourses()
    {
        for (int i = 0; i < 10; i++)
        {
            courses.Add(
                new DO.Course()
                {
                    ID = random.Next(15000, 15999),
                    Semester = (Semester)random.Next(5),
                    Year = random.Next(2020, 2023)
                });
        }
    }

    private static void createStudents()
    {
        for (int i = 0; i < 50; i++)
        {
            students.Add(
                new DO.Student()
                {
                    ID = Config.NextStudentId,
                    PersonalId = random.Next(2000000, 3000000),
                    StartYear = random.Next(2020,2023),
                    Status = (StudentStatus)random.Next(5),
                    BirthDate = DateTime.Now - new TimeSpan(random.NextInt64(TimeSpan.TicksPerDay * 365L * 17L, TimeSpan.TicksPerDay * 365L * 35L)),
                    
        });
        }
    }
}