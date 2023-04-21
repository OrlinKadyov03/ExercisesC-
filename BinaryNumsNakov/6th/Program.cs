namespace _6th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter decimal number: ");
            int deci = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} to hexadecimal is {1}.",
                deci, deci.ToString("X"));
        }
    }
}