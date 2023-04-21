namespace _4th
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter decimal number: ");
            int number = int.Parse(Console.ReadLine());

            string result = string.Empty;
            for (int i = 0; number>0 ; i++)
            {
                result = number % 2 + result;
                number /= 2;    
            }

            Console.WriteLine($"Binary Represenation of the give number : {result}");

            Console.ReadKey();

        }
    }
}