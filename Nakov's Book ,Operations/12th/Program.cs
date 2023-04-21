namespace _12th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 35;
            int v = 1;
            int p = 2;
            n = (v == 0) ? n = n & (~(1 << p)) : n = n | (1 << p);
            Console.WriteLine(n);

        }
    }
}