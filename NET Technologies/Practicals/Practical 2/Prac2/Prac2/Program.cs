using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oop
{
    class Student
    {
        public string name;
        public int rollno, marks1, marks2, marks3;
        public float average;

        public Student()
        {
            name = "Gaurav";
            rollno = 42;
            marks1 = 98;
            marks2 = 97;
            marks3 = 99;
        }

        public Student(string name, int rollno, int marks1, int
marks2, int marks3)
        {
            this.name = name;
            this.rollno = rollno;
            this.marks1 = marks1;
            this.marks2 = marks2;
            this.marks3 = marks3;
        }

        public void getAverage()
        {
            average = (marks1 + marks2 + marks3) / 3;
        }

        public void getAverage(int internalmarks)
        {
            average = ((marks1 + marks2 + marks3) / 3) + internalmarks;
        }

        public void display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Roll No.: " + rollno);
            Console.WriteLine("Average Marks: " + average);
            Console.WriteLine();
        }

    }
    class SYBSC : Student
    {
        public string stream;
        public SYBSC(string name, int rollno, int marks1, int marks2,
int marks3, string stream) : base(name, rollno, marks1, marks2, marks3)
        {
            this.stream = stream;
        }
        public virtual void display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Stream: " + stream);
            Console.WriteLine("Roll No.: " + rollno);
            Console.WriteLine("Average Marks: " + average);
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            string n = Console.ReadLine();
            Console.Write("Enter roll no.: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks for all subjects: ");
            int m1 = Convert.ToInt32(Console.ReadLine());
            int m2 = Convert.ToInt32(Console.ReadLine());
            int m3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter internal marks: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Student s1 = new Student();
            s1.getAverage();
            Console.WriteLine("Student 1");
            s1.display();

            Student s2 = new Student(n, r, m1, m2, m3);
            if (i == 0) s2.getAverage();
            else s2.getAverage(i);
            Console.WriteLine("Student 2");
            s2.display();

            SYBSC s3 = new SYBSC(n, r, m1, m2, m3, "CS");
            if (i == 0) s3.getAverage();
            else s3.getAverage(i);
            Console.WriteLine("SYBSC Student 3");
            s3.display();

            Console.ReadKey();
        }
    }
}
