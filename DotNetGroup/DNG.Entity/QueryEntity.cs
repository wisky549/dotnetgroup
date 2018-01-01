using DNG.Entity.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DNG.Entity
{
    [Table("Query")]
    public class QueryEntity : IEntity
    {
        public int Id { get; set; }

        public DateTime Created { get; set; }
    }
}
