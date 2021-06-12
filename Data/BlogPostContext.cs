using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Imaging360Task.models;

    public class BlogPostContext : DbContext
    {
        public BlogPostContext (DbContextOptions<BlogPostContext> options)
            : base(options)
        {
        }

        public DbSet<Imaging360Task.models.Post> Posts { get; set; }

        public DbSet<Imaging360Task.models.Comment> Comments { get; set; }
    }
