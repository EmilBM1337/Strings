using System;

namespace Opgave_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 50;
            Console.WindowWidth = 200;

            //Opgave 2.1

            /*
            for (int a = 3; a <= 30; a = a + 3)
            {
                Console.WriteLine(a);
            }
            */

            //Opgave 2.2

            /*
            for (int b = 7; b <= 70; b = b + 7)
            {
                Console.WriteLine(b);
            }
            */

            //Opgave 2.3

            int c, d;

            Console.WriteLine("Intast den tabel du vil se, fra 1 til 20.");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            for (c = 1; c <= 20; c++)
            {
                Console.WriteLine("{0} X {1} = {2}", d, c, d * c);
            }
        }
    }
}
