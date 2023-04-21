namespace _13th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s, d;

            Console.WriteLine("Enter N:");

            string n = Console.ReadLine();

            do
            {
                Console.Write("Enter S (S == 2, 8, 10 or 16): ");
                s = Int32.Parse(Console.ReadLine());

            } while (s !=2&& s!= 00 && s!=10 && s!=16);

            do
            {
                Console.Write("Enter D (D == 2, 8, 10 or 16): ");
                d = Int32.Parse(Console.ReadLine());
            } while (d != 2 && d != 8 && d != 10 && d != 16);


            n = Convert.ToString(Convert.ToInt32(n, s), d);

            Console.WriteLine("Result is {0}.", n);

        }
    }
}