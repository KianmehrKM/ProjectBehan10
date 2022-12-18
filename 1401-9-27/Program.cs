using System;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            float h, mal, bim, mas, fh;

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();

            Console.Write("Hoghoogh ra vared konid: ");
            h = float.Parse(Console.ReadLine());

            if(h<=10000000)
            {
                Console.WriteLine("Maliat nadarad.");
                fh = h;
            }
            if((h>10000000)&&(h<=15000000))
            {
                mal = h * 2 / 100;
                fh = h - mal;
                Console.WriteLine("Maliat = " + mal + "Hoghooghe nahayi = " + fh);
            }
            if((h>15000000)&&(h<=20000000))
            {
                mal = h * 2 / 100;
                bim = h * 3 / 100;
                fh = h - mal - bim;
                Console.WriteLine("Maliat = " + mal + "Bimeh = " + bim + "Hoghogghe nahayi = " + fh);
            }
            Console.ReadKey();
        }
    }
}
