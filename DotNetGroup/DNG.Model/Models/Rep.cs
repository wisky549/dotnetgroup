namespace DNG.Model.Models
{
    public class Rep<T>
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public T Data { get; set; }
    }

    public class Rep : Rep<object>
    {

    }
}
