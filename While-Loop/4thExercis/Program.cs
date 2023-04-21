namespace _4thExercis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int steps = 0;
            while (steps < 10000)
            {
                string cmd = Console.ReadLine();

                if (cmd == "Going home")
                {
                    steps += int.Parse(Console.ReadLine());
                    if (steps >= 10000)
                    {
                        Console.WriteLine("Goal reached,good job!!");
                    }
                    else
                    {
                        int difff = 10000 - steps;
                        Console.WriteLine($"{difff} steps more to go.");
                    }
                    break;
                }
                else
                {
                    steps += int.Parse(cmd);
                    if (steps >= 10000)
                    {
                        Console.WriteLine("Goal reached,good job!");
                    }
                }
            }
        }
    }
}