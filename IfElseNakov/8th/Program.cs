namespace _8th
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n ; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num >= 1 && num <= 3)
                {
                    Console.WriteLine(num * 10);
                }
                else if (num >= 4 && num <= 6)
                {
                    Console.WriteLine(num * 100);
                }
                else if (num >= 7 && num <=9 )
                {
                    Console.WriteLine(num * 1000);
                }
                if (num < 1 || num > 9)
                {
                    Console.WriteLine("Error");
                }

            }
        }
    }
}