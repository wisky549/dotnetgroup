using DNG.IRepository;

namespace DNG.Repository.Dapper
{
    public class RepoSetting : IRepoSetting
    {
        public string ConnectionString { get; set; }
    }
}
