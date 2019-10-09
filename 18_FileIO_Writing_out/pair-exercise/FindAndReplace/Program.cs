using System;
using System.IO;
using System.Collections.Generic;

namespace FindAndReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Ask the user for the search phrase
            //2. Ask the user for a replace phrase
            //2. Ask the user for the file path
            //3. Open the file
            //4. Loop through each line in the file
            //5. If the line contains the search string, replace it with the new search phrase
            //6. Create a copy in the destination file path.

            Console.WriteLine("What is the search phrase you are looking for?");
            string searchPhrase = Console.ReadLine();

            Console.WriteLine("What is the replace phrase?");
            string replacePhrase = Console.ReadLine();

            Console.WriteLine("What is the fully qualified name of the file that should be searched?");
            string fileName = Console.ReadLine();

            Console.WriteLine("What would you like the name of the new file to be?");
            string userName = Console.ReadLine();

            try
            {
                List<string> lines = new List<string>();
                using (StreamReader stream = new StreamReader(fileName))
                {
                    while (!stream.EndOfStream)
                    {
                        string line = stream.ReadLine();
                        lines.Add(line);
                    }
                }

                string outPath = ("../../../../" + userName + ".txt");
                using (StreamWriter sw = new StreamWriter(outPath))
                {
                    string modifiedLine = "";
                    foreach (string line in lines)
                    {
                        modifiedLine = line.Replace(searchPhrase, replacePhrase);
                        sw.WriteLine(modifiedLine);
                    }
                }
            }
            catch (IOException e)
            {
                Console.Write("An error occurred. Please try again." + e.Message);
            }
        }
    }
}

            // C:\Users\KKimes\git\c-week-4-exercise-pair-team-5\18_FileIO_Writing_out\pair-exercise\alices_adventures_in_wonderland.txt }
