using OnlineStore.Data.Interfaces;
using OnlineStore.Data.Models;
using System;

namespace OnlineStore.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly StoreCart storeCart;

        public OrdersRepository(AppDBContent appDBContent, StoreCart storeCart)
        {
            this.appDBContent = appDBContent;
            this.storeCart = storeCart;
        }

        public void createOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            appDBContent.Order.Add(order);

            var items = storeCart.listStoreItems;

            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    bookId = el.book.id,
                    orderID = order.id,
                    price = el.book.price
                };
                appDBContent.OrderDetail.Add(orderDetail);
            }
            appDBContent.SaveChanges();
        }
    }
}
