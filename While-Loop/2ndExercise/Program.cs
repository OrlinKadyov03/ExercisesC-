namespace _2ndExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int counter = 0;

            double balance = 0.0;

            while (counter < num)
            {
                double sumOne =double.Parse(Console.ReadLine());

                if (sumOne < 0)
                {
                    Console.WriteLine("Invalid Operation!");
                    break;
                }
                balance = balance + sumOne;
                Console.WriteLine($"Increase: {sumOne:f2}");
                counter++;
            }
            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}