using System.Net.Http.Headers;

namespace TwoArraysEqual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool areEqual = true;
            Console.Write("Enter the length of the first array");
            int n = Int32.Parse(Console.ReadLine());

            int[] array = new int[n];


            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter element {0}: ", i);
                array[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Enter the length of the first array");
            if (n != Int32.Parse(Console.ReadLine()))
            {
                Console.WriteLine("Arrays have diffrent length");
            }
            else
            {
                int[] arrayTwo = new int[n];

                for (int i = 0; i < arrayTwo.Length; i++)
                {
                    Console.Write("Enter element {0}: ", i);
                    arrayTwo[i] = Int32.Parse(Console.ReadLine());

                }
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != arrayTwo[i])
                    {
                        Console.WriteLine("Array are diffrent");
                        areEqual = false;
                        break;
                    }
                }
                if (areEqual)   Console.WriteLine("\nrray are the same ");
            }

            

          
        }
    }
}