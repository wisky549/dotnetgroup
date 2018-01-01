using System.ComponentModel.DataAnnotations;

namespace DNG.Model.Models
{
    public class QueryModel
    {
        [Required]
        public string Query { get; set; }
    }
}
