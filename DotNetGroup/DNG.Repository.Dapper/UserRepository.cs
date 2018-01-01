using Dapper.Contrib.Extensions;
using DNG.Entity;
using DNG.IRepository;
using System;
using System.Data.SqlClient;

namespace DNG.Repository.Dapper
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(IRepoSetting repoSetting)
            : base(repoSetting)
        {
        }

        public bool Delete(UserEntity entity)
        {
            throw new NotImplementedException();
        }

        public UserEntity Get(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(UserEntity entity)
        {
            using (var con = new SqlConnection(_setting.ConnectionString))
            {
                con.Open();

                return (int)con.Insert(entity);
            }
        }

        public bool Update(UserEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
