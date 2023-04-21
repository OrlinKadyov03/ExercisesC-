namespace _13th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            double sum = 1.0;
            for (int i = 2; i <=length; i++)
            {
                sum += (1.0 / i);
            }
            Console.WriteLine("{0:f3}",sum);
        }
    }
}