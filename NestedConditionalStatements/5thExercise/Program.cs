namespace _5thExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ExamHour = int.Parse(Console.ReadLine());

            int ExamMinute = int.Parse(Console.ReadLine());

            int ArriveHour = int.Parse(Console.ReadLine());

            int ArriveMinute = int.Parse(Console.ReadLine());

            double examH = ExamHour * 60 + ExamMinute;
            double examAr = ArriveHour * 60 + ArriveMinute;

            double difference = examH - examAr;

            double diffHour = 0;

            if (difference == 0 || difference > 0 && difference <= 30)
            {
                Console.WriteLine("On Time");
                if (difference != 0)
                {
                    Console.WriteLine("{0},minutes before the start",difference);
                }
            }
            else if (difference > 30)
            {
                Console.WriteLine("Early");
                while (difference > 59)
                {
                    diffHour++;
                    difference -= 60;
                }
                if (diffHour > 0)
                {
                    Console.WriteLine("{0}:{1:00} hours before the start",diffHour,difference);
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
                    diffHour++;
                    difference -= 60;
                }
                if (difference > 0)
                {
                    Console.WriteLine("{0}:{1:00} hours before the start",diffHour,difference);
                }
                else
                {
                    Console.WriteLine("{0} minutes before the start",difference);
                }
            }
         
            
        }
    }
}