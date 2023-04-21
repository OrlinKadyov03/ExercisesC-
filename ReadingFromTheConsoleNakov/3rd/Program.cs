namespace _3rd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            Console.WriteLine("frictional positve number");
            double two = double.Parse(Console.ReadLine());
            double frictionalPositive = two % 1;
            Console.WriteLine("b frictional negative number");
            double three = double.Parse(Console.ReadLine());
            double frictionalNegative = Math.Abs(three % 1);

            Console.WriteLine(" " + one
                + " " + "**********" + " " + $"{frictionalPositive:f2}"
                + " " + "**********" + " " + $"{frictionalNegative:f2}" + " "
                ) ;
        }
    }
}