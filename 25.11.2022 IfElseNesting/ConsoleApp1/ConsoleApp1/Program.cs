using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If ja else nestimine");

            int a = -1;
            int b = 10;
            int c;

            //a on v'iksem, kui 0 ja b on v'iksem, kui 0
            //&& - t'hendab ja-d ning antud juhul peab m]lemale tingimusele vastama
            if (a < 0 && b < 0)
            {
                Console.WriteLine("Nii a kui ka b on negatiivsed numbrid");
            }
            // || - t'hendab or (v]i) operaatorit.
            // V]ib ainult [hele tingimusele vastata sulgude sees
            else if(a < 0 || b < 0)
            {
                if (b > 0 && b <= 10)
                {
                    c = a + b;
                    Console.WriteLine("Tulemus: {0}", c);
                }
                Console.WriteLine("Üks number on negatiivne");
            }
            else
            {
                Console.WriteLine("Mõlemad numbrid on positiivsed");
            }
            Console.ReadKey();
        }
    }
}
