using System;

namespace IfElseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Mis värvi soovid valida? (inglise keeles)");
            string color = Console.ReadLine();


            if (color == "red")
            {
                Console.WriteLine("See on punane värv");
                Console.ReadLine();
            }
            else if (color == "blue")
            {
                Console.WriteLine("See on sinine värv");
                Console.ReadLine();
            }
            else if (color == "green")
            {
                Console.WriteLine("See on roheline värv");
                Console.ReadLine();
            }
            else if (color == "white")
            {
                Console.WriteLine("See on valge värv");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Värvi ei sisestatud või oli vale värvi nimetus");
            }
        }
    }
}
