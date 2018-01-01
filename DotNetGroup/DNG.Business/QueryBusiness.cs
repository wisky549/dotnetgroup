using DNG.IRepository;

namespace DNG.Business
{
    public class QueryBusiness
    {
        public QueryBusiness(IQueryRepository queryRepository)
        {
            _queryRepo = queryRepository;
        }

        IQueryRepository _queryRepo;
    }
}
