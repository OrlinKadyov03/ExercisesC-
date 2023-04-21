namespace _11th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int sumTwo = 0;
            int sumThree = 0;
            int sumFour = 0;
            int firstCouple = 0;
            int secondCouple = 0;
            int thirdCouple = 0;
            int fourthCouple = 0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum += num;
                firstCouple = sum;       
            }
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sumTwo += num;
                secondCouple = sumTwo;
                sumThree += num;
                thirdCouple = sumThree;
            }
            if (secondCouple != firstCouple)
            {
                int diffTwo = Math.Abs(secondCouple - firstCouple);
                Console.WriteLine("Diff {0}", diffTwo);
            }
            else if (secondCouple == firstCouple)
            {

                Console.WriteLine(firstCouple);
            }
            else
            {
                int summing = secondCouple + firstCouple;
                Console.WriteLine(summing);
            }

            Console.WriteLine(secondCouple);
         

       
        }
    }
}