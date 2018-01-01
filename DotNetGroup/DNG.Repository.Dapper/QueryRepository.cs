using Dapper.Contrib.Extensions;
using DNG.Entity;
using DNG.IRepository;
using System.Data.SqlClient;

namespace DNG.Repository.Dapper
{
    public class QueryRepository : BaseRepository, IQueryRepository
    {
        public QueryRepository(string con)
            : base(con)
        {
        }

        public bool Delete(QueryEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public QueryEntity Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Insert(QueryEntity entity)
        {
            using (var con = new SqlConnection(ConStr))
            {
                con.Open();

                return (int)con.Insert(entity);
            }
        }

        public bool Update(QueryEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
