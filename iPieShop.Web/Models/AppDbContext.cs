using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace iPieShop.Web.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Category 1"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Category 2"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Category 3"
                },
                new Category()
                {
                    Id = 4,
                    Name = "Category 4"
                },
                new Category()
                {
                    Id = 5,
                    Name = "Category 5"
                });

            modelBuilder.Entity<Pie>().HasData(
                new Pie()
                {
                    Id = 1,
                    CategoryId = 1,
                    Description = "SOME DESCRIPTION HERE",
                    ImageUrl = "SOME IMAGE HERE",
                    Name = "SOME NAME HERE",
                    Price = 1000
                },
                new Pie()
                {
                    Id = 2,
                    CategoryId = 2,
                    Description = "SOME DESCRIPTION HERE",
                    ImageUrl = "SOME IMAGE HERE",
                    Name = "SOME NAME HERE",
                    Price = 2000
                },
                new Pie()
                {
                    Id = 3,
                    CategoryId = 3,
                    Description = "SOME DESCRIPTION HERE",
                    ImageUrl = "SOME IMAGE HERE",
                    Name = "SOME NAME HERE",
                    Price = 3000
                },
                new Pie()
                {
                    Id = 4,
                    CategoryId = 4,
                    Description = "SOME DESCRIPTION HERE",
                    ImageUrl = "SOME IMAGE HERE",
                    Name = "SOME NAME HERE",
                    Price = 4000
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}