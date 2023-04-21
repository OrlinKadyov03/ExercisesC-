namespace OneDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int index = 0; index < array.Length; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
                array[index] = array[index] * 5;
                Console.WriteLine("Element index is {0} and the * is {1}", index, array[index]);
            }

        }
    }
}