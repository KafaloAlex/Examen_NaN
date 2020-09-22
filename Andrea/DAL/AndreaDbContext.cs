using Andrea.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Andrea.DAL
{
    public class AndreaDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-6POII0J\SQLEXPRESS;Initial Catalog=AndreaDB;Integrated Security=True"));
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category>Categories { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<Contact_Info> Contact_Infos { get; set; }
        public DbSet<Contact_Post> Contact_Posts { get; set; }
        public DbSet<About> Abouts { get; set; }
    }
}