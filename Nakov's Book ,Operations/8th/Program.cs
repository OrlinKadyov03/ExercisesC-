namespace _8th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool isInside = (x * x + y * y <= 5) ? true:false;
            Console.WriteLine("The point O({0},{1}) is inside K((0,0),5)?: {2}",x,y, isInside);
            
        }
    }
}