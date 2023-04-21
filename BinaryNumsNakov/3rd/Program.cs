namespace _3rd
{
    internal class Program
    {

        static void conversation(string value)
        {
            Console.WriteLine("{0} decimal is {1}", value, Convert.ToInt32(value, 16));
            Console.WriteLine("{0} decimal is {1}", value, Convert.ToInt32(value, 16), 2);
        }
        static void Main(string[] args)
        {
            conversation("2A3E");
            conversation("FA");
            conversation("FFFF");
            conversation("5A0E9");
        }
    }
}