namespace _5th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array length: ");
            int array = int.Parse(Console.ReadLine());
            int[] nArray = new int[array];

            int sames = 1;
            int bestSames = 1;
            int bestStart = 0;
            int lastElement = 0;

            for (int i = 0; i < nArray.Length; i++)
            {
                Console.WriteLine("Element {0}",i);
                nArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < nArray.Length-1; i++)
            {
                if (nArray[i] + 1 == nArray[i+1])
                {
                    sames++;
                    if (sames > bestSames)
                    {
                        bestSames = sames;
                        lastElement = i + 1;
                        bestStart = lastElement - bestSames + 1;
                    }
                }
                else
                {
                    sames = 1;
                }
            }
            for (int i = bestStart; i < bestSames+bestStart; i++)
            {
                Console.Write("{0},  ", nArray[i] );
            }
        }
    }
}