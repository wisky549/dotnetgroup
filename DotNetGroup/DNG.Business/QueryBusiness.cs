using DNG.Entity;
using DNG.IRepository;
using DNG.Model.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DNG.Business
{
    public class QueryBusiness
    {
        public QueryBusiness(IQueryRepository queryRepository, IUserRepository userRepository)
        {
            _userRepo = userRepository;
            _queryRepo = queryRepository;
        }

        IUserRepository _userRepo;
        IQueryRepository _queryRepo;

        public async Task<Rep<QueryResultModel>> UpdateUsersAsync(QueryModel model)
        {
            var rep = new Rep<QueryResultModel>() { Data = new QueryResultModel() };

            using (var http = new HttpClient())
            {
                string data = await http.GetStringAsync(model.Query);

                var obj = JsonConvert.DeserializeObject<QueryUserFb_Member>(data);
                if (obj != null && obj.data != null)
                {
                    foreach(QueryUserFb_User user in obj.data)
                    {
                        _userRepo.Insert(new UserEntity
                        {
                            Fb_Id = user.id,
                            Fb_Name = user.name,
                            Created = DateTime.Now,
                            Fb_IsAdmin = user.administrator,
                        });
                    }

                    rep.Success = true;
                    rep.Data.NextQuery = obj.paging.next;
                    rep.Data.ProcessCount = obj.data.Length;

                    _queryRepo.Insert(new QueryEntity
                    {
                        Query = model.Query,
                        Created = DateTime.Now,
                        Next = obj.paging.next,
                    });
                }
            }

            return rep;
        }
    }
}
