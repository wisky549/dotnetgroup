using DNG.Entity.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DNG.Entity
{
    [Table("Posts")]
    public class PostEntity : IEntity
    {
        public int Id { get; set; }

        public string Fb_message { get; set; }

        public long Fb_from { get; set; }

        public string Fb_permalink_url { get; set; }

        public DateTime Fb_created_time { get; set; }

        public int LikeCount { get; set; }

        public DateTime Created { get; set; }
    }
}
