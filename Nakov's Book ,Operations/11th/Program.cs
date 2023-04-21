namespace _11th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());

            int a = num / 1000;
            int b = (num / 100)%10;
            int c = (num / 10)%10;
            int d = num % 10;

            Console.WriteLine(a);
            Console.WriteLine(c);
            Console.WriteLine(b);
            Console.WriteLine(d);

            int sum = a + b + c + d;
            Console.WriteLine($"The sum is {sum}");

            


            


            
        }
    }
}