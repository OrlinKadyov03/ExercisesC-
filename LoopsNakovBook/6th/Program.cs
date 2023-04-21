using System.Diagnostics.CodeAnalysis;

namespace _6th
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int factorial = 1;

            int kfactorial = 1;

            int n = Int32.Parse(Console.ReadLine());

            int k = Int32.Parse(Console.ReadLine());

            int nMinus = n - k;

            do
            {
                factorial *= n;
                n--;
            } while (n > 0);


            do
            {
                kfactorial *= k;
                k--;
            } while (k > 0);

            for (int i = nMinus-1; i >0 ; i--) 
            {
                nMinus *= i;

            }
   

            Console.WriteLine("Result is {0}", factorial * kfactorial/nMinus);
        }
    }
}