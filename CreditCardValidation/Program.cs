using System;

namespace CreditCardValidation
{
    internal class Program
    {
        public static bool ValidateCreditcard(string userInput)
        {
            var sum = 0;

            bool isValid = false;

            for (var i = userInput.Length - 1; i >= 0; i -= 1)
            {
                var index = userInput.Length - i;

                if (index % 2 == 0)
                {
                    var value = (int)Char.GetNumericValue(userInput[i]) * 2;

                    if (value >= 10)
                    {
                        value -= 9;
                    }
                    sum += value;
                }
                else
                {
                    sum += (int)Char.GetNumericValue(userInput[i]);
                }
            }

            Console.WriteLine(sum);

            if (sum % 10 == 0)
            {
                isValid = true;
            }

            return isValid;
        }

        private static void Main()
        {
            var userInput = string.Empty;

            while (userInput != "x")
            {
                Console.Write("Enter the credit number to verify : ");
                userInput = Console.ReadLine();

                var output = ValidateCreditcard(userInput);
                Console.WriteLine(output);
            }
        }
    }
}