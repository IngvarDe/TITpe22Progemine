using System;

namespace TeineIfjaElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mitme if ja else-ga konsoolirakendus");

            //muutuja nimega y on defineeritud
            double y;
            // muutujale y on antud v''rtus 20.5
            y = 9;

            //vaatame, kas y v]rdub 10
            if (y < 20)
            {
                //Console.WriteLine("Value of y = 10; Second conition is true");
                //Console.ReadLine();
                if (y == 11)
                {
                    Console.WriteLine("Vastus on 11");
                }
                else
                {
                    Console.WriteLine("Vastus oli 0 kuni 10 ja 12 kuni 19");
                }
            }
            // vaatame,kas y v]rdub 20.5
            else if (y == 20.5)
            {
                Console.WriteLine("Value of y = 20.5; Second conition is True");
                Console.ReadLine();
            }
            //vaatame, kas y v]rdub 30
            else if (y == 30)
            {
                Console.WriteLine("Value of y = 30; Third conition is true");
                Console.ReadLine();
            }
            //k]ik [lej''nud v''rtused
            else
            {
                Console.WriteLine("None of the conitions are True, so else block executed!");
            }
            Console.ReadLine();
        }
    }
}
