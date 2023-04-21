namespace _2ndExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            int result = 0;

            string symbol = Console.ReadLine();

            double plus = numberOne + numberTwo;
            double minus = numberOne - numberTwo;
            double x2 = numberOne * numberTwo;
            double division = (double)numberOne / numberTwo;
            double moduldivision = numberOne % numberTwo;

            if (symbol == "+" || symbol == "-")
            {
                if (plus % 2 == 0)
                {
                    Console.WriteLine($"{numberOne} {symbol} {numberTwo} = {plus} - Even");
                }
                else if (minus % 2 == 0)
                {
                    Console.WriteLine($"{numberOne} {symbol} {numberTwo} = {minus} - Odd");
                }
            }
            else if (symbol == "*")
            {
                if (x2 % 2 == 0)
                {
                    Console.WriteLine($"{numberOne} {symbol} {numberTwo} = {x2} - Even");
                }
                else
                {
                    Console.WriteLine($"{numberOne} {symbol} {numberTwo} = {x2} - Odd");
                }
            }
            else if (symbol == "/")
            {
                Console.WriteLine($"{numberOne} / {numberTwo} = {division:f2}");
            }
            else if (symbol == "/" && numberOne == 0 || numberTwo == 0)
            {
                Console.WriteLine($"You cannot divide {numberOne} by zero");
            }
            else if (symbol == "%")
            {
                Console.WriteLine($"{numberOne} % {numberTwo} = {moduldivision}");
            }
            else if (symbol == "%" && numberOne == 0 || numberTwo == 0)
            {
                Console.WriteLine($"You cannot divide {numberOne} by zero");
            }

        }
    }
}