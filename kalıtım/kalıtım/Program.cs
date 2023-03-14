using System;

namespace kalıtım
{

    class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }

        public Person(string name,string surname)
        {
            this.Name = name;
            this.SurName = surname;
            Console.WriteLine("person oluşturuldu");
        }
        public virtual void Intro()
        {
            Console.WriteLine($"name: {this.Name} surname: {this.SurName}");
        }
    }


    class Student: Person
    {
        public string StudentNumber { get; set; }
        public Student(string name, string surname,string studentnumber): base(name,surname)
        {
            this.StudentNumber = studentnumber;
            Console.WriteLine("student olustu");
        }
        public override void Intro()
        {
            Console.WriteLine($"name: {this.Name} surname: {this.SurName} studentnumber: {this.StudentNumber}");
        }

    }


    class Teacher: Person
    {
        public string Branch { get; set; }

        public Teacher(string name, string surname,string branch): base(name,surname)
        {
            this.Branch = branch;
        }
        public void Teach()
        {
            Console.WriteLine("i am teaching......");
        }
        public override void Intro()
        {
            Console.WriteLine($"name: {this.Name} surname: {this.SurName} studentnumber: {this.Branch}");
        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person("ali","yılmaz");
            var s = new Student("çınar","turan","1233");
            var t = new Teacher("samo", "yesil", "matematik");

            t.Intro();
            t.Teach();


            //p.Intro();
            //s.Intro();






            Console.ReadKey();
        }
    }
}
