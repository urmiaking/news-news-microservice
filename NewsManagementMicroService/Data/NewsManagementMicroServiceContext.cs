using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewsManagementMicroService.Models;

namespace NewsManagementMicroService.Data
{
    public class NewsManagementMicroServiceContext : DbContext
    {
        public NewsManagementMicroServiceContext (DbContextOptions<NewsManagementMicroServiceContext> options)
            : base(options)
        {
        }

        public DbSet<News> News { get; set; }
        public DbSet<NewsGroup> NewsGroups { get; set; }
        public DbSet<Comment> Comments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<NewsGroup>()
                .HasMany(c => c.News)
                .WithOne(e => e.NewsGroup);

            modelBuilder.Entity<News>()
                .HasMany(c => c.Comments)
                .WithOne(e => e.News);

            modelBuilder.Seed();
        }
    }
}
