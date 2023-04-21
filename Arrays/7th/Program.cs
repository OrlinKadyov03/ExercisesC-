namespace _7th
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int counter = 0;
            int tempIndex;
            int tempCounter;

            Console.WriteLine("Enter array length");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter element {0}",i);
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                int[] tempResult = new int[n];
                tempIndex = tempCounter = 1;
                tempResult[0] = array[i];

                for (int j = i+1 ; j < n; j++)
                {
                    if (array[j] > tempResult[tempIndex-1])
                    {
                        tempResult[tempIndex] = array[j];
                        tempIndex++;
                        tempCounter++;
                    }
                    else if (tempIndex > 1 && array[j] > tempResult[tempIndex - 2] && array[j] < tempResult[tempIndex-1])
                    {
                        tempResult[tempIndex - 1] = array[j];
                    }
                }
                if (counter < tempCounter)
                {
                    counter = tempCounter;
                    result = tempResult;
                }
            }
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine("Result {0}", result[i]);
            }
        }
    }
}