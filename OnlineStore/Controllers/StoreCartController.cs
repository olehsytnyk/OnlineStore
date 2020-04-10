using OnlineStore.Data.Models;
using OnlineStore.ViewModels;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Controller = Microsoft.AspNetCore.Mvc.Controller;
using ViewResult = Microsoft.AspNetCore.Mvc.ViewResult;
using OnlineStore.Data.Interfaces;

namespace OnlineStore.Controllers
{
    public class StoreCartController : Controller
    {
        private readonly IAllBooks _bookRepository;
        private readonly StoreCart _storeCart;

        public StoreCartController(IAllBooks bookRepository, StoreCart storeCart)
        {
            _bookRepository = bookRepository;
            _storeCart = storeCart;
        }

        public ViewResult Index()
        {
            var items = _storeCart.getStoreItems(); ;
            _storeCart.listStoreItems = items;

            var obj = new StoreCartViewModel
            {
                storeCart = _storeCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _bookRepository.Books.FirstOrDefault(i => i.id == id);
            if (item != null)
                _storeCart.AddToStore(item);

            return RedirectToAction("Index");
        }
    }
}
