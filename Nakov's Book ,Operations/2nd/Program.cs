namespace _2nd
{
    internal class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            if (num % 5 == 0 && num % 7 ==0)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Error!");
            }

            
        }
    }
}