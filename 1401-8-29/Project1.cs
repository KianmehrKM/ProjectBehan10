using System;

namespace Proj1
{
    class Program
    {
        static void Main(string[] args)
        {
        // Dar inja, 4 moteghayer dar nazar gerefte mishavand.
            float a, b, c, max;

            Console.Write("Adade yek: ");
            a = float.Parse(Console.ReadLine());

            Console.Write("Adade do: ");
            b = float.Parse(Console.ReadLine());

            Console.Write("Adade se: ");
            c = float.Parse(Console.ReadLine());

            if((a<b) && (a<c))
            {
                max = a;
                Console.WriteLine("maximum: " + max);
            }
            if((b<a) && (b<c))
            {
                max = b;
                Console.WriteLine("Maximum: " + max);
            }
            if((c<a) && (c<b))
            {
                max = c;
                Console.WriteLine("maximum: " + max);
            }
            if((a == b) && (b == c))
                Console.WriteLine("se adad mosaviand");

            Console.ReadKey();
        }
    }
}
