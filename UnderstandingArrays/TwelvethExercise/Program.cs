namespace TwelvethExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дефинирайте масив с няколко елемента. Потребителя въвежда елемент и
            //програмата проверява дали елемента съществува или не

            int[] array = new int[] { 1, 2, 3, 5, 6, 8, 19, 10, 21 };
            bool isTrue = false;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == n)
                {
                    isTrue = true;           
                }            
            }
            if (isTrue == true)
            {
                Console.WriteLine("The elements exists");
            }
            else if (isTrue == false)
            {
                Console.WriteLine("The element does't exists");
            }
        
        }
    }
}