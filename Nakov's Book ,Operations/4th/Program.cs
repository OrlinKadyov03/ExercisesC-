namespace _4th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b = 0b00001000; 
            if ((b & 0b00000100) == 0b00000100) 
            {
                Console.WriteLine("The third bit is 1.");
            }
            else
            {
                Console.WriteLine("The third bit is 0.");
            }
        }
    }
}