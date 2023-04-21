namespace _7th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int fact = 2 * n;
            int factnPlus = n + 1;

            for (int i = fact-1; i >0; i--) 
            {
                fact *= i;
            }
            for (int i = factnPlus-1; i > 0 ; i--)
            {
                factnPlus *= i;
            }
            for (int i = n-1; i > 0 ; i--)
            { 
                n *= i;
            }
            Console.WriteLine("Result is {0}",fact/(factnPlus * n));
        }
    }
}