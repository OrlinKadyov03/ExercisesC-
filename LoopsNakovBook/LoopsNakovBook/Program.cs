namespace LoopsNakovBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            int n = int.Parse(Console.ReadLine());  
            for (int i = 1; i <=n ; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % (3*7) == 0)
                {
              
                }
                else
                {
                    Console.WriteLine(i);
                }
               
            }
            
        }
    }
}