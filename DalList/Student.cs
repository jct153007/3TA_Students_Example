using DO;
namespace Dal;

public class Student
{
	public int AddStudent(DO.Student student)
	{
		student.ID = DataSource.Config.NextStudentId;
		DataSource.students.Add(student);
		return student.ID;

    }
}
