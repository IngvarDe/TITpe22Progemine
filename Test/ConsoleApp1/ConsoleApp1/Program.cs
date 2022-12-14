using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int squareSize;

            Console.WriteLine("palun sisesta ruudu suurus: ");
            squareSize = Int32.Parse(Console.ReadLine());

            for (int row = 1; row <= squareSize; row++)
            {
                for (int column = 1; column <= squareSize; column++)
                {
                    string string1;

                    string1 = (row == column || row + column == squareSize + 1) ? " X " : " 0 ";
                    //täpselt sama, mis alumine if ja else

                    //if (row == column || row + column == squareSize + 1)
                    //{
                    //    string1 = " X ";
                    //}
                    //else
                    //{
                    //    string1 = " 0 ";
                    //}
                    Console.Write(string1);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
