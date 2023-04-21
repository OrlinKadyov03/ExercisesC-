namespace FourtheenthExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Покажете всички прости числа в даден диапазон

            bool isPrime = true;
            Console.WriteLine("Enter the number of prime you want: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 2; i <= num; i++)
            {
                for (int j = 2; j <= num; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write("\n " + i);
                }

                isPrime = true;
            }
        }
    }
}