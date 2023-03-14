using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Metodlar
{

    class Person
    {
        public string Name { get; set; }

        public int Year { get; set; }

        public string Intro() 
        {
            return $"name : {this.Name} age : {this.CalculateAge()}";
        }

        public int CalculateAge()
        {
            return DateTime.Now.Year - this.Year;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person{ Name ="Ada",Year =2321};
            var p2 = new Person{ Name = "yiğit",Year=1232};
            var p3 = new Person{ Name = "sena",Year=123};

            //var str1 = p1.Intro();
            //var str2 = p2.Intro();
            //var str3 = p3.Intro();

            Console.WriteLine(p1.Intro());
            Console.WriteLine(p2.Intro());
            Console.WriteLine(p3.Intro());



            Console.ReadKey();
        }
    }
}
