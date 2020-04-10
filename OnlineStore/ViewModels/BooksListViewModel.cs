using OnlineStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.ViewModels
{
    public class BooksListViewModel
    {
        public IEnumerable<Book> getAllBooks { get; set; }
        public string bookCategory {get; set;}
    }
}
