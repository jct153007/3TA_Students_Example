using BlApi;

namespace BlTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBl bl = new BlImplementation.Bl();

            int choice = showMenu();

            BO.Student student = new BO.Student()
            {
                BirthDate = new DateTime(1990, 1, 1),
                PersonalId = 2000000,
                StartYear = 2020,
                Name= "Test",
                Status = BO.StudentStatus.ACTIVE
            };

            int newStudentID = bl.Student.Add(student);

            foreach (var st in bl.Student.GetAll())
            {
                Console.WriteLine(st);
            }
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