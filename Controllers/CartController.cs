using Microsoft.AspNetCore.Mvc;
using WebApp2.Models;

namespace WebApp2.Controllers
{

    public class CartController : Controller
    {
        public IActionResult Index()
        {
            var cart = Cart.GetCart();
            return View(cart);
        }

        [HttpPost]
        public IActionResult AddToCart(int productId)
        {
            var product = ProductsRepository.GetProductById(productId);
            if (product != null)
            {
                Cart.AddToCart(product);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult RemoveFromCart(int productId)
        {
            Cart.RemoveFromCart(productId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateCart(int productId, int quantity)
        {
            Cart.UpdateCart(productId, quantity);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Checkout()
        {
            var cart = Cart.GetCart();
            return View(cart);
        }

        [HttpPost]
        public IActionResult CompleteOrder(string name, string address)
        {
            Cart.ClearCart();
            return RedirectToAction("Index", "Home");
        }
    }
}
