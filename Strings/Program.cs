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

            while (true)
            {
                Console.WriteLine("Jeg kan tælle fra det første tal du skriver, til det andet tal du skriver.");
                Console.WriteLine("Skriv det første tal.");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skriv det andet tal.");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (b > c)
                {
                    Console.WriteLine("ERROR");
                }

                for (int v = b; v <= c; v++)
                {
                    Console.WriteLine(v);
                }

                Console.WriteLine("");
                Console.WriteLine("Vil du prøve igen?");
                Console.WriteLine("> j < for ja.");
                Console.WriteLine("> n < for nej.");

                string svar = Console.ReadLine();

                if (svar.Equals("j"))
                {
                    Console.WriteLine("Ja");
                    Console.WriteLine("");
                    continue;
                }
                else if (svar.Equals("n"))
                {
                    Console.WriteLine("Nej");
                    break;
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            }
        }
    }
}
