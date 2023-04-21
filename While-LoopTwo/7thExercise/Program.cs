namespace _7thExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lengh = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int freeSpace = width * lengh * height;
            int totalSpace = 0;
            int spaceDiff = 0;
            while (command != "Done")
            {
                int cartoonSpace = int.Parse(command);

                totalSpace += cartoonSpace;
                spaceDiff = Math.Abs(totalSpace - freeSpace);

                if (totalSpace >= freeSpace)
                {
                    Console.WriteLine($"No more free space! You need {spaceDiff} cubic meters more.");
                    break;
                }
                command = Console.ReadLine();

            }
            if (command == "Done")
            {
                Console.WriteLine($"{spaceDiff} cubic meters left.");
            }


        }
    }
}