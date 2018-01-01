using DNG.Entity;
using DNG.IRepository;

namespace DNG.Repository.Dapper
{
    public class PostRepository : BaseRepository<PostEntity>, IPostRepository
    {
        public PostRepository(IRepoSetting repoSetting)
            : base(repoSetting)
        {
        }
    }
}
