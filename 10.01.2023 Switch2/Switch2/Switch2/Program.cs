namespace Switch2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number ja vajuta enter");

            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("One");
                    Console.Beep();
                    break;

                case 2:
                    Console.WriteLine("Two");
                    Console.Beep();
                    Console.Beep();
                    break;

                case 3:
                    Console.WriteLine("Three");
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    break;

                default: 
                    Console.WriteLine("Some other number");
                    break;
            }
        }
    }
}