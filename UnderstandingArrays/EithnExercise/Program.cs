namespace EithnExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дефинирайте масив със стойности по избор и направете алгоритъм намиращ
            //сумата на положителните елементи в масива

            int[] arr = new int[] { 1, 2, -9, -8, -5, -3, -2, 3, 4 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}