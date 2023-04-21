using System.Diagnostics.CodeAnalysis;

namespace _4th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 2;
            double b = 4;
            double c = 1;

            if (a < b)
            {
                if (a < c)
                {
                    a = a + c;
                    c = a - c;
                    a = a - c;

                    if (b > c)
                    {
                        a = a + b;
                        b = a - b;
                        a = a - b;
                    }
                }
                else if (a >=c)
                {
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }
            }
            else if (a==b)
            {
                if (a<c)
                {
                    a = a + c;
                    c = a - c;
                    a = a - c;
                }
            }
            else
            {
                if (b <c)
                {
                    b = b + c;
                    c = b - c;
                    b = b - c;
                }
                if (a < b)
                {
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }
            }
            Console.WriteLine("{0},{1},{2}",a ,b,c);
            Console.WriteLine();


             
        }
    }
}