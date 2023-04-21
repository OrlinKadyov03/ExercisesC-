namespace _4th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 1, tempCount = 1, number = 0;
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i <array.Length; i++)
            {
                Console.WriteLine("Enter element {0} ",i);
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] == array[i+1])
                {
                    tempCount++;
                }
                else
                {
                    tempCount = 1;
                }

                if (tempCount > count)
                {
                    count = tempCount;
                    number = array[i];
                }
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("-----{0}",number);
            }
        }
    }
}