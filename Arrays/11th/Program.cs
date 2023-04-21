namespace _11th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int tempCounter = 1;
            int foundNumber = 0;

            Console.WriteLine("Enter array length");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Elements of the array {0}",i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);

            for (int i = 0; i < n-1; i++)
            {
                if (array[i] == array[i + 1] )
                {
                    tempCounter++;
                }
                else
                {
                    tempCounter = 1;
                }
                if (tempCounter>counter)
                {
                    counter = tempCounter;
                    foundNumber = array[i];
                }
            }
            Console.WriteLine("{0} was found {1} times",foundNumber,counter);
        }
    }
}