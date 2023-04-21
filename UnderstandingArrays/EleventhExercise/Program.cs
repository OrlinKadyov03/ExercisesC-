using System.Security.Cryptography.X509Certificates;

namespace EleventhExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дефинирайте стринг и покажете стринга на обратно

            string str = "abcd";
            //char[] chars = str.ToCharArray();
            //Array.Reverse(chars);
            //Console.WriteLine(chars);


            char[] chars = str.ToCharArray();
            for (int i = chars.Length - 1; i > -1; i--)
            {
                Console.Write(chars[i]);
            }

        }
    }
}