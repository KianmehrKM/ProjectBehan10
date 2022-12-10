using System;

namespace Proj2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, min;

            Console.Write("Adade yek: ");
            a = float.Parse(Console.ReadLine());

            Console.Write("Adade do: ");
            b = float.Parse(Console.ReadLine());

            Console.Write("Adade se: ");
            c = float.Parse(Console.ReadLine());

            if((a<b) && (a<c))
            {
                min = a;
                Console.WriteLine("maximum: " + min);
            }
            if((b<a) && (b<c))
            {
                min = b;
                Console.WriteLine("Maximum: " + min);
            }
            if((c<a) && (c<b))
            {
                min = c;
                Console.WriteLine("maximum: " + min);
            }
            if ((a == b) && (b == c))
                Console.WriteLine("se adad mosaviand");

            Console.ReadKey();
        }
    }
}
