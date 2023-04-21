

namespace AllMaxNumbersThatAreEqualArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempCount = 1, count = 1, number = 0;

            Console.Write("Enter the length of the array ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} Array elements- ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int index = 0; index < arr.Length-1; index++)
            {
                if (arr[index] == arr[index + 1]) tempCount++;
                else tempCount = 1;

                if (tempCount > count)
                {
                    count = tempCount;
                    number = arr[index];
                }
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("The number is {0} ", number);
            }
  
        }
    }
}
