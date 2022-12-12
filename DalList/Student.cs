using DO;
using DalApi;
namespace Dal;

internal class Student : IStudent
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
    public IEnumerable<DO.Student> GetAll()
    {
        return DataSource.students.Select(student => student);
    }

    public DO.Student GetById(int id)
    {
        return DataSource.students.Find(student => student.PersonalId == id);
    }
}
