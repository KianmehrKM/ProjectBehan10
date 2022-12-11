using System;

namespace Proj1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dar inja 3 moteghayer dar nazar gerefte mishavad
            float a, b, max;
            // A = Adade aval
            // B = Adade dovom
            // MAX = Adadi ke be onvane adade bozorg dar nazar gerefte mishe dar MAX gozashte mishe

            // Dar inja payami chap mishe ke adade aval ra az karbar mikhad
            // Va adade gerefte shode ra dar moteghayere "A" migozarad
            Console.Write("Num 1: ");
            a = float.Parse(Console.ReadLine());

            // Dar inja payami chap mishe ke adade dovom ra az karbar mikhad
            // Va adade gerefte shode ra dar moteghayere "B" migozarad
            Console.Write("Num 2: ");
            b = float.Parse(Console.ReadLine());

            // Agar "A" az "B" bozorg tar bood
            // "A" ra be onvane "MAX" dar nazar begire
            // Va "MAX" ra chap kone
            if (a > b)
            {
                max = a;
                Console.WriteLine("Max: " + max);
            }
            
            // Agar "B" az "A" bozorg tar bood
            // "B" ra be onvane "MAX" dar nazar begire
            // Va "MAX" ra chap kone
            if (b > a)
            {
                max = b;
                Console.WriteLine("Max: " + max);
            }
            
            // Agar "A" mosaviye ba "B"
            // Chap kone ke in se adad mosavi hastand
            if (a == b)
                Console.WriteLine("Har se adad mosaviyand");

            // Payane barnameh
            Console.ReadKey();
        }
    }
}
