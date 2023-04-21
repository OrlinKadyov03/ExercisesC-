namespace _3rdExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int countNights = int.Parse(Console.ReadLine());
            double priceforonenightStudio = 0;
            double priceforonenightApartment = 0;
            double priceStaying = 0;

            double newpriceStudio = 0;
            double newpriceApartment = 0;

            if (month == "may" || month == "october")
            {
                if (countNights > 14)
                {
                    priceforonenightApartment = countNights * 65;
                    newpriceApartment = priceforonenightApartment - (priceforonenightApartment * 10 / 100);
                    Console.WriteLine("Apartment:{0:f2} lv.", newpriceApartment);
                    priceforonenightStudio = countNights * 50;
                    newpriceStudio = priceforonenightStudio - (priceforonenightStudio * 30 / 100);
                    Console.WriteLine("Studio:{0:f2} lv.", newpriceStudio);
                }
                else if (countNights > 7)
                {
                    priceforonenightApartment = countNights * 65;
                   Console.WriteLine("Apartment:{0:f2} lv.", priceforonenightApartment);
                   priceforonenightStudio = countNights * 50;
                    newpriceStudio = priceforonenightStudio - (priceforonenightStudio * 5 / 100);
                    Console.WriteLine("Studio:{0:f2} lv.", newpriceStudio);
                }
                else
                {
                    priceforonenightApartment = countNights * 65;
                    Console.WriteLine("Apartment:{0:f2} lv.", priceforonenightApartment);
                    priceforonenightStudio = countNights * 50;
                    Console.WriteLine("Studio:{0:f2} lv.", priceforonenightStudio);
                }

               
            }
            else if (month == "june" || month == "september")
            {
                if (countNights <= 14)
                {
                    priceforonenightApartment = countNights * 68.70;
  
                    Console.WriteLine("Apartment:{0:f2} lv.", priceforonenightApartment);
                    priceforonenightStudio = countNights * 75.20;

                    Console.WriteLine("Studio:{0:f2} lv.", priceforonenightStudio);
                }
                else if (countNights > 14)
                {
                    priceforonenightApartment = countNights * 68.70;
                    newpriceApartment = priceforonenightApartment - (priceforonenightApartment * 10 / 100);
                    Console.WriteLine("Apartment:{0:f2} lv.", newpriceApartment);
                    priceforonenightStudio = countNights * 75.20;
                    newpriceStudio = priceforonenightStudio - (priceforonenightStudio * 20 / 100);
                    Console.WriteLine("Studio:{0:f2} lv.", newpriceStudio);
                }
            }
            else if (month == "july" || month == "august")
            {
                if (countNights <= 14)
                {
                    priceforonenightApartment = countNights * 77;

                    Console.WriteLine("Apartment:{0:f2} lv.", priceforonenightApartment);
                    priceforonenightStudio = countNights * 76;

                    Console.WriteLine("Studio:{0:f2} lv.", priceforonenightStudio);
                }
                else if (countNights > 14)
                {
                    priceforonenightApartment = countNights * 77;
                    newpriceApartment = priceforonenightApartment - (priceforonenightApartment * 10 / 100);
                    Console.WriteLine("Apartment:{0:f2} lv.", newpriceApartment);
                    priceforonenightStudio = countNights * 76;
                    Console.WriteLine("Studio:{0:f2} lv.", newpriceStudio);
                }
            }
        }
    }
}