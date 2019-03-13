using System;

namespace FizzBuzz
{
    public class FizzBuzzKata
    {
        public string ProcessNumber(int number)
        {
            string result = string.Empty;

            if (number < 1 || number > 100)
            {
                throw new ArgumentException($"Number '{number}' not in the allowed range (1-100)");
            }
            
            if (number % 3 == 0)
            {
                result += "Fizz";
            }

            if (number % 5 == 0)
            {
                result += "Buzz";
            }

            if (string.IsNullOrWhiteSpace(result))
            {
                result = number.ToString();
            }

            return result;
        }
    }
}
