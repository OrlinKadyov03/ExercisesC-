namespace IfElseNakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 7;
            int c = 0;
            if (a > b)
            {
                c = a;
                a = b;
                b = c;
                Console.WriteLine("{0} {1}",a,b);

            }
            else
            {
                Console.WriteLine("{0} {1}", a, b);
            }
        }
    }
}