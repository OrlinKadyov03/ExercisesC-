namespace UnderstandingArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {1,2,3,4,5}; 
            //Array size
            int length = array.Length;
            //Declare and create reversed array
            int[] reversed = new int[length];

            //initialise the reversed array
            for (int index = 0; index < length; index++)
            {
                reversed[length - index - 1] = array[index];
            }
            //Print the reversed array
            for (int index = 0; index < length; index++)
            {
                Console.Write(reversed[index]);
            }
        }
    }
}