using System;


namespace Metod_Uygulama
{
    class Car
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public int CareYear { get; set; }

        public int CalculateYear(params int[] year)
        {
            int toplam = 0;


            return toplam;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arabanızın Adını Yazınızı");
            string name = Console.ReadLine();




            Console.ReadKey();
        }
    }
}
