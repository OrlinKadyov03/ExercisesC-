namespace JelevExerciseTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Създайте масив с числата {3,2,7,6,9}. Потребителя въвежда число и то заменя
            //всички четни числа в масива.

            Console.Write("Insert number - ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = { 3, 2, 7, 6, 9,};
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arr[i] = n;
                }
                Console.WriteLine(arr[i]);
            }
         
        }
    }
}