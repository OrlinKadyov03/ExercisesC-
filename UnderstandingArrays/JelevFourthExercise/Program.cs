namespace JelevFourthExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Създайте масив със следните стойности {1,5,3,2,9}. Направете нов масив и
            //прехвърлете тези стойности в новия масив, като умножите всяко число по 2

            int[] arr = new int[] { 1, 5, 3, 2, 9 };
            int[] arrTwo = new int[] { 1, 5, 3, 2, 9 };
            

            for (int i = 0; i < arr.Length; i++)
            {
                arrTwo[i] = arr[i];
                Console.Write("First Array {0} -- ",arr[i]);

                arrTwo[i] *= 2;
                Console.WriteLine("Second Array {0}", arrTwo[i]);
            }
           






        }
    }
}