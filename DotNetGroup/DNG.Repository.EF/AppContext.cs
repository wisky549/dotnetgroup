﻿using DNG.Entity;
using Microsoft.EntityFrameworkCore;

namespace DNG.Repository.EF
{
    public class AppContext : DbContext
    {
        public DbSet<QueryEntity> Query { get; set; }

        public DbSet<UserEntity> User { get; set; }

        public DbSet<PostEntity> Post { get; set; }

        public DbSet<CommentEntity> Comment { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=DotNetGroup;Trusted_Connection=True;");
        }
    }
}
