
using BlApi;

namespace BlImplementation;

sealed public class Bl : IBl
{
    public IStudent Student => new Student();

    public ICourse Course => new Course();

    public IGrade Grade => new Grade();
}
