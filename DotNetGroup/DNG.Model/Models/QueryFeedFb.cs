using System;

namespace DNG.Model.Models
{
    public class QueryFeedFb
    {
        public QueryPostFb[] data { get; set; }

        public QueryPaging paging { get; set; }
    }

    public class QueryPostFb
    {
        public string id { get; set; }

        public string message { get; set; }

        public string permalink_url { get; set; }

        public DateTime created_time { get; set; }

        public QueryFeedFromFb from { get; set; }

        public QueryCommentFb comments { get; set; }

        public QueryReactionFb reactions { get; set; }
    }

    public class QueryCommentFb
    {
        public QueryCommentDataFb[] data { get; set; }

        public QueryPaging paging { get; set; }
    }

    public class QueryCommentDataFb
    {
        public string id { get; set; }

        public string message { get; set; }

        public int like_count { get; set; }

        public DateTime created_time { get; set; }

        public QueryFeedFromFb from { get; set; }

        public QueryCommentFb comments { get; set; }
    }

    public class QueryFeedFromFb
    {
        public long id { get; set; }

        public string name { get; set; }
    }
}
