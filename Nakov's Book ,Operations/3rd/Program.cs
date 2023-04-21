namespace _3rd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int divide = num / 100;
            int forTens = divide / 10;
            if (forTens == 7)
            {
                Console.WriteLine($"The third number equals to - 7: by index\n{num}");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}