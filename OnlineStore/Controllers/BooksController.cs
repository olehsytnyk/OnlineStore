using Microsoft.AspNetCore.Mvc;
using OnlineStore.Data.Interfaces;
using OnlineStore.Data.Models;
using OnlineStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Controllers
{
    public class BooksController : Controller
    {
        private readonly IAllBooks _allBooks;
        private readonly IBooksCategory _allCategories;

        public BooksController(IAllBooks iAllBooks, IBooksCategory iBooksCategory)
        {
            _allBooks = iAllBooks;
            _allCategories = iBooksCategory;
        }

        [Route("Books/List")]
        [Route("Books/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Book> books = null;
            string currentCategory = "";

            if (string.IsNullOrEmpty(category))
            {
                books = _allBooks.Books.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("NET", category, StringComparison.OrdinalIgnoreCase)){
                    books = _allBooks.Books.Where(i => i.Category.categoryName.Equals(".NET")).OrderBy(i => i.id);
                    currentCategory = _category;
                } else if (string.Equals("ASP", category, StringComparison.OrdinalIgnoreCase)){
                    books = _allBooks.Books.Where(i => i.Category.categoryName.Equals("ASP")).OrderBy(i => i.id);
                    currentCategory = _category;
                } else if (string.Equals("Another", category, StringComparison.OrdinalIgnoreCase)){
                    books = _allBooks.Books.Where(i => i.Category.categoryName.Equals("Another")).OrderBy(i => i.id);
                    currentCategory = _category;
                }
            }

            var bookObj = new BooksListViewModel
            {
                getAllBooks = books,
                bookCategory = currentCategory
            };

            ViewBag.Title = "Page with books";

            return View(bookObj);
        }
    }
}
