using System.Diagnostics.CodeAnalysis;

namespace _6th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double p = 2 * (length * height);
            double s = length * height;

            Console.WriteLine(p);
            Console.WriteLine(s);
        }
    }
}