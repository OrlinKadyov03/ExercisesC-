namespace _9th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
    

            bool isInside = (x * x + y * y <= 5 );
            bool isOutside = (x < -1 || y > 5) && (y<1 || y>5);
            
            Console.WriteLine("The point O({0},{1}) is inside K((0,0),5)?: {2}",x,y,isInside);
            Console.WriteLine("The point O({0},{1}) is outside rectangle ((-1,1),(5,5)?: {2}", x, y, isOutside);
        }
    }
}