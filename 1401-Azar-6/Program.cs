using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            float h, fin, mal, bim, mas;
            // H = Hoghoogh
            // FIN = Final ya hamoon akhar
            // MAL = Maliat
            // BIM = Haghe bimeh
            // MAS = Haghe maskan

            Console.Write("Hoghoogh ra vared konid: ");
            h = float.Parse(Console.ReadLine());
            // Hoghoogh az karbar gerefte mishe
            // Dar inja, hoghooghi ke vared mishe be moteghayere "h" tarif shode

            // !!!!!
            // NOKTEH!
            // Agar adad ra be soorate melioni gozashte bashand
            // Yani be tore mesal: 10000000
            // Momken ast adad be soorate adade elmi dar miad.
            // Baraye inke be adade elmi dar nayad
            // Mitavan adad ha ra be soorate koochik benevisim
            // Be tore mesal: 10000000 = 10
            // Dar inja hamin amal anjam shode
            // Agar mikhahid, mitavanid in kod ra baraye khodetan be melion tabdil konid
            // Agar be melioni tabdil shod, niaze ke karbar be melioni ham vared kone
            // !!!!!

            // Agar kamtar az 10 melion bood
            // Payam chap kone ke maliat nadarad
            if (h <= 10)
                Console.WriteLine("Maliat nadarad." + h);

            // Agar beine 10 ta 15 melion bood
            // Az hoghoogh, maliat kam kone va hoghooghe nahayi ro chap kone
            else if ((h>10)&&(h<15))
            {
                mal = h * 2 / 100;
                fin = h - mal;
                Console.WriteLine("Final: " + fin);
            }

            // Agar beine 15 ta 20 melion bood
            // Az hoghoogh, maliat va haghe bime ra kam kone va hoghooghe nahayi ra chap kone
            else if ((h>15)&&(h<20))
            {
                mal = h * 2 / 100;
                bim = h * 3 / 100;
                fin = h - mal - bim;
                Console.WriteLine("Ffinal: " + fin);
            }

            // Agar bishtar az 20 melion bood
            // Az hoghoogh, maliat, haghe bimeh va haghe maskan ra kam kone va hoghooghe nahayi ra chap kone
            else if(h>20)
            {
                mal = h * 1 / 100;
                bim = h * 2 / 100;
                mas = h * 3 / 100;
                fin = h - mal - bim - mas;
                Console.WriteLine("Final: " + fin);
            }

            // Payane barnameh
            Console.ReadKey();
        }
    }
}
