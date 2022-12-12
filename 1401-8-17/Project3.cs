using System;

namespace Proj3
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, min;

            Console.Write("Num 1: ");
            a = float.Parse(Console.ReadLine());

            Console.Write("Num 2: ");
            b = float.Parse(Console.ReadLine());

            Console.Write("Num 3: ");
            c = float.Parse(Console.ReadLine());

            if (a < b && a < c)
            {
                min = a;
                Console.WriteLine("Min: " + min);
            }
            else if (b < c)
            {
                min = b;
                Console.WriteLine("Min: " + min);
            }
            else
            { 
                min = c;
                Console.WriteLine("Min: " + min);
            }
            Console.ReadKey();
        }
    }
}
