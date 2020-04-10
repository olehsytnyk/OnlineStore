using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Data.Models
{
    public class StoreCart
    {
        private readonly AppDBContent appDBContent;

        public StoreCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public string StoreCartId { get; set; }
        public List<StoreCartItem> listStoreItems { get; set; }

        public static StoreCart GetCart(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = service.GetService<AppDBContent>();
            string storeCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", storeCartId);

            return new StoreCart(context) { StoreCartId = storeCartId };
        }

        public void AddToStore(Book book)
        {
            appDBContent.StoreCartItem.Add(new StoreCartItem
            {
                StoreCartId = StoreCartId,
                book = book,
                price = book.price
            });

            appDBContent.SaveChanges();
        }

        public List<StoreCartItem> getStoreItems()
        {
            return appDBContent.StoreCartItem.Where(c => c.StoreCartId == StoreCartId).Include(s => s.book).ToList();
        }
    }
}
