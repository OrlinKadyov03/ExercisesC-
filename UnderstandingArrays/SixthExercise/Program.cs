namespace SixthExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Потребителя въвежда на първи ред N и след това N на брой числа, след което
            //въвежда M и M на брой числа.Програмата записва първите числа в един
            //масив, а вторите числа в друг масив и също така създава трети масив с N +M
            //на брой числа комбинира числата от двата масива. След това изписва на
            //конзолата първият масив, вторият масив и третият масив.

            Console.WriteLine("Enter the size for the first array");

            int n = int.Parse(Console.ReadLine());

            int[] N = new int[n];


            
            for (int i = 0; i < n; i++)
            {
                N[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Enter the size for the second array");

            int nTwo = int.Parse(Console.ReadLine());

            int[] M = new int[nTwo];

            for (int i = 0; i < nTwo; i++)
            {
                M[i] = int.Parse(Console.ReadLine());
            }
            int[] thirdOne = N.Concat(M).ToArray();

            foreach (var itemOne in N)
            {
                Console.Write("[{0}] ",itemOne);
            }
            Console.WriteLine();
            foreach (var itemTwo in M)
            {
                Console.Write("[{0}] ", itemTwo);
            }
            Console.WriteLine();
            foreach (var item in thirdOne)
            {
                Console.Write("[{0}] ",item);
            }


        }
    }
}