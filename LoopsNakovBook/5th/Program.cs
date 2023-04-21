namespace _5th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal factorial = 1;

            decimal kfactorial = 1;

            int n = Int32.Parse(Console.ReadLine());

            int k = Int32.Parse(Console.ReadLine());

            do
            {
                factorial *= n;
                n--;
            } while (n>0);


            do
            {
                kfactorial *= k;
                k--;
            } while (k>0);

            factorial /= kfactorial;

            Console.WriteLine("Result is {0}",factorial);
        }
    }
}