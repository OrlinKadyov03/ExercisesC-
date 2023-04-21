namespace _8th
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                for (int j = i; j <= i ; j++)
                {

                    Console.WriteLine(" {0}",j);
                }
                Console.WriteLine();
            }
            
        }
    }
}