using System;
namespace @interface
{

    interface IPersonel
    {
        string adSoyad { get; set; }
        string adres { get; set; }
        string departman { get; set; }
        void bilgi();
    }

    class Yonetici : IPersonel
    {
        public Yonetici(string _adsoyad , string adres, string departman)
        {
            this.adSoyad = _adsoyad;
            this.adres = adres;
            this.departman = departman;
        }
        public string adSoyad { get; set; }
        public string adres { get; set; }
        public string departman { get; set ; }

        public void bilgi()
        {
            Console.WriteLine($"{this.adSoyad} İsimli personel {this.departman} bölümünde yöneticidir");
        }
    }

    
    class Isci :IPersonel
    {
        public Isci(string _adsoyad, string adres, string departman)
        {
            this.adSoyad = _adsoyad;
            this.adres = adres;
            this.departman = departman;
        }

        public string adSoyad { get; set; }
        public string adres { get; set; }
        public string departman { get; set; }

        public void bilgi()
        {
            Console.WriteLine($"{this.adSoyad} İsimli personel {this.departman} bölümünde İşçidir");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            //IPersonel y = new Yonetici();
            //IPersonel i = new Isci();

            var personeller = new IPersonel[3];

            personeller[0] = new Yonetici("ali","istanbul","finans");
            personeller[1] = new Isci("ahmet","kocaeli","üretim");
            personeller[2] = new Yonetici("defne","istanbul","muhasebe");

            foreach (var personel in personeller)
            {
                personel.bilgi();
            }



            Console.ReadKey();
        }
    }
}
