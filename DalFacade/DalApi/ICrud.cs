using DO;

namespace DalApi
{
    public interface ICrud<T>
    {
        int Add(T item);
        void Delete(int id);
        IEnumerable<T> GetAll();
        Student GetById(int id);
        void Update(T item);
    }
}