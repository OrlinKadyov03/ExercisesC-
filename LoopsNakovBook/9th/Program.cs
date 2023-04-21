namespace _9th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal n = Int32.Parse(Console.ReadLine());

            int zero = 0;

            for (int i = (int) n -1; i >0; i--)
            {

                n *= i;

                Console.WriteLine("N is {0} and it ends ", n);
            }

            do
            {
                n /= 10;
                zero++;
            } while (n%10==0);

            Console.WriteLine("With {0} zeroes",zero);
        }
    }
}