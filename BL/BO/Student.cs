

namespace BO;

public class Student
{
    public int ID { get; set; }
    public int PersonalId { get; set; }
    public string Name { get; set; }
    public int StartYear { get; set; }
    public StudentStatus Status { get; set; }
    public DateTime BirthDate { get; set; }
    public List<CourseStudent> Courses { get; set; }
    public override string ToString() => $@"
        Studnet = {ID} : Name =  {Name} Personal ID = {PersonalId}";
}
