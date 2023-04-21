using System.Diagnostics.CodeAnalysis;

namespace JelevExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дефинирайте масив от double. Напишете алгоритъм за намиране на средно
            //аритметичното на числата в масива.
            AverageAndSumOfArray();

        }

        private static void AverageAndSumOfArray()
        {
            double sum = 0;
            double[] arr = new double[7];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }
            double divide = sum / arr.Length;
            Console.WriteLine(sum);
            Console.WriteLine("Divide by count {0} ", divide);
        }
    }
}