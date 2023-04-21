using System.Data;

namespace _4thExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
            string str = Console.ReadLine();

            int maxnum = int.MinValue;
            int minnum = int.MaxValue;

            while (str != "END")
            {
                int ou = int.Parse(str);

                if (ou > maxnum)
                {
                    maxnum = ou;
                }
                else if (ou < minnum)
                {
                   minnum = ou;
                }

                str = Console.ReadLine();
            }
            
            Console.WriteLine(maxnum);
            Console.WriteLine(minnum);
        }
    }
}