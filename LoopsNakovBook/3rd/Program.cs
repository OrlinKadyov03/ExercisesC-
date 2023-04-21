namespace _3rd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <=14; i++)
            {

                for (int color = 1; color < 5; color++)
                {
                    if (i < 10)
                    {
                        Console.Write("  ",i);
                    }
                    if (i == 10)
                    {
                        Console.Write("  ",i);
                    }
                    if (i == 11)
                    {
                        Console.Write("  J");
                    }
                    if (i == 12)
                    {
                        Console.Write("  Q");
                    }
                    if (i == 13)
                    {
                        Console.Write("  K");
                    }
                    if (i == 14)
                    {
                        Console.Write("  A");
                    }
                    if (color == 1)
                    {
                        Console.Write("diamond  ");
                    }
                    if (color == 2)
                    {
                        Console.Write("heart  ");
                    }
                    if (color == 3)
                    {
                        Console.Write("spade  ");
                    }
                    if (color == 4)
                    {
                        Console.Write("clubs  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}