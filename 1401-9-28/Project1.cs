using System;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            char color;

            Console.WriteLine("Enter a letter (R/G/B): ");
            color = char.Parse(Console.ReadLine());

            if ((color == 'R')||(color=='r'))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("It's Red!");
            }

            else if ((color == 'G')||(color=='g'))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("It's Green!");
            }

            else if ((color=='B')||(color=='b'))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("It's Blue!");
            }

            else
            {
                Console.WriteLine("The entered letter does not require nor match with R, G, or B.");
                Console.WriteLine("No color would be displayed.");
            }

            Console.ReadKey();
        }
    }
}
