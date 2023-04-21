namespace NinethExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дефинирайте масив със стойности по избор и намерете броя на четните и броя
            // на нечетните елементи в него
            int countEven = 0;
            int countOdd = 0;   
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12,14 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
                
            }
            Console.WriteLine("Even {0}",countEven);
            Console.WriteLine("Odd {0}",countOdd);
        }
    }
}