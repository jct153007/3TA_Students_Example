

namespace BO;

public class CourseForList
{
    public int ID { get; set; }
    public string? Name { get; set; }
    public int Year { get; set; }
    public Semester Semester { get; set; }
    public override string ToString() => $@"
        Course = {ID} {Semester} : {Name}";
}
