using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using my_blog.Models;
using Microsoft.EntityFrameworkCore;

namespace my_blog.Data
{
    public class MyBlogContext : DbContext
    {
        public MyBlogContext(DbContextOptions<MyBlogContext> options) : base(options)
        {

        }
        public DbSet<Post> Post { get; set; }

        public DbSet<Comment> Comment { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<Menu> Menu { get; set; }



    }
}
