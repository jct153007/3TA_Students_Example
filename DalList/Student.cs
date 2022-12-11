using DO;
namespace Dal;

public class Student
{
	public int Add(DO.Student student)
	{
		student.ID = DataSource.Config.NextStudentId;
		DataSource.students.Add(student);
		return student.ID;

    }

	public void Update(DO.Student student) 
	{

	}

	public void Delete(int id)
	{

	}
	public List<DO.Student> GetAll()
	{
		return DataSource.students.Select(student => student).ToList();
	}

	public DO.Student GetById(int id) 
	{ 
		return DataSource.students.Find(student => student.PersonalId == id);
	}
}
