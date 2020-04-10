using OnlineStore.Data.Interfaces;
using OnlineStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Data.Mocks
{
    public class MockBooks : IAllBooks
    {
        private readonly IBooksCategory _categoryBook = new MockCategory();

        public IEnumerable<Book> Books {
            get
            {
                return new List<Book>
                {
                    new Book
                    {
                        name = "CLR via C#",
                        shortDesc = "Jeffrey Richter",
                        longDesc = "CLR via C# by Jeffrey Richter",
                        img = "/img/CLRviaC.jpg",
                        price = 1500,
                        isFavorite = true,
                        avalible = true,
                        Category = _categoryBook.AllCategories.First()
                    },
                    new Book { name = "Pro C# 7",
                        shortDesc = "Andrew Troelsen, Philip Japikse",
                        longDesc = "Pro C# 7: With .NET and .NET Core 8th Edition, Kindle Edition",
                        img = "/img/ProC7.jpg",
                        price = 800,
                        isFavorite = true,
                        avalible = true,
                        Category = _categoryBook.AllCategories.First()
                    },
                    new Book { name = "Object Design Style Guide",
                        shortDesc = "Matthias Noback",
                        longDesc = "Object Design Style Guide 1st Edition by Matthias Noback",
                        img = "/img/ObjectDesign.jpg",
                        price = 200,
                        isFavorite = false,
                        avalible = true,
                        Category = _categoryBook.AllCategories.Last()
                    },
                    new Book
                    {
                        name = "ASP NET Core in Action",
                        shortDesc = "Andrew Lock",
                        longDesc = "This book is about the ASP.NET Core framework, what it is, and how you can use it to build web applications.",
                        img = "/img/ASPNETinAction.jpg",
                        price = 1020,
                        isFavorite = false,
                        avalible = true,
                        Category = _categoryBook.AllCategories.Last()
                    },
                    new Book
                    {
                        name = "ASP NET Core A-Z",
                        shortDesc = "Shahed Chowdhuri",
                        longDesc = "This book is a phenomenal achievement, and it’s been really exciting to have been along for the ridefrom the beginning.",
                        img = "/img/aspnetcoreaz.jpg",
                        price = 1400,
                        isFavorite = false,
                        avalible = true,
                        Category = _categoryBook.AllCategories.First()
                    },
                    new Book
                    {
                        name = "C# 8.0 and .NET Core 3.0",
                        shortDesc = "Mark J. Price",
                        longDesc = "Build applications with C#, .NET Core, EntityFramework Core, ASP.NET Core, using Visual Studio Code",
                        img = "/img/C8.0and.NETCore3.0.jpg",
                        price = 1800,
                        isFavorite = true,
                        avalible = true,
                        Category = _categoryBook.AllCategories.First()
                    },
                    new Book
                    {
                        name = "Front‐end Development with ASP.NET Core, Angular, and Bootstrap",
                        shortDesc = "Simone Chiaretta",
                        longDesc = "There was a time when “backend” and “front‐end” developers were doing pretty different work.",
                        img = "/img/Front‐endDevelopment.jpg",
                        price = 1500,
                        isFavorite = true,
                        avalible = true,
                        Category = _categoryBook.AllCategories.Last()
                    }
                };
            }
        

        }
        public IEnumerable<Book> getFavBooks { get; set; }

        public Book getObjectBook(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}
