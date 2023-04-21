namespace _3rd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a < b && b < c)
            {
                Console.WriteLine(c);
            }
            else if (b < a && a < c)
            {
                Console.WriteLine(c);
            }
            else if (c < b && b < a)
            {
                Console.WriteLine(a);
            }
            else if (b < c && c < a)
            {
                Console.WriteLine(a);
            }
            else if (a<c && c < b)
            {
                Console.WriteLine(b);
            }
            else if (c<a && a < b)
            {
                Console.WriteLine(b);
            }
        }
    }
}