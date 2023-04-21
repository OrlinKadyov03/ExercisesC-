namespace _9th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter binary num");
            string n = (Console.ReadLine());
            Console.WriteLine("{0} to hexadecimal is {1}.",
            n, Convert.ToInt32(n,2).ToString("X"));

        }
    }
}