namespace TenthExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дефинирайте масив със стойности по избор и проверете дали масива е
            // подреден възходящо.
            
            int[] arr = new int[] { 2,3,4,5,6,7 };
            bool isAssceding = false;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    isAssceding = false;
                    break;
                }
                if (arr[i] < arr[i +1])
                {
                    isAssceding = true;
                }
            }
            if (isAssceding == true)
            {
                Console.WriteLine("Is assceding");
            }
            else if (isAssceding == false)
            {
                Console.WriteLine("Is not assceding");
                
            }

        }
    }
}