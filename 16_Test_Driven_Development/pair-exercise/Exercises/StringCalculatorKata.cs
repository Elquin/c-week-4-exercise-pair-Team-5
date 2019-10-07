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
                string[] valueString = new string[value.Length];
                value.Split(new Char[] { ',', '\n' });

                int i = 0;
                foreach (string word in valueString)
                {
                    i = int.Parse(word);
                }

                int sum = i;
                for (int n = 1; n < value.Length; n++)
                {
                    sum += value[n];
                }
                return sum;
            }
        }
    }
}
