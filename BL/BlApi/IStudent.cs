using BO;

namespace BlApi;

public interface IStudent
{
    int Add(Student student);
    IEnumerable<StudentForList> GetAll();
}