namespace Switch3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Täringu viskamine");

            int cube = new Random().Next(1, 6);

            switch (cube)
            {
                case 1:
                    Console.WriteLine("Said 1 ja oled luuser");
                    break;

                case 2:
                    Console.WriteLine("Said 2 ja natuke parem tulemus");
                    break;

                case 3:
                    Console.WriteLine("Said 3 ja pole paha");
                    break;

                case 4:
                    Console.WriteLine("Said 4 ja juba läheb");
                    break;

                case 5:
                    Console.WriteLine("Said 5 nagu tubli õpilane");
                    break;

                case 6:
                    Console.WriteLine("Said 6 ja max punktid");
                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}