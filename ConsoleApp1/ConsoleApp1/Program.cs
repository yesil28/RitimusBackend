using System;

namespace ConsoleApp1
{

    class Ogrenci
    {
        public int OgrNo { get; set; }
        public string Ad { get; set; }
        public string Sube { get; set; }

    }



    class Program
    {
        static void Main(string[] args)
        {
            //CLASS

            Ogrenci ogr1 = new Ogrenci();
            ogr1.OgrNo = 100;
            ogr1.Ad = "Samet";
            ogr1.Sube = "10A";
            

            Console.WriteLine($"no: {ogr1.OgrNo} {ogr1.Ad} {ogr1.Sube}");


            Ogrenci ogr2 = new Ogrenci()
            {
                OgrNo = 200,
                Ad = "Ada",
                Sube = "10a"
            };

            Console.WriteLine($"no: {ogr2.OgrNo} {ogr2.Ad} {ogr2.Sube}");



            Ogrenci ogr3 = new Ogrenci()
            {
                OgrNo = 300,
                Ad = "Yiğit",
                Sube = "11a"
            };


            Console.WriteLine($"no: {ogr3.OgrNo} {ogr3.Ad} {ogr3.Sube}");

            Console.WriteLine("*******************");


            Ogrenci[] ogrenciler = new Ogrenci[3];

            ogrenciler[0] = ogr1;
            ogrenciler[1] = ogr2;
            ogrenciler[2] = ogr3;


            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine($"no: {ogrenciler[i].OgrNo} {ogrenciler[i].Ad} {ogrenciler[i].Sube}");

            }








            //          String Metodları
            //string msg = "Hello There.My name is Samet Yesil";
            //Console.WriteLine(msg.Length);
            //Console.WriteLine(msg.ToLower());
            //Console.WriteLine(msg.ToUpper());
            //Console.WriteLine(msg.Trim());//baştan ve sondan boşlukları siler
            //Console.WriteLine(msg.StartsWith("H"));//ifade h ile mi başlıyor True
            //Console.WriteLine(msg.Split()[0]); // diziye döndürür ve her bi boşlukta dizinin bi elemanı olur
            //Console.WriteLine(msg.EndsWith("H"));//ifade h ile mi bitiyo false    
            //Console.WriteLine(msg.Contains("There"));//there ifadede var mı true
            //Console.WriteLine(msg.IndexOf("name"));//name kelimesi kaçıncı indexden sonra
            //Console.WriteLine(msg.Substring(5));//5. indexden itibaren getirir
            //Console.WriteLine(msg.Substring(5, 10));// 5. indexden itibaren 10 karakter getirir
            //Console.WriteLine(msg.Replace(" ", "-").Replace(".", ""));
            //Console.WriteLine(msg.Insert(0, "..."));//en başına ekledi
            //Console.WriteLine(msg.Remove(5));//5. indeksten itibaren sil

            //Console.WriteLine("----------------------------------------");
            ////     Dizi Metodları 

            //string[] isimler = { "ahmet", "çınar", "ada", "yiğit", "sena" };
            //int[] numaralar = { 1, 6, 2, 9, 1, 3, 7 };


            //isimler.SetValue("ali", 0);
            //Console.WriteLine(isimler.GetValue(0));
            //Console.WriteLine(Array.IndexOf(isimler, "çınar"));//çınarın inkesini bulduk
            //Array.Sort(isimler);



            //DATETİME

            //string[] aylar = { "ocak", "subat", "mart", "nisan", "mayıs", "haziran", "temmuz", "ağustos", "eylül", "ekim", "kasım", "aralık" };
            //DateTime simdi = DateTime.Now;

            //Console.WriteLine(simdi);
            //Console.WriteLine(simdi.Year);
            //Console.WriteLine(simdi.Month);
            //Console.WriteLine(aylar[simdi.Month -1]);
            //Console.WriteLine(simdi.Day);
            //Console.WriteLine(simdi.DayOfWeek);

            //Console.WriteLine(simdi.Hour);
            //Console.WriteLine(simdi.Minute);
            //Console.WriteLine(simdi.Second);

            //DateTime dt = new DateTime(2023, 2, 27, 18, 45, 32);

            //DateTime dt1 = dt.AddDays(2);

            //var fark = simdi - dt;

            //Console.WriteLine(fark.TotalDays);


            //Console.WriteLine(simdi);
            //Console.WriteLine(simdi.ToString("d"));//sadece tarih
            //Console.WriteLine(simdi.ToString("D"));// tarihin yanında gün bilgisi
            //Console.WriteLine(simdi.ToString("F"));// saat bilgisi
            //Console.WriteLine(simdi.ToString("M"));//gün ay
            //Console.WriteLine(simdi.ToString("t"));//sadece saat bilgisi
            //Console.WriteLine(simdi.ToString("T"));//saat saniye
            //Console.WriteLine(simdi.ToString("Y"));//ay ve yıl


            //Console.WriteLine(simdi.ToString("hh:mm:ss"));
            //Console.WriteLine(simdi.ToString("ddd MMM %d, yyyy"));


            //CultureInfo culture = new CultureInfo("fr");
            //Console.WriteLine(simdi.ToString("F", culture));


            //int ay = 9;

            //switch (ay)
            //{

            //    case 12:
            //    case 1:
            //    case 2:
            //        Console.WriteLine("kış mevsimi");
            //        break;

            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("ilkbahar");
            //        break;

            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("yaz");
            //        break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("sonbahar");
            //        break;

            //    default:
            //        Console.WriteLine("YANLIŞ");
            //        break;
            //}



            Console.ReadLine();
        }
    }

  
}
