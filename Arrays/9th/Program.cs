
using System.Security.Cryptography.X509Certificates;

namespace _9th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            Console.WriteLine("-------------");
            foreach (var arr in array)
            {
                Console.Write(arr + " ");
            }
        }
    }
}