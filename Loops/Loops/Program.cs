namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favBook = Console.ReadLine();
            int countbooks = int.Parse(Console.ReadLine());
            int count = 0;
            while (true)
            {
                string nextbookName = Console.ReadLine();
                count++;
                if (nextbookName == favBook)
                {
                    Console.WriteLine($"You checked {count - 1} books and found it.");
                    break;
                }
                else if (count == countbooks)
                {
                    Console.WriteLine("The book you search is not here.");
                    Console.WriteLine($"You checked {count} books");
                    break;
                }

               
            }


        }
    }
}