using DO;
using DalApi;
using System.Linq;

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


    public DO.Student GetById(int id)
    {
        DO.Student? student = DataSource.students.FirstOrDefault(s => s?.PersonalId == id);
        if (student == null)
            throw new DalDoesNotExistException($"Student with PersonalId={id} does Not exist");
        return student ?? new();
    }

    public IEnumerable<DO.Student?> GetAll(Func<DO.Student?, bool>? filter = null)
    {
        if (filter == null)
            return DataSource.students.Select(student => student);
        else
            return DataSource.students.Where(student => filter(student));
    }
}
