using System;

namespace Sample
{
    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            double n, x;
            int counter = 1;
            double sum = 1.0;

            Console.WriteLine("Enter input for n:");
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter input for x:");
            x = Convert.ToDouble(Console.ReadLine());

            for (int i = 2; counter <= n; i += 2)
            {
                Console.Write("{0} ", sum);
                if (counter % 2 != 0)
                {
                    sum += (x * i) / factorial(i);
                }
                else
                {
                    sum -= (x * i) / factorial(i);
                }
                counter++;
            }
            Console.WriteLine("Sum:{0}", sum);
            Console.ReadKey();
        }
        static int factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return (n * (factorial(n - 1)));
        }
    }
}