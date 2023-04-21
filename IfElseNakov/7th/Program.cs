namespace _7th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < a; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }

            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);
         
        }
    }
}