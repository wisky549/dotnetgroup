using DNG.Entity.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DNG.Entity
{
    [Table("Queries")]
    public class QueryEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        public string Group { get; set; }

        public string Query { get; set; }

        public string Next { get; set; }

        public DateTime Created { get; set; }
    }
}
