using System.Security.Cryptography.X509Certificates;

namespace _9th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double dcs = b * b - 4 * a * c;

            if (dcs < 0)
            {
                Console.WriteLine("No real roots");
            }
            else if (dcs == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"One real root is x = {x}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(dcs)) / (2 * a);
                double x2 = (-b - Math.Sqrt(dcs)) / (2 * a);
                Console.WriteLine($"The two real roots are {x1} , {x2}");
            }



        }
    }
}