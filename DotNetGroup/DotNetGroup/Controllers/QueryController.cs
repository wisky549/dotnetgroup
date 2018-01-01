using DNG.Business;
using DNG.Model.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DotNetGroup.Controllers
{
    [Produces("application/json")]
    [Route("api/query")]
    public class QueryController : BaseController
    {
        public QueryController(QueryBusiness queryBusiness)
        {
            _business = queryBusiness;
        }

        QueryBusiness _business;

        [Route("user")]
        public async Task<Rep<QueryResultModel>> UpdateUser(QueryModel model)
        {
            var rep = GetRep<QueryResultModel>(ModelState);

            if (rep.Success)
            {
                rep = await _business.UpdateUsersAsync(model);
            }

            return rep;
        }

        [Route("feed")]
        public async Task<Rep<QueryResultModel>> UpdateFeed(QueryModel model)
        {
            var rep = GetRep<QueryResultModel>(ModelState);

            if (rep.Success)
            {
                rep = await _business.UpdateFeedsAsync(model);
            }

            return rep;
        }
    }
}