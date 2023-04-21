namespace _4thExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourofExam = int.Parse(Console.ReadLine());

            int minuteofExam = int.Parse(Console.ReadLine());

            int arriveHour = int.Parse(Console.ReadLine());

            int minuteArrive = int.Parse(Console.ReadLine());

            int totalExamMinutes = hourofExam * 60 + minuteofExam;
            int totalArriveMinutes = arriveHour * 60 + minuteArrive;

            int difference = totalExamMinutes - totalArriveMinutes;

            int diffhours = 0;

            if (difference == 0 || difference > 0 && difference <= 30)
            {
                Console.WriteLine("On Time");
                if (difference != 0)
                {
                    Console.WriteLine("{0},minutes before the start", difference);
                }
            }
            else if (difference > 30)
            {
                Console.WriteLine("Early");
                while (difference > 59)
                {
                    diffhours++;
                    difference -= 60;
                }
                if (diffhours > 0)
                {
                    Console.WriteLine("{0}:{1:00} hours before the start",diffhours,difference);
                }
                else
                {
                    Console.WriteLine("{0} minutes before the start",difference);
                }
            }
            else
            {
                Console.WriteLine("Late");
                while (difference > 59)
                {
                    diffhours++;
                    difference -= 60;
                }

                if (diffhours >0)
                {
                    Console.WriteLine("{0}:{1:00} hours after the start", diffhours, difference);
                }
                else
                {
                    Console.WriteLine("{0} minutes after the start", difference);
                }
            }

        }
    }
}