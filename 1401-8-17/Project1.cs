using System;

namespace Proj1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, max;

            Console.Write("Num 1: ");
            a = float.Parse(Console.ReadLine());

            Console.Write("Num 2: ");
            b = float.Parse(Console.ReadLine());

            if (a > b)
            {
                max = a;
                Console.WriteLine("Max: " + max);
            }
            if (b > a)
            {
                max = b;
                Console.WriteLine("Max: " + max);
            }
            if (a == b)
                Console.WriteLine("All digits are equal!");

            Console.ReadKey();

            // End of program
        }
    }
}
