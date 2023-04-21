using System;
using System.Security.Cryptography.X509Certificates;

namespace SeventhExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дефинирайте масива {5,5,3,2,1,5,7}. Направете алгоритъм за намиране на
            //дадено число в масив.


            Console.Write("Enter the number = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] arr = { 5, 5, 3, 2, 1, 5, 7 };
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    count++;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % n == 0)
                {
                    Console.WriteLine($"{arr[i]}");
                   
                }
            }
            Console.WriteLine();
            Console.Write("Times Count {0}",count);
            Console.WriteLine();
      
        }
    }
}