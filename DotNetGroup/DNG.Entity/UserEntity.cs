using DNG.Entity.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DNG.Entity
{
    [Table("Users")]
    public class UserEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        public long Fb_Id { get; set; }

        public string Fb_Name { get; set; }

        public bool Fb_IsAdmin { get; set; }

        public DateTime Created { get; set; }
    }
}
