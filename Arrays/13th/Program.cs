namespace _13th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter height: ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter width: ");
            int width = int.Parse(Console.ReadLine());

            int a = 0;

            for (int i = 1; i <= height; i++)
            {
                Console.Write("{0} ",i);

                a += i;
                for (int j = 1; j < width; j++)
                {
                    a += j;
                    Console.Write("{0} ",a);
                }

                a = 0;
                Console.WriteLine();
            }
         }
    }
}