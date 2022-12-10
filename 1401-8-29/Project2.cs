using System;

namespace Proj2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dar inja yek moteghayer dar naza gerefte shode ast
            float a;
            // A = Adad

            // Dar inja, az karbar darkhast mishe ke yek adad vared konad
            // Va adade vared shode dar moteghayere "A" gozashte mishe
            Console.Write("Adad ra vared konid: ");
            a = float.Parse(Console.ReadLine());

            // Agar adade dade shode, kamtar az 0 bood
            // Yani inke adade manfi dade shod
            // Payami chap mikone ke mige adad manfiye
            if (a < 0)
                Console.WriteLine("Adad manfi ast");
            
            // Vali agar adad beine 0 ta 9 bood
            // Chap kone ke adad yek raghami ast
            else if ((a >= 0) && (a <= 9))
                Console.WriteLine("Adad yek raghami ast");
            
            // Vali agar adade dade shode beine 10 ta 99 bood
            // Chap kone ke adad do raghami mi bashad
            else if ((a > 9) && (a <= 99))
                Console.WriteLine("Adad do raghami ast");
            
            // Vali agar adade dade shode beine 100 ta 999 bood
            // Chap kone ke adade dade shode se raghami ast
            else if ((a > 99) && (a <= 999))
                Console.WriteLine("Adad se raghami ast");
            
            // Vali agar bishtar az 999 bood
            // Chap kone ke in adad bishtar az se ragham ast
            else if (a > 1000)
                Console.WriteLine("Adad bishtar az se ragham ast");

            // Payane barnameh
            Console.ReadKey();
        }
    }
}
