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

        [Route("run")]
        public async Task<Rep<QueryResultModel>> Run(QueryModel model)
        {
            var rep = GetRep<QueryResultModel>(ModelState);

            if (rep.Success)
            {
                rep = await _business.UpdateUsersAsync(model);
            }

            return rep;
        }
    }
}