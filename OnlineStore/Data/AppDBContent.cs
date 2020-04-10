using Microsoft.EntityFrameworkCore;
using OnlineStore.Data.Models;

namespace OnlineStore.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {
            
        }

        public DbSet<Book> Book { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<StoreCartItem> StoreCartItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    id = 3,
                    categoryName = "ASP",
                    desc = "Books about ASP.NET"
                });

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    id = 4,
                    name = "ASP NET Core in Action",
                    shortDesc = "Andrew Lock",
                    longDesc = "This book is about the ASP.NET Core framework, what it is, and how you can use it to build web applications.",
                    img = "/img/ASPNETinAction.jpg",
                    price = 1020,
                    isFavorite = false,
                    avalible = true,
                    categoryID = 3
                },
                new Book
                {
                    id = 5,
                    name = "ASP NET Core A-Z",
                    shortDesc = "Shahed Chowdhuri",
                    longDesc = "This book is a phenomenal achievement, and it’s been really exciting to have been along for the ridefrom the beginning.",
                    img = "/img/aspnetcoreaz.jpg",
                    price = 1400,
                    isFavorite = false,
                    avalible = true,
                    categoryID = 3
                },
                new Book
                {
                    id = 6,
                    name = "C# 8.0 and .NET Core 3.0",
                    shortDesc = "Mark J. Price",
                    longDesc = "Build applications with C#, .NET Core, EntityFramework Core, ASP.NET Core, using Visual Studio Code",
                    img = "/img/C8.0and.NETCore3.0.jpg",
                    price = 1800,
                    isFavorite = true,
                    avalible = true,
                    categoryID = 1
                },
                new Book
                {
                    id = 7,
                    name = "Front‐end Development with ASP.NET Core, Angular, and Bootstrap",
                    shortDesc = "Simone Chiaretta",
                    longDesc = "There was a time when “backend” and “front‐end” developers were doing pretty different work.",
                    img = "/img/Front‐endDevelopment.jpg",
                    price = 1500,
                    isFavorite = true,
                    avalible = true,
                    categoryID = 3
                });
        }
    }
}
