namespace _6thExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int freeSpace = width * length * height;

            int totalSpace = 0;

            int diffSpace = 0;

            string command = Console.ReadLine();
            while (command != "Done" )
            {
                int countPackage = int.Parse(command);

                totalSpace += countPackage;
                diffSpace = Math.Abs(totalSpace - freeSpace);

                if (totalSpace >= freeSpace)
                {
                    Console.WriteLine($"No more free space! you need {diffSpace} cubic meters more.");
                    break;
                }
                command = Console.ReadLine();
                
            }
            if (command == "Done")
            {
                Console.WriteLine($"{diffSpace} cubic meters left.");
            }
        }
    }
}