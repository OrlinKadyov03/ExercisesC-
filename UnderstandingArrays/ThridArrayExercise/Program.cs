using System;

namespace ThridArrayExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            Console.Write("Output: ");
            for (int index = 0; index < array.Length; index+=2)
            {
                array[index] = array[index] * array[index];
                Console.WriteLine("Numbers are {0}", array[index]);
            }


            
        }
    }
}