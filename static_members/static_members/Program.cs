using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_members
{
    //static class HelperMethods
    //{
    //    public static string KarakterDuzelt(string str)
    //    {
    //        return str.Replace("ö","o")
    //         .Replace("ü", "u")
    //         .Replace("ç", "c")
    //         .Replace(" ", "-")
    //         .Replace("ğ", "g");


    //    }
    //}

    class Product
    {

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public bool IsApproved { get; set; }
    }

    static class ProductManager
    {
        static Product[] Products;

        static ProductManager()
        {
            Products = new Product[5];

            Products[0] = new Product { ProductId = 1, ProductName = "iphone 5", Price = 5000, IsApproved = false };
            Products[1] = new Product { ProductId = 2, ProductName = "iphone 6", Price = 6000, IsApproved = false };
            Products[2] = new Product { ProductId = 3, ProductName = "iphone 7", Price = 7000, IsApproved = true };
            Products[3] = new Product { ProductId = 4, ProductName = "iphone 8", Price = 8000, IsApproved = true };
            Products[4] = new Product { ProductId = 5, ProductName = "iphone x", Price = 9000, IsApproved = false };
        }

        public static Product[] GetProducts()
        {
            return Products;
        }

        public static Product GetProductById(int id)
        {
            Product product = null;

            foreach (var p in Products)
            {
                if (p.ProductId == id)
                {
                    product = p;
                    break;
                }
            }


            return product;
        }
        public static Product GetProductByName(string name)
        {
            Product product = null;

            foreach (var p in Products)
            {
                if (p.ProductName.Contains(name.ToLower()))
                {
                    product = p;
                    break;
                }
            }

            return product;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {


            //var product = ProductManager.GetProductById(2);
            //Console.WriteLine($"name: {product.ProductName} price {product.Price}");


            //var products = ProductManager.GetProducts();

            //foreach (var p in products)
            //{
            //Console.WriteLine($"name: {p.ProductName} price {p.Price}");
            //}


            var product = ProductManager.GetProductByName("Phone");
            Console.WriteLine($"name: {product.ProductName} price {product.Price}");

























            //string str = "ölçme ve değerlendirme";
            //var result = HelperMethods.KarakterDuzelt(str);
            //Console.WriteLine(result);




            Console.ReadLine();
        }
    }
}
