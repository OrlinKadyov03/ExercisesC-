namespace _5thExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int counter = 1;

            double sum = 0;

            double exCluded = 0;
            bool isExcluded = false;

            while (counter <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4)
                {
                    exCluded++;
                }
                else if (grade >= 4)
                {
                    sum += grade;
                    counter++;
                }
     
                if (exCluded >= 2)
                {
                    isExcluded = true;
                    break;
                }
                
            }


            if (isExcluded == false)
            {
                double average = sum / 12;

                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {counter} grade.");
            }

        }
    }
}