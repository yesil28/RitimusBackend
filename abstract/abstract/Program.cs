using System;

namespace @abstract
{

    //abstract class Person
    //{
    //    public string Name { get; set; }
    //    public string SurName { get; set; }

    //    public Person(string name, string surname)
    //    {
    //        this.Name = name;
    //        this.SurName = surname;
    //        Console.WriteLine("person oluşturuldu");
    //    }


    //    public void Greeting()
    //    {
    //        Console.WriteLine("i am a person");
    //    }

    //    public abstract void Intro();
        
    //}


    //class Student : Person
    //{
    //    public string StudentNumber { get; set; }
    //    public Student(string name, string surname, string studentnumber) : base(name, surname)
    //    {
    //        this.StudentNumber = studentnumber;
    //        Console.WriteLine("student olustu");
    //    }
    //    public override void Intro()
    //    {
    //        Console.WriteLine($"name: {this.Name} surname: {this.SurName} studentnumber: {this.StudentNumber}");
    //    }

    //}


    //class Teacher : Person
    //{
    //    public string Branch { get; set; }

    //    public Teacher(string name, string surname, string branch) : base(name, surname)
    //    {
    //        this.Branch = branch;
    //    }
    //    public void Teach()
    //    {
    //        Console.WriteLine("i am teaching......");
    //    }
    //    public override void Intro()
    //    {
    //        Console.WriteLine($"name: {this.Name} surname: {this.SurName} studentnumber: {this.Branch}");
    //    }
    //}


    abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Shape(int w, int h)
        {
            this.Width = w;
            this.Height = h;
        }


        public int CalculateArea()
        {
            return this.Width * this.Height;
        }


        public abstract void Drow();


       
    }

    class Square: Shape
    {
        public Square(int w,int h):base(w,h)
        {
        }
        public override void Drow()
        {
            Console.WriteLine("draw a square");
        }
    }

    class Rectangle: Shape
    {
        public Rectangle(int w, int h) : base(w, h)
        {
        }
        public override void Drow()
        {
            Console.WriteLine("draw a rectangle");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new Shape[3];

            shapes[0] = new Rectangle(30,25);
            shapes[1] = new Square(10,15);
            shapes[2] = new Rectangle(20,81);


            foreach (var shape in shapes)
            {
                shape.Drow();
                Console.WriteLine(shape.CalculateArea());
            }


            Console.ReadKey();
        }
    }
}
