namespace MaxNumbersUnderRow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            for (int x = 0; x < arr.Length - 1; x++)
            {
                for (int i = arr[x]; i < x-1; i++)
                {

                }
            }

        }
    }
}