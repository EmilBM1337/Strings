using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 50;
            Console.WindowWidth = 200;

            //Opgave 1.1

            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i}: Hello world");
            }
            */

            //Opgave 1.2

            /*
            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine(x);
            }
            */

            //Opgave 1.3

            /*
            for (int y = 10; y >= 1; y--)
            {
                Console.WriteLine(y);
            }
            */

            //Opgave 1.4

            /*
            for (int z = 2; z <= 20; z+=2)
            {
                Console.WriteLine(z);
            }
            */

            //Opgave 1.5

            /*
            for (int a = 1; a <= 20; a+=2)
            {
                Console.WriteLine(a);
            }
            */

            //Opgave 1.6

            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            for (b = 0; b <= c; b++)
            {
                Console.WriteLine(b);
            }
        }
    }
}
