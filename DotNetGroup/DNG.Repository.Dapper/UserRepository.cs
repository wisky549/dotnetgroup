using DNG.Entity;
using DNG.IRepository;

namespace DNG.Repository.Dapper
{
    public class UserRepository : BaseRepository<UserEntity>, IUserRepository
    {
        public UserRepository(IRepoSetting repoSetting)
            : base(repoSetting)
        {
        }
    }
}
