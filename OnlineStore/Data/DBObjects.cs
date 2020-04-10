using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using OnlineStore.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace OnlineStore.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Book.Any())
                content.AddRange(
                    new Book
                    {
                        name = "CLR via C#",
                        shortDesc = "Jeffrey Richter",
                        longDesc = "CLR via C# by Jeffrey Richter",
                        img = "/img/CLRviaC.jpg",
                        price = 1500,
                        isFavorite = true,
                        avalible = true,
                        Category = Categories["NET"]
                    },
                    new Book
                    {
                        name = "Pro C# 7",
                        shortDesc = "Andrew Troelsen, Philip Japikse",
                        longDesc = "Pro C# 7: With .NET and .NET Core 8th Edition, Kindle Edition",
                        img = "/img/ProC7.jpg",
                        price = 800,
                        isFavorite = true,
                        avalible = true,
                        Category = Categories["NET"]
                    },
                    new Book
                    {
                        name = "Object Design Style Guide",
                        shortDesc = "Matthias Noback",
                        longDesc = "Object Design Style Guide 1st Edition by Matthias Noback",
                        img = "/img/ObjectDesign.jpg",
                        price = 200,
                        isFavorite = false,
                        avalible = true,
                        Category = Categories["Another"]
                    });

            content.SaveChanges();

        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                     new Category{ categoryName = "NET", desc = "Books about .NET"},
                     new Category{ categoryName = "Another", desc = "Another programing books" },
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }
             return category;
            }
        }
    }
}
