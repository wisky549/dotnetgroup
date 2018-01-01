using System.Threading.Tasks;

namespace DNG.IRepository
{
    public interface IBaseRepository<T> where T: class
    {
        Task<T> GetAsync(int id);

        Task<int> InsertAsync(T entity);

        Task<bool> UpdateAsync(T entity);

        Task<bool> DeleteAsync(T entity);
    }
}
