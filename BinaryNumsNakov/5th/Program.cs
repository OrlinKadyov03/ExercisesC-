namespace _5th
{
    internal class Program
    {
       
        static void Main(string[] args)
        {

            Console.Write("Enter binary number: ");
            int number = int.Parse(Console.ReadLine());
            int decimalValue = 0;

            int basel = 1;

            while (number>0)
            {
                int reminder = number % 10;
                number = number / 10;
                decimalValue += reminder * basel;
                basel = basel * 2;
            }
            Console.Write($"Decimal value: {decimalValue}");

            Console.ReadKey();
        }
    }
}