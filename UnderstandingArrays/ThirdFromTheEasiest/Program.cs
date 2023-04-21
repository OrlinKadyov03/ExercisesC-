namespace ThirdFromTheEasiest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 6; i >= 1; i--)
            {
                for (int j = i - 1; j >= 1; j--)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
        }
    }
}