namespace LINQ
{
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skip the lowest 3 points of the array, then sum the rest.
            // All done by using LINQ

            int[] totalPoints = { 10, 5, 0, 8, 10, 1, 4, 0, 10, 1 };

            int totalScore = totalPoints.OrderBy(p => p).Skip(3).Sum();

            Console.WriteLine(totalScore);
        }
    }
}
