using Dapper.Contrib.Extensions;
using DNG.IRepository;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DNG.Repository.Dapper
{
    public abstract class BaseRepository
    {
        public BaseRepository(IRepoSetting repoSetting)
        {
            _setting = repoSetting;
        }

        protected IRepoSetting _setting;
    }

    public abstract class BaseRepository<T> where T : class
    {
        public BaseRepository(IRepoSetting repoSetting)
        {
            _setting = repoSetting;
        }

        protected IRepoSetting _setting;

        public virtual async Task<T> GetAsync(int id)
        {
            using (var con = new SqlConnection(_setting.ConnectionString))
            {
                con.Open();

                return await con.GetAsync<T>(id);
            }
        }

        public virtual async Task<int> InsertAsync(T entity)
        {
            using (var con = new SqlConnection(_setting.ConnectionString))
            {
                con.Open();

                return await con.InsertAsync(entity);
            }
        }

        public virtual async Task<bool> UpdateAsync(T entity)
        {
            using (var con = new SqlConnection(_setting.ConnectionString))
            {
                con.Open();

                return await con.UpdateAsync(entity);
            }
        }

        public virtual async Task<bool> DeleteAsync(T entity)
        {
            using (var con = new SqlConnection(_setting.ConnectionString))
            {
                con.Open();

                return await con.DeleteAsync(entity);
            }
        }
    }
}
