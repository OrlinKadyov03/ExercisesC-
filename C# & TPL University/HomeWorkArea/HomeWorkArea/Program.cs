using System;
using System.Threading;

namespace HomeWorkArea
{
    public class Program
    {
        static (string Name, string SecurityLevel) agent = ("", "");

        static void Main(string[] args)
        {
            Random random = new Random();
            int currentFloor = 1;
            Console.WriteLine($"Current floor {currentFloor}");

            for (int i = 0; i < random.Next(1, 20); i++)
            {
                Console.WriteLine("Agent entered the elevator.");
                Console.WriteLine();

                Thread agentThread = new Thread(() => GenerateAgent());
                agentThread.Start();
                agentThread.Join();

                Thread.Sleep(1000);

                Thread elevatorThread = new Thread(() => PressElevator(agent.SecurityLevel, currentFloor));
                elevatorThread.Start();
                elevatorThread.Join();

                Console.WriteLine("............................");
            }

            Console.WriteLine("The base is closed!");
        }

        public static void GenerateAgent()
        {
            Entities entities = new Entities();
            var random = new Random();
            agent.Name = entities.agentNames[random.Next(entities.agentNames.Count)];
            agent.SecurityLevel = entities.agentsClearenceLevels[random.Next(entities.agentsClearenceLevels.Count)];
            Console.WriteLine($"Agent name: {agent.Name}");
            Console.WriteLine($"Security level: {agent.SecurityLevel}");
        }

        public static bool Check(string securityLevel, int floor)
        {
            bool securityCheckPassed = false;

            Console.WriteLine();

            switch (securityLevel)
            {
                case "Confidential":
                    securityCheckPassed = (floor == 1);
                    break;

                case "Secret":
                    securityCheckPassed = (floor == 1 || floor == 2);
                    break;

                case "Top-Secret":
                    securityCheckPassed = (floor >= 1 && floor <= 4);
                    break;
            }

            if (securityCheckPassed)
            {
                Console.WriteLine($"Access granted! The elevator door glides open, ushering {agent.Name} out of the cabin.");
            }
            else
            {
                Console.WriteLine("Access denied! Please select a different floor for your destination.");
            }

            Console.WriteLine();

            return securityCheckPassed;
        }

        private static int GetSelectedFloor()
        {
            Random rnd = new Random();
            return rnd.Next(1, 5);
        }

        private static void MoveToFloor(int currentFloor, int selectedFloor)
        {
            for (int j = 0; j < Math.Abs(selectedFloor - currentFloor); j++)
            {
                Console.WriteLine();
                Console.Write("-");
                Thread.Sleep(1000);
            }
        }

        public static void PressElevator(string securityLevel, int currentFloor)
        {
            int selectedFloor;
            bool securityCheckPassed;

            do
            {
                Console.WriteLine("Choose floor: G(1), S(2), T1(3), T2(4)");
                selectedFloor = GetSelectedFloor();

                Console.Write($"Arriving at the floor {selectedFloor} ");
                MoveToFloor(currentFloor, selectedFloor);

                Console.WriteLine();
                currentFloor = selectedFloor;
                Console.WriteLine($"Arrived at floor {currentFloor}");

                securityCheckPassed = Check(securityLevel, selectedFloor);

            } while (!securityCheckPassed);
        }

    }
}
