using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
        // Dar inja, range matn va paszamineh taghir mikone.
        // Rang-e paszamineh: Abiye tireh
        // Rang-e matn: Zard
        // In ra mishe taghir dad.
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            
            // Moteghayer ha be soorate "N", "A", "B" va "C" mi bashad
            int n, a, b, c;
            // N = adad ro migireh
            // A = Baraye ghesmate saadgan
            // B = Dahgan
            // C = Yekan

            Console.Write("Adade se raghami vared kon: ");
            n = int.Parse(Console.ReadLine());
            // Dar inja adad az karbar gerefte mishe
            // Va dar "N" gozashte mishe

            c = n % 10;
            // Dar inja, yekan ha joda mishe

            n = n / 10;
            b = n % 10;
            // Dar inja, dahgan ha joda mishe

            n = n / 10;
            a = n % 10;
            // Dar inja, yekan ha joda mishe
                            
            if (a == 1)
                Console.Write("Saado ");

            if (a == 2)
                Console.Write("Divisto ");

            if (a == 3)
                Console.Write("Sisado ");

            if (a == 4)
                Console.Write("Chaharsado ");

            if (a == 5)
                Console.Write("Poonsado ");

            if (a == 6)
                Console.Write("Shishsado ");

            if (a == 7)
                Console.Write("Haftsado ");

            if (a == 8)
                Console.Write("Hashtsado ");

            if (a == 9)
                Console.Write("Nohsado ");
                
                // Agar saadgan 0 bood, chizi naneviseh
            if (c == 0)
            {
                if (b == 1)
                    Console.Write("Daho ");
            }

            if (b == 2)
                Console.Write("Bisto ");

            if (b == 3)
                Console.Write("Siyo ");

            if (b == 4)
                Console.Write("Chehelo ");

            if (b == 5)
                Console.Write("Panjaho ");

            if (b == 6)
                Console.Write("Shasto ");

            if (b == 7)
                Console.Write("Haftado ");

            if (b == 8)
                Console.Write("Hashtado ");

            if (b == 9)
                Console.Write("Navado ");


            if (b == 1)
            {
                if (c == 1)
                    Console.Write("Yazdah ");

                if (c == 2)
                    Console.Write("Davazdah ");

                if (c == 3)
                    Console.Write("Sizdah ");

                if (c == 4)
                    Console.Write("Chahardah ");

                if (c == 5)
                    Console.Write("Poonzdah ");

                if (c == 6)
                    Console.Write("Shoonzdah ");

                if (c == 7)
                    Console.Write("Hifdah ");

                if (c == 8)
                    Console.Write("Hizhdah ");

                if (c == 9)
                    Console.Write("Noozdah ");
            }

            else
            {
                if (c == 1)
                    Console.Write("Yek ");

                if (c == 2)
                    Console.Write("Do ");

                if (c == 3)
                    Console.Write("Se ");

                if (c == 4)
                    Console.Write("Chahar ");

                if (c == 5)
                    Console.Write("Panj ");

                if (c == 6)
                    Console.Write("Shish ");

                if (c == 7)
                    Console.Write("Haft ");

                if (c == 8)
                    Console.Write("Hasht ");

                if (c == 9)
                    Console.Write("Noh ");
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Payane barnameh.");

            Console.ReadKey();
        }
    }
}
