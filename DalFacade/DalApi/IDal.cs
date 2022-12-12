
namespace DalApi;

public interface IDal
{
    IStudent Student { get; }
    ICourse Course { get; }
    IGrade Grade { get; }
}
