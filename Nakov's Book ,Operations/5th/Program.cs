namespace _5th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double h = double.Parse(Console.ReadLine());

            double sum = ((a + b) / 2) * h;

            Console.WriteLine(sum);
        }
    }
}