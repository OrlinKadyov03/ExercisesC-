namespace NestedConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string season = Console.ReadLine();

            double price = 0;

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season == "summer")
                {
                    price = budget * 30 / 100;
                    Console.WriteLine($"Camp  - {price:f2}");
                }
                else if (season == "winter")
                {
                    price = budget * 70 / 100;
                    Console.WriteLine($"Hotel  - {price:f2}");
                }
            }
            else if (budget <= 1000 )
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    price = budget * 40 / 100.0;
                    Console.WriteLine($"Camp  - {price:f2}");
                }
                else if (season == "winter")
                {
                    price = budget * 80 / 100.0;
                    Console.WriteLine($"Hotel  - {price:f2}");
                }
            }
            else if (budget > 1000)
            {
                Console.WriteLine("Somewhere in Europe");
                price = budget * 90 / 100;
                Console.WriteLine($"Hotel - {price:f2}");

            }


            
        }
    }
}