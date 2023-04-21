namespace _3rdExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNum = int.MinValue;
            int minNum = int.MaxValue;
            string console = Console.ReadLine(); 

            while (console != "END")
            {
                int num = int.Parse(console);
                if (num < minNum)
                {
                    minNum = num;
                }
                else if (num > maxNum)
                {
                    maxNum = num;
                }
                console = Console.ReadLine();
            }
            Console.WriteLine($"maxNum {maxNum}");
            Console.WriteLine($"minNum {minNum} ");
        }
    }
}