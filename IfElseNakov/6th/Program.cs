using System.Net.Http.Headers;

namespace _6th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 0:
                    Console.WriteLine("Enter int value");
                    int num = int.Parse(Console.ReadLine());
                    num++;
                    Console.WriteLine("Value you entered +1 ,{0}", num);
                    break;
                case 1:
                    Console.WriteLine("Enter double value");
                    double number = double.Parse(Console.ReadLine());
                    number++;
                    Console.WriteLine("Double you entered +1 ,{0}",number);
                    break;
                case 2:
                    Console.WriteLine("Enter string");
                    string console = Console.ReadLine();
                    Console.WriteLine(console + "*");
                    break;
            }
        }
    }
}