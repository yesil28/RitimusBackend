using System;


namespace Metod_Uygulama
{
    //class Car
    //{
    //    public string Name { get; set; }
    //    public int Year { get; set; }
    //    public string Model { get; set; }
    //    public int CareYear { get; set; }

    //    public int CalculateYear(params int[] year)
    //    {
    //        int toplam = 0;


    //        return toplam;
    //    }
    //}

    class Comment
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
    }


    class Product
    {
        public Product()
        {
            this.ProductId = (new Random()).Next(11111, 99999);
            this.Comments = new Comment[3];
        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public Product(int productId, string name, double price, bool isApproved)
        {
            this.ProductId = productId;
            this.Name = name;
            this.Price = price;
            this.IsApproved = isApproved;
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsApproved { get; set; }
        public Comment[] Comments { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var a = new Product();

            var c1 = new Comment { CommentId = 1, Text = "Güzel Telefon" };

            var p1 = new Product();
            Console.WriteLine(p1.Comments);

            p1.Comments = new Comment[3];
            
             
            Console.ReadKey();
        }
    }
}

