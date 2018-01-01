namespace DNG.Model.Models
{
    public class QueryUserFb
    {
        public QueryUserFb_Member members { get; set; }
    }

    public class QueryUserFb_Member
    {
        public QueryUserFb_User[] data { get; set; }

        public QueryPaging paging { get; set; }
    }

    public class QueryUserFb_User
    {
        public long id { get; set; }

        public string name { get; set; }

        public bool administrator { get; set; }
    }
}
