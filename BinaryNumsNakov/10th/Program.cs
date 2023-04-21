namespace _10th
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string binaryString = "10101"; // example binary string
            int decimalNumber = BinaryToDecimal(binaryString); // convert binary string to decimal number
            Console.WriteLine("The decimal representation of {0} is {1}.", binaryString, decimalNumber); // output the decimal number
        }

        static int BinaryToDecimal(string binaryString)
        {
            int decimalNumber = 0;
            for (int i = 0; i < binaryString.Length; i++)
            {
                decimalNumber = 2 * decimalNumber + (binaryString[i] - '0');
            }
            return decimalNumber;
        }
    }
}