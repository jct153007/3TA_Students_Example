using BO;

namespace BlApi;

public interface IStudent
{
    int Add(Student student);
    IEnumerable<StudentForList> GetAll();
    Student GetById(int id);
    IEnumerable<StudentForList> GetStudentsByStatus(StudentStatus status);
}