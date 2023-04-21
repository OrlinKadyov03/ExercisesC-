namespace _3rd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool arequeal = true;
            int oneArray = Convert.ToChar(Console.ReadLine());
            int twoArray = Convert.ToChar(Console.ReadLine());

            char[] one = new char[oneArray];
            char[] two = new char[twoArray];

            if (one.Length > two.Length)
            {
                Console.WriteLine("Second array is lexigraphally first");
            }
            else if (one.Length < two.Length)
            {
                Console.WriteLine("First array is lexigraphally first");
            }


            for (int i = 0; i < one.Length; i++)
            {
                if (one[i] < two[i])
                {
                    Console.WriteLine("First array is lexigraphally first");
                    arequeal = false;
                    break;
                }

                if (one[i] > two[i])
                {
                    Console.WriteLine("Second array is lexigraphally first");
                    arequeal = false;
                    break;
                }
            }
            if (arequeal) Console.WriteLine("Both are lexigrapahally equal");
        }
        
    }
}