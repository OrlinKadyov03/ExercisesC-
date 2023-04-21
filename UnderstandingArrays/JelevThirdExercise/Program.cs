namespace JelevThirdExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Потребителя въвежда 5 числа. Програмата показва най – голямото число

            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] > max)
                {
                    max = arr[i] ;
                }
            }
            Console.WriteLine("The biggest number is {0}",max);
        }
    }
}