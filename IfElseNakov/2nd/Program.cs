using System.Diagnostics.CodeAnalysis;

namespace _2nd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            double numThree = double.Parse(Console.ReadLine());


            if (numOne < 0 && numTwo < 0 && numThree < 0)
            {
                Console.WriteLine("-");
            }
            else if (numOne >= 0 && numTwo >= 0 && numThree > 0)
            {
                Console.WriteLine("+");
            }
            else if (numOne < 0 && numTwo < 0 && numThree >= 0)
            {
                Console.WriteLine("+");
            }
            else if (numOne < 0 && numTwo >= 0 && numThree < 0)
            {
                Console.WriteLine("+");
            }
            else if (numOne >= 0 && numTwo < 0 && numThree < 0)
            {
                Console.WriteLine("+");
            }
            else if (numOne < 0 && numTwo >= 0 && numThree >= 0)
            {
                Console.WriteLine("-");
            }
            else if (numOne >= 0 && numTwo < 0 && numThree >= 0)
            {
                Console.WriteLine("-");
            }
            else if (numOne >= 0 && numTwo >= 0 && numThree < 0)
            {
                Console.WriteLine("-");
            }
        }
    }
}