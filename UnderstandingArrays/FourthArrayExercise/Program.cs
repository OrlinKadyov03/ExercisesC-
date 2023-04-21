namespace FourthArrayExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            for (int index = array.Length-1; index>=0; index--)
            {
                Console.Write(array[index] + " ");
            }
        }
    }
}