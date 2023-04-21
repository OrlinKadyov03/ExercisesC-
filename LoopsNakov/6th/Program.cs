using System.Diagnostics.CodeAnalysis;

namespace _6th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int left = 0;
            int right = 0;

            for (int i = 0; i <n; i++)
            {
                left = left + int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                right = right + int.Parse(Console.ReadLine());
            }
            if (left == right)
            {
                Console.WriteLine($"Yes the sum = " + left);
            }
            else 
            {
                var diff = right - left;
                Console.WriteLine($"No diff = "+Math.Abs(diff));
            }
     
            
        }
    }
}