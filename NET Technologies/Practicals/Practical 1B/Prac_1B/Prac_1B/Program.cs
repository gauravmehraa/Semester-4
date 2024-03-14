using System;

namespace Practial1B
{
    class Program
    {
        static double fact(double n)
        {
            return n == 1 ? 1 : n * fact(n - 1);
        }

        static int getX(int x, int n)
        {
            int num = x;
            int i = 0;

            while(i<n){
                num = num * 10;
                num += x;
                i++;
            }

            return num;
        }

        static void Q1()
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        static void Q2()
        {
            int n = 1; 
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(n);
                    n += 1;
                }
                Console.WriteLine();
            }
        }

        static void Q3()
        {
            Console.Write("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter width: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int k = 0; k <= (n - i); k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(a);
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
            }
        }

        static void Q4()
        {
            Console.Write("Enter value of x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 1;
            int sign = -1;
            for (int i = 1; i <= n; i++)
            {
                double pow = Math.Pow(2,i);
                sum += sign*(Math.Pow(x,pow)/fact(pow));
            }
            Console.WriteLine("Sum of series: "+sum);
        }

        static void Q5()
        {
            Console.Write("Enter value of x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += getX(x, i - 1);
            }
            Console.WriteLine("Sum of series: " + sum);
        }
        static void Main(string[] args)
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
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
