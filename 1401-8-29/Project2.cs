using System;

namespace Proj2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dar inja, 4 moteghayer dar nazar gerefte mishe
            float a, b, c, min;
            // A = Adade aval
            // B = Adade dovom
            // C = Adade sevom
            // MIN = Moteghayeri ke adade koochek tar dar nazar gerefte mishe

            // Payami chap mikone ke adade aval ra vared konim
            // Va dar moteghayere "A" gozashte mishe
            Console.Write("Adade yek: ");
            a = float.Parse(Console.ReadLine());

            // Payami chap mikone ke adade dovom ra vared konim
            // Va dar moteghayere "B" gozashte mishavad
            Console.Write("Adade do: ");
            b = float.Parse(Console.ReadLine());

            // Payami chap mikone ke adade sevom ra bezarim
            // Va dar moteghayere "C" gozashte shavad
            Console.Write("Adade se: ");
            c = float.Parse(Console.ReadLine());

            // Agar "A" az "B" va "A" az "C" koochek tar bood
            // "A" ra be onvane "MIN" dar nazar begire
            // Va "MIN" ra chap kone
            if((a<b) && (a<c))
            {
                min = a;
                Console.WriteLine("Minimum: " + min);
            }
            
            // Agar "B" az "A" va "B" az "C" koochek tar bood
            // "B" ra be onvane "MIN" dar nazar begire
            // Va "MIN" ra chap kone
            if((b<a) && (b<c))
            {
                min = b;
                Console.WriteLine("Minimum: " + min);
            }
            
            // Agar "C" az "A" va "C" az "B" koochek tar bood
            // "C" ra be onvane "MIN" dar nazar begire
            // Va "MIN" ra chap kone
            if((c<a) && (c<b))
            {
                min = c;
                Console.WriteLine("Minimum: " + min);
            }
            
            // Agar har se adad mosavi boodan
            // Yani inke agar "A" mosaviye ba "B" va "B" mosaviye ba "C"
            // Chap kone ke in se adad mosaviand
            if ((a == b) && (b == c))
                Console.WriteLine("Se adad mosaviand");

            // Payane barnameh.
            Console.ReadKey();
        }
    }
}
