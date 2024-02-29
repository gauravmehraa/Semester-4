using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prac2DemoAccess
{
    public class Vehicle
    {
        protected internal int chassisnumber = 456;
        public int wheels = 4;
        internal int speed = 60;
        private int enginenumber = 123;
        protected int seats = 5;
    }
    class Car : Vehicle
    {
        public void display()
        {
            Console.WriteLine("Protected Internal (Chassis No.): " + chassisnumber);
            Console.WriteLine("Public (Wheels): " + wheels);
            Console.WriteLine("Internal (Speed): " + speed);
            //Console.WriteLine("Private (Engine No.): " + chassisnumber);
            Console.WriteLine("Protected (Seats): " + seats);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Car();
            c.display();
            Console.ReadKey();
        }
    }
}