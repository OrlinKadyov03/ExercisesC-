namespace _13th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            a = a + b;
            b = a-b;
            a = a - b;
            
            Console.WriteLine(b);
            Console.WriteLine(a);
        }
    }
}