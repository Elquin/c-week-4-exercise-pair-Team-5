using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public class StringCalculatorKata
    {
        
        public int EmptyString(string value)
        {
            if (value == "")//First test will test for and empty string and return "0"
            {
                return 0;
            }
            else if (value.Length == 1) //If only a number is provided in the string, then the number should be returned.
            {
                return int.Parse(value);
            }
            else
            {
                char[] delimiterChars = { ',', '\n' };
                string[] valueString = new string[value.Length];
                string[] newString = value.Split(delimiterChars);

                int sum = 0;
                foreach (string word in newString)
                {
                    int i = int.Parse(word);
                    sum += i;
                }
                return sum;
            }
        }
    }
}
