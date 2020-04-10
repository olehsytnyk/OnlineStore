using Microsoft.AspNetCore.Mvc;
using OnlineStore.Data.Interfaces;
using OnlineStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly StoreCart storeCart;

        public OrderController(IAllOrders allOrders, StoreCart storeCart)
        {
            this.allOrders = allOrders;
            this.storeCart = storeCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            storeCart.listStoreItems = storeCart.getStoreItems();

            if (storeCart.listStoreItems.Count == 0)
            {
                ModelState.AddModelError("", "For registration of the order it is necessary to add in a basket the goods, having pressed on the corresponding button Add to cart");
            }

            if (ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Order in process";
            return View();
        }
    }
}
