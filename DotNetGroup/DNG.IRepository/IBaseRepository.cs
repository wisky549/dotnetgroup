using DNG.Entity.Interfaces;

namespace DNG.IRepository
{
    public interface IBaseRepository<T> where T: IEntity
    {
        T Get(int id);

        int Insert(T entity);

        bool Update(T entity);

        bool Delete(T entity);
    }
}
