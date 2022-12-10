using System;

namespace Proj1
{
    class Program
    {
        static void Main(string[] args)
        {
        // Dar inja, 4 moteghayer dar nazar gerefte mishavand.
            float a, b, c, max;
            // A = Adade aval
            // B = Adade dovom
            // C = Adade sevom
            // MAX = Moteghayeri ke adade bozorg tar ro moshakhas mikone

            // ِDar inja, payami chap mikone ke adade aval ke ra vared konim
            /// Va dar moteghayere "A" migozarim
            Console.Write("Adade yek: ");
            a = float.Parse(Console.ReadLine());

            // Dar inja, payami chap mikone ke adade dovom ke ra vared konim
            // Va dar moteghayere "B" migozarim
            Console.Write("Adade do: ");
            b = float.Parse(Console.ReadLine());
            
            // Dar inja, payami chap mikone ke adade sevom ke ra vared konim
            // Va dar moteghayere "C" migozarim
            Console.Write("Adade se: ");
            c = float.Parse(Console.ReadLine());

            // Agar "A" az "B" bozorg tar bood va "A" az "C"
            // "A" ra be onvane "MAX" dar nazar begir
            // Va "MAX" ra chap kon
            if((a>b) && (a>c))
            {
                max = a;
                Console.WriteLine("maximum: " + max);
            }
            
            // Agar "B" az "A" bozorg tar bood va "B" az "C"
            // "B" ra be onvane "MAX" dar nazar begir
            // Va "MAX" ra chap kon
            if((b>a) && (b>c))
            {
                max = b;
                Console.WriteLine("Maximum: " + max);
            }
            
            // Agar "C" az "A" bozorg tar bood va "C" az "B"
            // "C" ra be onvane "MAX" dar nazar begir
            // Va "MAX" ra chap kon
            if((c>a) && (c>b))
            {
                max = c;
                Console.WriteLine("maximum: " + max);
            }
            
            // Agar "A" mosaviye ba "B" va "B" mosaviye ba "C"
            // Chap kone ke "Se adad mosaviand"
            if((a == b) && (b == c))
                Console.WriteLine("se adad mosaviand");

            // Payane barnameh
            Console.ReadKey();
        }
    }
}
