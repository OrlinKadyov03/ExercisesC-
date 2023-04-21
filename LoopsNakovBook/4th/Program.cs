namespace _4th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = 0;
            int n2 = 1;
            int n3 = 0;
            int sum = 0;
            Console.Write(n1 + " "+n2+" ");
            for (int i = 1; i <=n ; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;

            }
  
        }
    }
}