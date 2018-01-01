using DNG.Entity;
using DNG.IRepository;

namespace DNG.Repository.Dapper
{
    public class CommentRepository : BaseRepository<CommentEntity>, ICommentRepository
    {
        public CommentRepository(IRepoSetting repoSetting)
            : base(repoSetting)
        {
        }
    }
}
