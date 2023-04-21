namespace _10th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int tempSum;

            Console.WriteLine("Enter array length");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Elements of the array {0}",i);
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n-1; i++)
            {
                tempSum = array[i];
                for (int j = i+1; j < n; j++)
                {
                    tempSum += array[j];
                    if (tempSum>sum)
                    {
                        sum = tempSum;
                    }
                }
            }
            Console.WriteLine("Result is {0}",sum);
        }
    }
}