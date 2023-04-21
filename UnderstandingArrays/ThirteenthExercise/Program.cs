namespace ThirteenthExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Потребителя въвежда число. Програмата проверява дали даденото число е
            //просто.

            int n = int.Parse(Console.ReadLine());
            bool isPrime = true;
            int num = n / 1;
            for (int i = 2 ; i < num; i++)
            {
                if (n % i ==0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("The number is prime");
            }
            else 
            {
                Console.WriteLine("The number is not prime");
            }
    
        }
    }
}