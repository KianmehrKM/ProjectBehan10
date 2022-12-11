using System;

namespace Proj1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dar inja 3 moteghayer dar nazar gerefte mishavad
            float a, b, min;
            // A = Adade aval
            // B = Adade dovom
            // MIN = Adadi ke be onvane adade koochek dar nazar gerefte mishe dar MIN gozashte mishe

            // Dar inja payami chap mishe ke adade aval ra az karbar mikhad
            // Va adade gerefte shode ra dar moteghayere "A" migozarad
            Console.Write("Num 1: ");
            a = float.Parse(Console.ReadLine());

            // Dar inja payami chap mishe ke adade dovom ra az karbar mikhad
            // Va adade gerefte shode ra dar moteghayere "B" migozarad
            Console.Write("Num 2: ");
            b = float.Parse(Console.ReadLine());

            // Agar "A" az "B" koochek tar bood
            // "A" ra be onvane "MIN" dar nazar begire
            // Va "MIN" ra chap kone
            if (a > b)
            {
                min = a;
                Console.WriteLine("Min: " + min);
            }
            
            // Agar "B" az "A" koochek tar bood
            // "B" ra be onvane "MIN" dar nazar begire
            // Va "MIN" ra chap kone
            if (b > a)
            {
                max = b;
                Console.WriteLine("Min: " + min);
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
