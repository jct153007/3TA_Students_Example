
namespace BO;

public class Course
{
    public int ID { get; set; }
    public string? Name { get; set; }
    public int Year { get; set; }
    public string? Lecturer { get; set; }
    public Semester Semester { get; set; }
    public List<StudentInCourse> Students { get; set; }
    public override string ToString() => $@"
        Course = {ID} {Semester} : {Name}";
}
