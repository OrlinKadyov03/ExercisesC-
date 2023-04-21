namespace Nakov_s_Book__Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 6;

            int sum = a + b;

            if (sum % 2 == 0)
            {
                Console.WriteLine($"Even {sum}");
            }
            else
            {
                Console.WriteLine($"Odd {sum}");
            }
        }
    }
}