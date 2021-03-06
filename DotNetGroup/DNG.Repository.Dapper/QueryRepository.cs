﻿using DNG.Entity;
using DNG.IRepository;

namespace DNG.Repository.Dapper
{
    public class QueryRepository : BaseRepository<QueryEntity>, IQueryRepository
    {
        public QueryRepository(IRepoSetting repoSetting)
            : base(repoSetting)
        {
        }
    }
}
