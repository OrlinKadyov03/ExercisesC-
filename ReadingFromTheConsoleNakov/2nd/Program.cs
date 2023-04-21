namespace _2nd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string address = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            int faxNumber = int.Parse(Console.ReadLine());
            string webSite = Console.ReadLine();

            string ManagerName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int managerPhoneNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("The company name is " + name + " and the address is " + address);
            Console.WriteLine("The phone number is " + phoneNumber + " same as the phone ,fax number is "+ faxNumber);
            Console.WriteLine("and the website is " + webSite);

            Console.WriteLine("The manager name is " + ManagerName + " " + lastName + " and the phone number is " + phoneNumber);
        }
    }
}