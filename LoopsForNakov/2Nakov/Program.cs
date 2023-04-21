namespace _2Nakov
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <=100; i++)
            {
                bool isPrime = true;
                for (int o = 2; o < i; o++)
                {
                    if (i % o == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}