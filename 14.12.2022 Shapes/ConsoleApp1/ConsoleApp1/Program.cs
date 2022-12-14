using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Kuju valimine ja arvutamine"; //aknale nime panemine
            Console.WriteLine("Vali, mis kujundit soovid arvutada ja kujutada ning kirjuta konsoolile");

            Console.WriteLine("\n1. Ruut");
            Console.WriteLine("2. Teemant");
            Console.WriteLine("3. Ristkülik");
            Console.WriteLine("4. Püramiid");

            string shape = Console.ReadLine();

            switch (shape)
            {
                case "ruut":
                    Quadrilateral();
                    break;

                case "teemant":


                case "ristkülik":


                case "kolmnurk":


                default:
                    Console.WriteLine("\nVale. Valikut ei tehtud.");
                    break;
            }
        }

        private static void Quadrilateral()
        {
            Console.WriteLine("\nSisesta ruudu ühe külje mõõtühik sentimeetrites: ");
            double quadrilateral = double.Parse(Console.ReadLine());


            for (int row = 1; row <= quadrilateral; row++)
            {
                for (int column = 1; column <= quadrilateral; column++)
                {
                    string mark;
                    if (row == column || row + column <= row + 1)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }
    }
}
