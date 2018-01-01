namespace DNG.Model.Models
{
    public class QueryPaging
    {
        public Cursor cursors { get; set; }

        public string next { get; set; }
    }

    public class Cursor
    {
        public string before { get; set; }

        public string after { get; set; }
    }
}
