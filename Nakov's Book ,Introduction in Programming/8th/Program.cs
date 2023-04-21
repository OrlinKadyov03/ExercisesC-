namespace _8th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "Hello";
            string wordTwo = "World";

            object type = word + " " + wordTwo;
            string sentece = Convert.ToString(type);
            Console.WriteLine(type);
        }
    }
}