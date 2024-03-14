using System;

namespace Practical_2_Demo
{
    class Student
    {
        public int rollno;
        public string name;
        public Student(int r, string n)
        {
            rollno = r;
            name = n;
        }
        public void printStudent()
        {
            Console.WriteLine(this.GetType().Namespace + "." + this.GetType().Name);
            Console.WriteLine("Roll No: " + rollno);
            Console.WriteLine("Name: " + name);
        }
    }
    class SY : Student
    {
        public char division;
        public SY(int r, string n, char d) : base(r, n)
        {
            division = d;
        }

        new public void printStudent()
        {
            Console.WriteLine(this.GetType().Namespace + "." + this.GetType().Name);
            Console.WriteLine("Roll No: " + rollno);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Division: " + division);
        }
    }

    class Program
    {
        static void Demo1()
        {
            Student s = new Student(12, "abc");
            SY sy = new SY(13, "SYStudent", 'D');
            Console.WriteLine("Type Casting - 1\n");
            Student s1 = new Student(555, "newbase1");
            Console.WriteLine("Before casting");
            s1.printStudent();

            Console.WriteLine("After casting");
            s1 = sy;
            s1.printStudent();
            Console.ReadKey();
        }
        static void Demo2()
        {
            Console.WriteLine("Type Casting - 2\n");
            SY s3 = new SY(23, "newderived", 'D');
            Student s4 = new Student(54, "newbase");
            Console.WriteLine("Before casting");
            s4.printStudent();

            s4 = (Student)s3;
            Console.WriteLine("After casting");
            s4.printStudent();
            Console.ReadKey();
        }
        static void Demo3()
        {
            Student s = new Student(12, "abc");
            Console.WriteLine("Type Casting - 3\n");
            SY sy2 = new SY(555, "newderived1", 'D');
            Console.WriteLine("Before casting");
            sy2.printStudent();
            Console.WriteLine("After casting");
            //sy2 = s; Cannot complicitly convert Student to SY
            sy2.printStudent();
            Console.ReadKey();
        }
        static void Demo4()
        {
            Console.WriteLine("Type Casting - 4");
            Student s = new Student(12, "abc");
            SY sy2 = new SY(555, "newderived1", 'D');
            Console.WriteLine("Before casting");
            sy2.printStudent();
            Console.WriteLine("After casting");
            //sy2 = (SY)s; Invalid cast exception
            sy2.printStudent();
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Demo1();
            Console.WriteLine();
            Demo2();
            Console.WriteLine();
            Demo3();
            Console.WriteLine();
            Demo4();
            Console.WriteLine();
        }
    }
}