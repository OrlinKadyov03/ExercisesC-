using System.Runtime.InteropServices;

namespace _12th
{
    internal class Program
    {
        static void Main( )
        {
            int numOne = 0 ,numTwo = 1, numThree;
            Console.WriteLine("{0} {1}",numOne,numTwo);
            for (int i = 2; i <100; ++i)
            {
                numThree = numOne + numTwo;
                Console.WriteLine("{0}",numThree);
                numOne = numTwo;
                numTwo = numThree;

            }
        }
    }
}