namespace _5thExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());

            while (steps < 10000)
            {
                string command = Console.ReadLine();
                if (command == "Going home")
                {
                    steps += int.Parse(Console.ReadLine());
                    if (steps >= 10000)
                    {
                        Console.WriteLine("Good you reached your goal!");
                    }
                    else
                    {
                        int diff = 10000 - steps;
                        Console.WriteLine($"{diff} steps more to go.");
                    }
                    break;
                }
                else
                {
                    steps += int.Parse(command);
                    if (steps >= 10000)
                    {
                        Console.WriteLine("Good you reached your goal!");
                    }
                }
            }
        }
    }
}