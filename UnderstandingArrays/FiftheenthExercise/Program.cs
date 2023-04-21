namespace FiftheenthExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Обединете два сортирани масива***

            int[] arr = new int[] { 1,2,3,4,5 };
            int[] arrTwo = new int[] {1,2,3,4,5};

            Array.Sort(arr);
            Array.Sort(arrTwo);
            for (int i = 0; i < arr.Length; i++)
            {
              
            }
            for (int i = 0; i < arrTwo.Length; i++)
            {
                Console.WriteLine(arr[i] + arrTwo[i]);

            }








        }
    }
}