using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public class StringCalculatorKata
    {
        public int EmptyString(string value)
        {
            if (value == "")
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }

    public class KataFizzBuzz : StringCalculatorKata
    {
    }
}
