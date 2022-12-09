using System;

namespace NumToWord
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
            
            // Agar 100 bood, benevis: Saado
            if (a == 1)
                Console.Write("Saado ");
            
            // Agar 200 bood, benevis: Divisto                                           
            if (a == 2)
                Console.Write("Divisto ");
            
            // Agar 300 bood, benevis: Sisado
            if (a == 3)
                Console.Write("Sisado ");
            
            // Agar 400 bood, benevis: Chaharsado
            if (a == 4)
                Console.Write("Chaharsado ");
            
            // Agar 500 bood, benevis: Poonsado
            if (a == 5)
                Console.Write("Poonsado "); 

            // Agar 600 bood, benevis: Shishsado
            if (a == 6)
                Console.Write("Shishsado ");

            // Agar 700 bood, benevis: Haftsado
            if (a == 7)
                Console.Write("Haftsado ");

            // Agar 800 bood, benevis: Hashtsado
            if (a == 8)
                Console.Write("Hashtsado ");

            // Agar 900 bood, benevis: Nohsado
            if (a == 9)
                Console.Write("Nohsado ");
                
                // Agar saadgan 0 bood, chizi naneviseh
            if (c == 0)
            {
                // Agar 10 bood, benevis: Daho
                if (b == 1)
                    Console.Write("Daho ");
            }

            // Agar 20 bood, benevis: Bisto
            if (b == 2)
                Console.Write("Bisto ");

            // Agar 30 bood, benevis: Siyo
            if (b == 3)
                Console.Write("Siyo ");

            // Agar 40 bood, benevis: Chehelo
            if (b == 4)
                Console.Write("Chehelo ");

            // Agar 50 bood, benevis: Panjaho
            if (b == 5)
                Console.Write("Panjaho ");

            // Agar 60 bood, benevis: Shasto
            if (b == 6)
                Console.Write("Shasto ");

            // Agar 70 bood, benevis: Haftado
            if (b == 7)
                Console.Write("Haftado ");

            // Agar 80 bood, benevis: Hashtado
            if (b == 8)
                Console.Write("Hashtado ");

            //Agar 90 bood, benevis: Navado
            if (b == 9)
                Console.Write("Navado ");
            
            // Agar dahgan ba 1 tamoom mishe vali 0 dar akhar nadasht, ba tavajoh be adad
            // Yeki az in adad ha ra bardare
            // Az moteghayere "C" estefade mikonim chon inha be yekan bastegi darad.
            if (b == 1)
            {
                // Agar 11 bood, benevis: Yazdah
                if (c == 1)
                    Console.Write("Yazdah ");

                // Agar 12 bood, benevis: Davazdah
                if (c == 2)
                    Console.Write("Davazdah ");

                // Agar 13 bood, benevis: Sizdah
                if (c == 3)
                    Console.Write("Sizdah ");

                // Agar 14 bood, benevis: Chahardah
                if (c == 4)
                    Console.Write("Chahardah ");

                // Agar 15 bood, benevis: Poonzdah
                if (c == 5)
                    Console.Write("Poonzdah ");

                // Agar 16 bood, benevis: Shoonzdah
                if (c == 6)
                    Console.Write("Shoonzdah ");

                // Agar 17 bood, benevis: Hifdah
                if (c == 7)
                    Console.Write("Hifdah ");

                // Agar 18 bood, benevis: Hizhdah
                if (c == 8)
                    Console.Write("Hizhdah ");

                // Agar 19 bood, benevis: Noozdah
                if (c == 9)
                    Console.Write("Noozdah ");
            }
            // Vali agar dahgan kolan 0 bood
            // Boro be samte yekan ha ke baz misheh moteghayere "C"
            else
            {
                // Agar 1 bood, benevis: Yek
                if (c == 1)
                    Console.Write("Yek ");
                
                // Agar 2 bood, benevis: Do
                if (c == 2)
                    Console.Write("Do ");

                // Agar 3 bood, benevis: Se
                if (c == 3)
                    Console.Write("Se ");

                // Agar 4 bood, benevis: Chahar
                if (c == 4)
                    Console.Write("Chahar ");

                // Agar 5 bood, benevis: Panj
                if (c == 5)
                    Console.Write("Panj ");

                // Agar 6 bood, benevis: Shish
                if (c == 6)
                    Console.Write("Shish ");
                
                // Agar 7 bood, benevis: Haft
                if (c == 7)
                    Console.Write("Haft ");

                // Agar 8 bood, benevis: Hasht
                if (c == 8)
                    Console.Write("Hasht ");

                // Agar 9 bood, benevis: Noh
                if (c == 9)
                    Console.Write("Noh ");
            }

            // Dar inja baraye inke payane barname e'lam beshe
            // Neveshtam "Payane Barnameh"
            // Dastoorate Console.WriteLine(""); ezafi baraye in ast ke payane barnameh dar khat haye baadi benevisad
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Payane barnameh.");

            // Payane barnameh
            Console.ReadKey();
        }
    }
}
