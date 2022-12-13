using DalApi;

namespace Dal;

internal class Course : ICourse
{
    public int Add(DO.Course item)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<DO.Course?> GetAll(Func<DO.Course?, bool>? filter = null)
    {
        throw new NotImplementedException();
    }

    public DO.Student GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(DO.Course item)
    {
        throw new NotImplementedException();
    }
}
