using System;

namespace IfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // muutuja defineerimine, kirjutan programmile, et y on n[[d  t'isarvuga muutuja
            int y;
            // siin annan y-le v''rtuse ja selleks on 22
            y = 22;

            // kontrollin, kas y v]rdub 20 v]i mitte. Kui ei v]rdu, siis kuvab teksti,
            // mis j''b peale else
            if (y == 20)
            {
                Console.WriteLine("The value is 20 and condition is true");
            }
            else
            {
                Console.WriteLine("The value is not 20 so conition is false");
            }
        }
    }
}
