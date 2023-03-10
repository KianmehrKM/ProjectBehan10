using System;

namespace RGBProj1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Moteghayer ma inja be esme "COLOR" moarefi shode
            // Ke az jense "char" hastesh
            // "char" dar inja yani ye character migire
            char color;

            // Peygham mide, mige ke ye harf vared kon
            // Harfi ke vared shode ro mikoone, ke az jense "char" hastesh
            // Baad mizare tooye "COLOR"
            Console.WriteLine("Enter a letter (R/G/B): ");
            color = char.Parse(Console.ReadLine());

            // Hala migim agar R koochik ya bozorg bood
            // Rang text ro ghermez kone va bad bege ke ghermez hastesh
            if ((color == 'R')||(color=='r'))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("It's Red!");
            }

            // Vali agar G koochik ya bozorg bood
            // Rang text ro sabz kone va bad bege ke sabz hastesh 
            else if ((color == 'G')||(color=='g'))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("It's Green!");
            }

            // Vali agar B koochik ya bozorg bood
            // Rang text ro aabi kone va bad bege ke aabi hastesh
            else if ((color=='B')||(color=='b'))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("It's Blue!");
            }

            // Dar soorati ke R, G ya B bood
            // Benevise ke jozve 3 rang asli nistesh va hamin ro chap bokone
            // Pas hich kari nemikone va in 2 ta payam ro chap mikone
            else
            {
                Console.WriteLine("The entered letter does not require nor match with R, G, or B.");
                Console.WriteLine("No color would be displayed.");
            }

            // Payane barnameh
            // KIANMEHR KIMIAVI
            Console.ReadKey();
        }
    }
}
