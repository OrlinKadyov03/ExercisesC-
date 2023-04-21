namespace _6th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <=n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num == 0)
                {
                    Console.WriteLine("Unavailable number , try one more time");
                    num = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine(sum);       

        }
    }
}