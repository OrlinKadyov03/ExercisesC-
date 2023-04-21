namespace _6thExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int counter = 1;
            double sum = 0;
            double excluded = 0;
            bool isExcluded = false;
            while (counter <= 12)
            {
                double grade =double.Parse(Console.ReadLine());
                if (grade < 4)
                {
                    excluded++;
                }
                if (grade >= 4)
                {
                    sum += grade;
                    counter++;
                }
                if (excluded >=2)
                {
                    isExcluded = true;
                    break;
                }                
            }
            double avg = sum / 12;
            if (isExcluded == false)
            {
                Console.WriteLine($"{name} graduated. Avg grade: {avg:f2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {counter} grade.");
            }

        }
    }
}