namespace FifthExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Потребителя въвежда N. След това въвежда N пъти име и години. Като
            //данните се въвеждат в два масива. Като използвате foreach напишете
            //алгоритъм за намирането на най – малкия въведен човек и покажете неговото
            //име и години на конзолата

            Console.WriteLine("Enter count of persons ");
            int n = int.Parse(Console.ReadLine());
            int[] years = new int[n];
            string[] names = new string[n];
       
            int min = int.MaxValue;
            string youngetsName = "";
            for (int i = 0; i < years.Length; i++)
            {
                Console.WriteLine("Enter Person name\nand age");
                Console.Write("Name = "); names[i] = Console.ReadLine();
                Console.Write("Years = "); years[i] = int.Parse(Console.ReadLine());
         
            }
            foreach (var item in years)
            {
                if (item < min)
                {
                    min = item;
                   
                }
            }
            foreach (string name in names)
            {
                if (years[Array.IndexOf(years,min)] == years[Array.IndexOf(names,name)])
                {
                    youngetsName = name;
                }
            }
            Console.WriteLine("Name of the youngest Person is {0} and his years are {1}",youngetsName,min);
        }
    }
}