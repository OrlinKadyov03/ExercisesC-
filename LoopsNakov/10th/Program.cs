using System.Globalization;

namespace _10th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double sum = 0;
            double min = double.MaxValue;
            double max = double.MinValue;
            double minEven = double.MaxValue;
            double maxEven = double.MinValue;
            double even = 0;
            double odd = 0;

            for (double i = 1; i <= n; i++)
            {
                var num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    even += num;
                    if (num < minEven)
                    {
                        minEven = num;
                    }

                    if (num > maxEven)
                    {
                        maxEven = num;
                    }

                }
                else
                {
                    odd += num;
                    if (num < min)
                    {
                        min = num;
                    }

                    if (num > max)
                    {
                        max = num;
                    }

                }
            }

            Console.WriteLine("OddSum={0}", odd);


            if (min == double.MaxValue)
            {

                Console.WriteLine("OddMin=No");
            }
            else
            {
                Console.WriteLine("OddMin={0}", min);
            }
            if (max == double.MinValue)
            {

                Console.WriteLine("OddMax=No");
            }
            else
            {
                Console.WriteLine("OddMax={0}", max);
            }
            Console.WriteLine("EvenSum={0}", even);
            if (minEven == double.MaxValue)
            {

                Console.WriteLine("EvenMin=No");
            }
            else
            {
                Console.WriteLine("EvenMin={0}", minEven);
            }
            if (maxEven == double.MinValue)
            {

                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMax={0}", maxEven);
            }
        }















    }
}