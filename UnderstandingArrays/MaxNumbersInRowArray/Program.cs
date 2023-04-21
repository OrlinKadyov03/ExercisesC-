
namespace MaxNumbersInRowArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentSequenceLength = 1, longestSqeuenceLength = 1, bestStart = 0, lastElement = 0; ;

            Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());
            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (int index = 0; index < arr.Length-1; index++)
            {
                if (arr[index] + 1 < arr[index + 1]) currentSequenceLength++;

                if (currentSequenceLength>longestSqeuenceLength)
                {
                    longestSqeuenceLength = currentSequenceLength;
                    bestStart = index + 1;
                    lastElement = bestStart - longestSqeuenceLength + 1;
                }
        
            }
     

            for (int i = bestStart; i < longestSqeuenceLength + bestStart ; i++) Console.Write("{0}, ", arr[i]);
        }
    }
}