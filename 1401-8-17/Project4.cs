using System;

namespace Proj4
{
    class Program
    {
        static void Main(string[] args)
        {
        // "A" va "N" ra be onvane moteghayer dar nazar begir
            int a, n;
            
            // Az karbar adadi ra migire va dar "N" mizare
            Console.Write("Adad vared kon: ");
            n = int.Parse(Console.ReadLine());
            
            
            a = n % 5;

            if (a == 0)
                Console.WriteLine("Mazrabe 5 hast.");
            if (a != 0)
                Console.WriteLine("Mazrabe 5 nist.");

            Console.ReadKey();
        }
    }
}
