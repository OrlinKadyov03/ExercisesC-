namespace LoopsForNakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                var numtwo = int.Parse(Console.ReadLine());
                var sum = numtwo + num;
                if (sum > max)
                {
                    max = sum;
                }
                if (sum < min)
                {
                    min = sum;
                }
            }
            if (max == min)
            {
                Console.WriteLine("Yes,sum = {0}",max);
            }
            else if (max != min)
            {
                Console.WriteLine("No,value = {0}",max - min );
            }
  

           

        }
        
    }
}