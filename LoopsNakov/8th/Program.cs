namespace _8th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < type.Length; i++)
            {
                if (type[i] == 'a')
                {
                    sum += 1;
                }
                else if (type[i] == 'e')
                {
                    sum += 2;
                }
                else if (type[i] == 'i')
                {
                    sum += 3;
                }
                else if (type[i] == 'o')
                {
                    sum += 4;
                }
                else if (type[i] == 'u')
                {
                    sum += 5;
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}