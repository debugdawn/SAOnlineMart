using System.Collections.Generic;
using System.Linq;

namespace WebApp2.Models
{
    public static class Cart
    {
        private static List<CartItem> _cartItems = new List<CartItem>();

        public static List<CartItem> GetCart() => _cartItems;

        public static void AddToCart(Product product)
        {
            var item = _cartItems.FirstOrDefault(c => c.Product.ProductId == product.ProductId);
            if (item != null)
            {
                item.Quantity++;
            }
            else
            {
                _cartItems.Add(new CartItem { Product = product, Quantity = 1 });
            }
        }

        public static void RemoveFromCart(int productId)
        {
            var item = _cartItems.FirstOrDefault(c => c.Product.ProductId == productId);
            if (item != null)
            {
                _cartItems.Remove(item);
            }
        }

        public static void UpdateCart(int productId, int quantity)
        {
            var item = _cartItems.FirstOrDefault(c => c.Product.ProductId == productId);
            if (item != null)
            {
                if (quantity <= 0)
                {
                    _cartItems.Remove(item);
                }
                else
                {
                    item.Quantity = quantity;
                }
            }
        }

        public static void ClearCart()
        {
            _cartItems.Clear();
        }
    }
}
