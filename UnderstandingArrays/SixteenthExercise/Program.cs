using System;
using System.Net.WebSockets;
using System.Transactions;

namespace SixteenthExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която да приема N на брой числа и да ги записва в масив.
            //След което да приеме числото I, което да бъде позиция в масива.Програмата
            //трябва да изтрие числото на позиция I от масива и да отпечата масива на
            //конзолата.

            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements");
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter index");
            int I = int.Parse(Console.ReadLine());

            List<int> nums = new List<int>(arr);
            nums.RemoveAt(nums.IndexOf(arr[I]));
            arr = nums.ToArray();

            Console.WriteLine(String.Join(",", arr));


        }
    }
}