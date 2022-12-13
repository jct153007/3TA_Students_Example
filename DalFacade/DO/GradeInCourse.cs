namespace DO;

public struct GradeInCourse
{
    public int ID { get; set; }
    public int StudentID { get; set; }
    public int CoruseID { get; set; }
    public int? Grade { get; set; }
    public override string ToString() => $@"
        GradeInCourse = {StudentID} {CoruseID} : {Grade}";
}
