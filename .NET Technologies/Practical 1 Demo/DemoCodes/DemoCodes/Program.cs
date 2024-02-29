using System;

namespace DemoCode
{
    class Program
    {
        static void MathDemo()
        {
            int num = 16;
            Console.WriteLine("Original number: "+num);
            Console.WriteLine("Square: " + Math.Pow(num, 2));
            Console.WriteLine("Root: " + Math.Sqrt(num));
            Console.WriteLine("Log: " + Math.Log(num));
        }

        static void StringDemo()
        {
            string str = "Hello World";
            Console.WriteLine("Original string: " + str);
            Console.WriteLine("Length: " + str.Length);
            Console.WriteLine("Trimmed: " + str.Trim());
            Console.WriteLine("Upper: " + str.ToUpper());
            Console.WriteLine("Lower: " + str.ToLower());
        }

        static void DateDemo()
        {
            DateTime dt1 = new DateTime(2001);
            DateTime dt2 = new DateTime(2001, 9, 11);
            DateTime dt3 = new DateTime(2001, 9, 11, 8, 46, 0);
            TimeSpan diff = dt3.Subtract(dt2);
            string result;
            int res = DateTime.Compare(dt2, dt3);
            if (res < 0) result = "First date is earlier!";
            else if (res > 0) result = "First date is later!";
            else result = "Both dates are the same!";

            Console.WriteLine("(Arguments Passed)\nOnly year: " + dt1 + "\nYear, Date and Month: " + dt2 + "\nYear, Date, Month, Hour, Minute and Seconds: "+dt3);
            Console.WriteLine("(TimeSpan)\nDifference: " + diff.ToString());
            Console.WriteLine("(Compare)\n" + result);
            Console.WriteLine("(General)\nTime right now: " + DateTime.Now.ToString());
            Console.WriteLine("Is this year a leap year?: " + DateTime.IsLeapYear(DateTime.Now.Year));
            Console.WriteLine("Days in current month: " + DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
        }

        static void Main()
        {
            MathDemo();
            StringDemo();
            DateDemo();
        }
    }
}
