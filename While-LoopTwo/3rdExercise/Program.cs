namespace _3rdExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vnoski = int.Parse(Console.ReadLine());

            int counter = 0;

            double balance = 0.0;

            while (counter<vnoski)
            {
                double amount = double.Parse(Console.ReadLine());

                if (amount < 0)
                {
                    Console.WriteLine($"Invalid Operation!");
                    break;
                }
                balance += amount;
                Console.WriteLine($"Increase amount {amount}");
                counter++;
            }
            Console.WriteLine($"Total {balance:f2}");
        }
    }
}