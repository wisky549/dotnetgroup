﻿// <auto-generated />
using DNG.Repository.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DNG.Repository.EF.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20180101101750_commentpost")]
    partial class commentpost
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DNG.Entity.CommentEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("Fb_created_time");

                    b.Property<long>("Fb_from");

                    b.Property<string>("Fb_message");

                    b.Property<string>("Fb_permalink_url");

                    b.Property<int>("ForPostId");

                    b.Property<int>("LikeCount");

                    b.HasKey("Id");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("DNG.Entity.PostEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("Fb_created_time");

                    b.Property<long>("Fb_from");

                    b.Property<string>("Fb_message");

                    b.Property<string>("Fb_permalink_url");

                    b.Property<int>("LikeCount");

                    b.HasKey("Id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("DNG.Entity.QueryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Next");

                    b.Property<string>("Query");

                    b.HasKey("Id");

                    b.ToTable("Queries");
                });

            modelBuilder.Entity("DNG.Entity.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<long>("Fb_Id");

                    b.Property<bool>("Fb_IsAdmin");

                    b.Property<string>("Fb_Name");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}