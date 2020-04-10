using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orderID { get; set; }
        public int bookId { get; set; }
        public uint price { get; set; }
        public virtual Book book { get; set; }
        public virtual Order order { get; set; }
    }
}
