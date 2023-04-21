namespace _2nd
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 1; i <=n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }

            }
            Console.WriteLine(min);
            Console.WriteLine(max);
        }
    }
}