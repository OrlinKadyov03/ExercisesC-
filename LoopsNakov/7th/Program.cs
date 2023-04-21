namespace _7th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
        
            int even = 0;
            int odd = 0;
            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (i%2 ==0)
                {
                    even += number; 
                    
                }
                else
                {
                    odd += number;
                }
            }
            if (even == odd)
            {
                Console.WriteLine("Yes the sum = "+even);
            }
            else 
            {
                int diff = odd - even;
                Console.WriteLine("No the diff = "+Math.Abs(diff));
            }
     
        }
    }
}