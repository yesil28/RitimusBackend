using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("adet: ");
            int adet = int.Parse(Console.ReadLine());

            Product[] products = new Product[adet];

            int i = 0;
            Product prd;
            do
            {
                prd = new Product();

                Console.Write("ürün adı : ");
                prd.Name = Console.ReadLine();

                Console.Write("ürün fiyat = ");
                prd.Price = double.Parse(Console.ReadLine());

                Console.Write("açıklama = ");
                prd.Description = Console.ReadLine();

                products[i] = prd;
                i++;
            } while (adet > i);

            Console.WriteLine("***************************");

            //for (int a = 0; a < products.Length; a++)
            //{
            //    Console.WriteLine($"ürün adı: {products[a].Name} ürünün fiyatı : {products[a].Price} açıklama: {products[a].Description}");
            //}

            foreach (var urun in products)
            {
             Console.WriteLine($"ürün adı: {urun.Name} ürünün fiyatı : {urun.Price} açıklama: {urun.Description}");

            }
            Console.ReadKey();
        }
    }
}
