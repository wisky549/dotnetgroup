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
        public QueryBusiness(IQueryRepository queryRepo, IUserRepository userRepo,
            IPostRepository postRepo, ICommentRepository commentRepo)
        {
            _postRepo = postRepo;
            _userRepo = userRepo;
            _queryRepo = queryRepo;
            _commentRepo = commentRepo;
        }

        IPostRepository _postRepo;
        IUserRepository _userRepo;
        IQueryRepository _queryRepo;
        ICommentRepository _commentRepo;

        public async Task<Rep<QueryResultModel>> UpdateUsersAsync(QueryModel model)
        {
            var rep = new Rep<QueryResultModel>() { Data = new QueryResultModel() };

            using (var http = new HttpClient())
            {
                string data = await http.GetStringAsync(model.Query);

                var obj = JsonConvert.DeserializeObject<QueryUserFb_Member>(data);
                if (obj != null && obj.data != null)
                {
                    foreach (QueryUserFb_User user in obj.data)
                    {
                        await _userRepo.InsertAsync(new UserEntity
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

                    await _queryRepo.InsertAsync(new QueryEntity
                    {
                        Query = model.Query,
                        Created = DateTime.Now,
                        Next = obj.paging.next,
                        Group = QueryGroup.UpdateUser,
                    });
                }
            }

            return rep;
        }

        public async Task<Rep<QueryResultModel>> UpdateFeedsAsync(QueryModel model)
        {
            var rep = new Rep<QueryResultModel>() { Data = new QueryResultModel() };

            using (var http = new HttpClient())
            {
                string data = await http.GetStringAsync(model.Query);

                var obj = JsonConvert.DeserializeObject<QueryFeedFb>(data);
                if (obj != null && obj.data != null)
                {
                    foreach (QueryPostFb post in obj.data)
                    {
                        var postEntity = new PostEntity
                        {
                            Created = DateTime.Now,
                            Fb_from = post.from.id,
                            Fb_message = post.message,
                            Fb_created_time = post.created_time,
                            Fb_permalink_url = post.permalink_url,
                        };

                        if (post.reactions != null && post.reactions.data != null)
                        {
                            postEntity.LikeCount = post.reactions.data.Length;
                        }

                        int postId = await _postRepo.InsertAsync(postEntity);

                        if (post.comments != null && post.comments.data != null)
                        {
                            foreach (QueryCommentDataFb comment in post.comments.data)
                            {
                                await _commentRepo.InsertAsync(new CommentEntity
                                {
                                    ForPostId = postId,
                                    Created = DateTime.Now,
                                    Fb_from = comment.from.id,
                                    Fb_message = comment.message,
                                    LikeCount = comment.like_count,
                                    Fb_created_time = comment.created_time,
                                });

                                if (comment.comments != null && comment.comments.data != null)
                                {
                                    foreach (QueryCommentDataFb subComment in comment.comments.data)
                                    {
                                        await _commentRepo.InsertAsync(new CommentEntity
                                        {
                                            ForPostId = postId,
                                            Created = DateTime.Now,
                                            Fb_from = subComment.from.id,
                                            LikeCount = comment.like_count,
                                            Fb_message = subComment.message,
                                            Fb_created_time = subComment.created_time,
                                        });
                                    }
                                }
                            }
                        }
                    }

                    rep.Success = true;
                    rep.Data.NextQuery = obj.paging.next;
                    rep.Data.ProcessCount = obj.data.Length;

                    await _queryRepo.InsertAsync(new QueryEntity
                    {
                        Query = model.Query,
                        Created = DateTime.Now,
                        Next = obj.paging.next,
                        Group = QueryGroup.UpdateFeed,
                    });
                }
            }

            return rep;
        }

        class QueryGroup
        {
            public const string UpdateUser = "UpdateUser";
            public const string UpdateFeed = "UpdateFeed";
        }
    }
}
