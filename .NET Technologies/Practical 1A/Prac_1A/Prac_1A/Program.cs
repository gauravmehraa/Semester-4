/*using System;

namespace Practial1A
{
    class Practial1
    {
        static void Q1()
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int largest = Math.Max(num1, Math.Max(num2, num3));
            Console.WriteLine("Largest number = " + largest);
        }

        static void Q2()
        {
            Console.Write("Enter X coordinate: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Y coordinate: ");

            int y = Convert.ToInt32(Console.ReadLine());
            int quadrant;

            if (x > 0 && y > 0) quadrant = 1;
            else if (x < 0 && y > 0) quadrant = 2;
            else if (x < 0 && y < 0) quadrant = 3;
            else if (x == 0 && x == 0) quadrant = 0;
            else quadrant = 4;

            Console.WriteLine("The points lies in quadrant " + quadrant);
        }

        static void Q3()
        {
            Console.Write("Enter marks for maths: ");
            int maths = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks for physics: ");
            int physics = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks for chemistry: ");
            int chemistry = Convert.ToInt32(Console.ReadLine());

            bool eligible = false;
            if (maths > 65 && physics > 55 && chemistry > 50)
            {
                if ((maths + physics + chemistry) > 180) eligible = true;
            }

            Console.WriteLine("Is student eligible? : " + eligible);
        }

        static void Q4()
        {
            Console.Write("Enter value of a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            double Px = (-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
            double Nx = (-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);

            Console.WriteLine("The roots are: " + Px + " and " + Nx);
            Console.WriteLine("If the output is NaN then your D=b2-4ac is < 0");
        }

        static void Q5()
        {
            Console.Write("Enter the value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int counter = 0;

            for (int i = 1; counter < n; i += 2)
            {
                Console.Write(i + " ");
                sum += i;
                counter += 1;
            }
            Console.WriteLine("\nThe sum is: " + sum);
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
}*/
