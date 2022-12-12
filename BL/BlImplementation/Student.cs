using BlApi;

namespace BlImplementation;

internal class Student : IStudent
{
    DalApi.IDal dal = new Dal.DalList();
    public int Add(BO.Student student)
    {
        DO.Student studentDO= new DO.Student()
        { 
            Name = student.Name,
            BirthDate = student.BirthDate,
            PersonalId = student.PersonalId,
            StartYear = student.StartYear,
            Status = (DO.StudentStatus)student.Status,
        };

        return dal.Student.Add(studentDO);
    }

    public IEnumerable<BO.StudentForList> GetAll()
    {
        // Stage 2. without Linq
        List<BO.StudentForList> students = new List<BO.StudentForList>();
        foreach (var student in dal.Student.GetAll())
        {
            students.Add(new BO.StudentForList()
            {
                ID = student.ID,
                Name = student.Name,
                PersonalId = student.PersonalId,
                StartYear = student.StartYear,
                Status = (BO.StudentStatus)student.Status,                
            });
        }
        return students;
    }
}