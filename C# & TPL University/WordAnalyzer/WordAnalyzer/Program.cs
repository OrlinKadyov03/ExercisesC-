using System.Security.Cryptography.X509Certificates;

namespace WordAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Seductive beauty Jodi loves money." +
                " She is even ready to kill to make her dreams come true." +
                "\r\n\r\nHer target is rich old men. He finds them on the Internet," +
                " charms them and gets rid of them in an extremely exotic way." +
                " And on her heels is a hired killer...\r\n\r\nDetective Roy Grace," +
                " vigilant but haunted by shadows from the past, takes up the case." +
                "\r\n\r\nWill Grace be able to capture Jody before another unsuspecting" +
                " victim falls into her webs?";

            string[] words = text.Split(new char[]{ ' ', '.', ',', '!', '?', ':', ';', '(', ')', '\n', '\r', '\t' },
            StringSplitOptions.RemoveEmptyEntries);

            List<string> validTextWords = new List<string>();

            foreach (string word in words)
            {
                if(word.Length>= 3)
                {
                    validTextWords.Add(word);
                }
                else
                {

                }
            }


            int nums = validTextWords.Count;
            string longestW = FindLongestWord(validTextWords);
            string shortestW = FindShortestWord(validTextWords);
            double AverageW = FindAverageWord(validTextWords);

            static string FindLongestWord(List<string> words)
            {
                string longest = null;
                foreach (string word in words)
                {
                    if(longest == null || word.Length > longest.Length)
                    {
                        longest = word;
                    }
                }
                return longest;
            }
            static string FindShortestWord(List<string> words)
            {
                string shortest = null;
                foreach (string word in words)
                {
                    if (shortest == null || word.Length < shortest.Length)
                    {
                        shortest = word;
                    }
                }
                return shortest;
            }
            static double FindAverageWord(List<string> words)
            {
                double lengthW = 0;
                foreach (string word in words)
                {
                    lengthW += word.Length;
                }
                if(words.Count > 0)
                {
                    return lengthW /words.Count;
                }else
                {
                    return 0;
                }

            }
            Console.WriteLine("Number of words {0}", nums);
            Console.WriteLine("Shortest word {0}", shortestW);
            Console.WriteLine("Longest word {0}", longestW);
            Console.WriteLine("Average word {0:f2}", AverageW);

        }
    }
}