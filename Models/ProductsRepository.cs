using System.Collections.Generic;
using System.Linq;

namespace WebApp2.Models
{
    public static class ProductsRepository
    {
        private static List<Product> _products = new List<Product>()
        {
            new Product { ProductId = 1, Name = "Jewellery", Description = "Handcrafted Jewellery", Price = 50  },
            new Product { ProductId = 2, Name= "Clothing", Description= "Locally-produced Clothing", Price = 60 },
            new Product { ProductId = 3, Name = "Art & Craft", Description= "Fine Art Pieces", Price = 40},
            new Product { ProductId = 4, Name = "Stationary", Description= "To add to your desk wherever it may be", Price = 55},
            new Product { ProductId = 5, Name = "Homeware", Description= "Everything you need to make staying in easy, comfy and a whole vibe.", Price = 35},
            new Product { ProductId = 6, Name = "Gifts", Description= "Gifts for that special one", Price = 50}
        };

        public static void AddProduct(Product product)
        {
            var maxId = _products.Max(x => x.ProductId);
            product.ProductId = maxId + 1;
            _products.Add(product);
        }

        public static List<Product> GetProducts() => _products;

        public static Product? GetProductById(int productId)
        {
            return _products.FirstOrDefault(x => x.ProductId == productId);
        }

        public static void UpdateProduct(int productId, Product product)
        {
            var productToUpdate = GetProductById(productId);
            if (productToUpdate != null)
            {
                productToUpdate.Name = product.Name;
                productToUpdate.Description = product.Description;
            }
        }

        public static void DeleteProduct(int productId)
        {
            var product = _products.FirstOrDefault(x => x.ProductId == productId);
            if (product != null)
            {
                _products.Remove(product);
            }
        }
    }
}
