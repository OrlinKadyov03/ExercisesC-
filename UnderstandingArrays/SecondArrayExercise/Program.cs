namespace SecondArrayExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter the values of the array");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            bool isSymetric = true;
            for (int i = 0; i < array.Length/2; i++)
            {
                if (array[i] != array[n-i-1])
                {
                    isSymetric = false;
                }
            }
            Console.WriteLine("Is symetric {0}",isSymetric);

        }
    }
}