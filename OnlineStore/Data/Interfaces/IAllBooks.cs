﻿using OnlineStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Data.Interfaces
{
    public interface IAllBooks
    {
        IEnumerable<Book> Books { get; }
        IEnumerable<Book> getFavBooks { get; }
        Book getObjectBook(int bookId);
    }
}
