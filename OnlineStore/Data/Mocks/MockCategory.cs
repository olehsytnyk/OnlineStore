using OnlineStore.Data.Interfaces;
using OnlineStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Data.Mocks
{
    public class MockCategory : IBooksCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                     new Category{ categoryName = ".NET", desc = "Books about .NET"},
                     new Category{ categoryName = "Another", desc = "Another programing books" },
                     new Category{ categoryName = "ASP", desc = "Books about ASP.NET"}
                };
            }
        }
    }
}
