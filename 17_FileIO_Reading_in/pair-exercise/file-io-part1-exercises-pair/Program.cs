using System;
using System.IO;

namespace file_io_part1_exercises_pair
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // asks for a filesystem path for a text file
                Console.WriteLine("Please enter the file path: ");
                string input = Console.ReadLine();

                //"C:\Users\RHolland\git\c-week-4-exercise-pair-team-5\17_FileIO_Reading_in\pair-exercise\alices_adventures_in_wonderland.txt"

                using (StreamReader stream = new StreamReader(input))
                {
                    int numberOfWords = 0;
                    int numberOfSentences = 0;
                    while (!stream.EndOfStream)
                    {
                        string wholeDoc = stream.ReadToEnd();
                        char[] delimiterChars = { '.', '!', '?' };
                        string[] wordsSplit = wholeDoc.Split(" ");
                        string[] sentenceSplit = wholeDoc.Split(delimiterChars);
                        numberOfWords += wordsSplit.Length;
                        numberOfSentences += sentenceSplit.Length;

                    }
                    Console.WriteLine($"Number of words equals: {numberOfWords}");
                    Console.WriteLine($"Number of sentences equals: {numberOfSentences}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter a valid path.");
            }
            Console.ReadLine();
        }
    }
}
