using System;

namespace Proj3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dar inja, chahar moteghayer dar nazar gerefte mishavad
            float a, b, c, min;
            // A = Adade aval
            // B = Adade dovom
            // C = Adade sevom
            // MIN = Dar in moteghayer, adade koochik tar dar nazar gerefte mishavad

            // Inja yek payami chap mishe ke adade aval ra vared konim
            // Sepas adade vared shode dar moteghayere "A" gozashte mishe
            Console.Write("Num 1: ");
            a = float.Parse(Console.ReadLine());

            // Inja yek payami chap mishe ke adade dovom ra vared konim
            // Sepas adade vared shode dar moteghayere "B" gozashte mishe
            Console.Write("Num 2: ");
            b = float.Parse(Console.ReadLine());

            // Inja yek payami chap mishe ke adade sevom ra vared konim
            // Sepas adade vared shode dar moteghayere "C" gozashte mishe
            Console.Write("Num 3: ");
            c = float.Parse(Console.ReadLine());

            // Agar "A" az "B" koochik tar bood va hamchenin "A" az "C" koochik tar bood
            // "A" ra be onvane "MIN" dar nazar begir va bad "MIN" ra chap kon
            if (a < b && a < c)
            {
                min = a;
                Console.WriteLine("Min: " + min);
            }
            
            // Vali agar "B" az "C" koochik tar bood
            // "B" ra be onvane "MIN" dar nazar begir va "MIN" ra chap kon
            else if (b < c)
            {
                min = b;
                Console.WriteLine("Min: " + min);
            }
            
            // Agar hichkodam az in ha nabood
            // "C" ra be onvane "MIN" dar nazar begir va "MIN" ra chap kon
            else
            { 
                min = c;
                Console.WriteLine("Min: " + min);
            }
            
            // Payane barnameh
            Console.ReadKey();
        }
    }
}
