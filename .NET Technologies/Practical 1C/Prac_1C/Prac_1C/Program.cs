using System;

namespace Practial1C
{
    class Program
    {
        static void Q1()
        {
            Console.Write("Enter a string: ");
            string inp = Console.ReadLine();
            int counter = 0;

            for (int i = 0; i < inp.Length; i++)
            {
                if (Char.IsWhiteSpace(inp[i])) counter+=1;
            }
            Console.WriteLine("White spaces in string: "+counter);
        }

        static void Q2()
        {
            Console.Write("Enter array elements: ");
            string inp = Console.ReadLine();

            int[] arr;
            int sum = 0;
            arr = Array.ConvertAll(inp.Split(' '), int.Parse);

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine("Sum of array is: " + sum);
        }

        static void Q3()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool deb = true;
            for (int i = 2; i < Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    deb = false; break;
                }
            }
            Console.WriteLine("Is the number prime: " + deb);
        }

        static void Q4()
        {
            Console.Write("Enter a number:");
            string numString = Console.ReadLine();
            double sum = 0;
            for (int i = 0; i < numString.Length; i++)
            {
                if (!Char.IsDigit(numString[i]))
                {
                    Console.WriteLine("Please enter a valid number");
                    return;
                }
                sum += Char.GetNumericValue(numString[i]);
            }
            Console.WriteLine("Sum of digits is: " + sum);
        }

        static int Fib(int pos)
        {
            return pos <= 1? 1 : Fib(pos - 2) + Fib(pos - 1);
        }

        static void Q5()
        {
            Console.Write("Enter value for N: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= num; i++)
            {
                Console.Write(" "+Fib(i));
            }
        }

        static void Main()
        {
            Q1();
            Console.WriteLine();
            Q2();
            Console.WriteLine();
            Q3();
            Console.WriteLine();
            Q4();
            Console.WriteLine();
            Q5();
            Console.WriteLine();
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
