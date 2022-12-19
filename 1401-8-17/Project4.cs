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
            
            // Darsad (%) dar inja yani inke yek adad ra be adadi digar taghsim mikone va baghimandeye taghsim ro mizare
            // Va baghimandeye taghsim dar "A" gozashte mishe
            a = n % 5;

            // Agar baghimandeye "A" mosavi bood ba 0
            // Ya begim "A" mosavi bood ba 0
            // Chap kone ke "Mazrabe 5 hast"
            if (a == 0)
                Console.WriteLine("Mazrabe 5 hast.");
            
            // Agar baghimandeye "A" mosavi nabood ba 0
            // Ya begim "A" mosavi nabood ba 0
            // Chap kone ke "Mazrabe 5 nist"
            if (a != 0)
                Console.WriteLine("Mazrabe 5 nist.");

            // Payane barnameh
            Console.ReadKey();
        }
    }
}
