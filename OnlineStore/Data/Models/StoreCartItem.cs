using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Data.Models
{
    public class StoreCartItem
    {
        public int Id { get; set; }
        public Book book { get; set; }
        public int price { get; set; }
        public string StoreCartId { get; set; }
    }
}
