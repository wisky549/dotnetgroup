namespace DNG.Repository.Dapper
{
    public class BaseRepository
    {
        public BaseRepository(string connection)
        {
            ConStr = connection;
        }

        protected string ConStr { get; set; }
    }
}
