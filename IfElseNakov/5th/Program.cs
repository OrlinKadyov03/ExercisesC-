namespace _5th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("Нула");
            }
            else if (n == 1)
            {
                Console.WriteLine("Едно");
            }
            else if (n == 2)
            {
                Console.WriteLine("Две");
            }
            else if (n==3)
            {
                Console.WriteLine("Три");
            }
            else if (n == 4)
            {
                Console.WriteLine("Четери");
            }
            else if (n == 5)
            {
                Console.WriteLine("Пет");
            }
            else if (n == 6)
            {
                Console.WriteLine("Шест");
            }
            else if (n == 7)
            {
                Console.WriteLine("Седем");
            }
            else if (n == 8)
            {
                Console.WriteLine("Осем");
            }
            else if (n == 9)
            {
                Console.WriteLine("Девет");
            }
            else if (n < 0 || n > 9)
            {
                Console.WriteLine("Unavailable");
            }

        }
    }
}