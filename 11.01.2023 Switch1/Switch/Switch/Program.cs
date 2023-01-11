namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int greeting = 2;

            switch (greeting)
            {
                case 1:
                    Console.WriteLine("Hello");
                    goto default;
                    
                case 2:
                    Console.WriteLine("Bonjour");
                    goto case 3;

                case 3:
                    Console.WriteLine("Namaste");
                    goto case 1;

                default:
                    Console.WriteLine("Entered value is: " + greeting);
                    break;
            }
        }
    }
}