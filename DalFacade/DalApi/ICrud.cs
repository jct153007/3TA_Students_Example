using DO;

namespace DalApi
{
    public interface ICrud<T> where T : struct
    {
        int Add(T item);
        void Delete(int id);
        IEnumerable<T?> GetAll(Func<T?, bool>? filter = null);
        Student GetById(int id);
        void Update(T item);
    }
}