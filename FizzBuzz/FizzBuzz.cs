using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzClass
    {
        public static string FizzBuzzMethod(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "fizzbuzz";
            }
            if (number % 3 == 0)
            {
                return "fizz";
            }
            if (number % 5 == 0)
            {
                return "buzz";
            }
            else return "";
        }
    }
}
