using DNG.IRepository;

namespace DNG.Repository.Dapper
{
    public class BaseRepository
    {
        public BaseRepository(IRepoSetting repoSetting)
        {
            _setting = repoSetting;
        }

        protected IRepoSetting _setting;
    }
}
