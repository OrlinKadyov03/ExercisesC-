namespace _5th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            for (int i = 1; i <=n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num<min)
                {
                    min = num;
                }
            }
            Console.WriteLine(min);
        }
    }
}