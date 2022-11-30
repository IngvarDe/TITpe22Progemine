using System;

namespace MathCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sulgude kasutamine");
            Console.WriteLine("Kui palju on: 3 + 8 /(4 - 2) * 4 = ???");

            double calculation1 = 3 + 8 / (4 - 2) * 4;
            double calculation2 = (3 + 8) / (4 - 2) * 4;
            double calculation3 = (3 + 8 / (4 - 2) * 4);

            Console.WriteLine("Vastus1: " + calculation1);
            Console.WriteLine("Vastus2: " + calculation2);
            Console.WriteLine("Vastus3: " + calculation3);


            double firstNumber = 100;
            double secondNumber = 75;
            double thirdNumber = 50;

            double answer = firstNumber / (secondNumber * thirdNumber);
            Console.WriteLine(answer);
        }
    }
}
