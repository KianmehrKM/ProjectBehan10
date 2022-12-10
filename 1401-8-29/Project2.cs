using System;

namespace Proj2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;

            Console.Write("Adad ra vared konid: ");
            a = float.Parse(Console.ReadLine());

            if (a < 0)
                Console.WriteLine("manfi");
            else if ((a >= 0) && (a <= 9))
                Console.WriteLine("1 raghami");
            else if ((a > 9) && (a <= 99))
                Console.WriteLine("2 raghami");
            else if ((a > 99) && (a <= 999))
                Console.WriteLine("3 raghami");
            else if (a > 1000)
                Console.WriteLine("bish az 3 ragham");

            Console.ReadKey();
        }
    }
}
