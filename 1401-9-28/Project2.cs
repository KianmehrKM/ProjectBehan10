using System;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            char sport;

            Console.Write("Enter a letter (P/F/V/B/S/H): ");
            sport = char.Parse(Console.ReadLine());

            if((sport=='P')||(sport=='p'))
                {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Clear();
                Console.WriteLine("Ping Pong!");
                }

            else if((sport=='F')||(sport=='f'))
                {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Football!");
                }

            else if((sport=='V')||(sport=='v'))
                {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Console.WriteLine("Volleyball!");
                }

            else if((sport=='B')||(sport=='b'))
                {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine("Basketball!");
                }

            else if((sport=='S')||(sport=='s'))
                {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Swimming!");
                }

            else if((sport=='H')||(sport=='h'))
                {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.WriteLine("Handball!");
                }

            else
                {
                Console.WriteLine("The letter you've entered is not on the list!");
                }

            Console.ReadKey();
            }
        }
    }
