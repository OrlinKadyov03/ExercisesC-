namespace _8th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int sum = 0;

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the element {0} ",i);
                array[i] = int.Parse(Console.ReadLine());
      
            }
            Array.Sort(array, (a, b) => b.CompareTo(a));

            for (int i = 0; i < k; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("Biggest sum is {0}",sum);

        }
    }
}