namespace _12th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int start = 0;
            int end = 0;
            bool sumFound = false;

            Console.Write("Enter S: ");
            int s = Int32.Parse(Console.ReadLine());

            Console.Write("Enter array length:  ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Elements of array {0}: ",i);
                array[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n-1; i++)
            {
                sum += array[i];
                for (int j = 0; j < n; j++)
                {
                    sum += array[j];
                    if (sum == 5)
                    {
                        start = i;
                        end = j;
                        sumFound = true;
                        break;
                    }
                }
                if (sumFound)
                {
                    break;
                }
            }
            if (sumFound)
            {
                for (int i = start; i <= end; i++)
                {
                    Console.Write("{0}", array[i]);
                }
            }
            else
            {
                Console.WriteLine("No sum found");
            }
        }
    }
}