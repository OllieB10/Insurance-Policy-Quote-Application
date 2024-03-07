using InsurancePolicyQuote.Logic;
using InsurancePolicyQuoteUI;
using System.Linq;

namespace InsurancePolicyQuoteUI
{
    public class ValidateUserInput : IValidateUserInput
    {
        IBlankLine blankLine = Factory.CreateBlankLine();
        IReadFromConsole readFromConsole = Factory.ReadFromConsole();
        IProposerMessages proposerMesages = Factory.CreateProposerMessages();
        IExitApplication exitApplication = Factory.ExitApplication();
        
        /// <summary>
        /// Checks whether the user has entered a string consisting of only letters and returns true if they have, if they have 
        /// Not returns false.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private bool CheckContainsAlphabeticalCharactersOnly(string input)
        {
            // Check if the string is null or empty, if so return false.
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            // Trim any spaces at the start and end of the string.
            input = input.Trim().Replace(" ", "");
       
            // Check that all values in the string are characters, if not return false.
            if (!input.All(char.IsLetter)) return false;

            // Must be all letters so return true.
            return true;
        }

        private string CheckCaseFormat(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            char[] charArray = new char[input.Length];

            if (CheckContainsAlphabeticalCharactersOnly(input))
            {
                if (char.IsLower(input[0]))
                {
                    charArray[0] = char.ToUpper(input[0]);
                }
                else
                {
                    charArray[0] = input[0];
                }

                for (int i = 1; i < input.Length; i++)
                {
                    charArray[i] = char.ToLower(input[i]);
                }
            }
            else
            {
                return string.Empty;
            }

            input = new string(charArray.ToArray());

            return input;  // or return empty string
        }

        /// <summary>
        /// Function to get a valid string from the user containing only letters.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string GetValidUserInput(string input)
        {
            input = FormatInputString(input);

            //The text entered by the user must be valid.
            while (!CheckContainsAlphabeticalCharactersOnly(input))
            {
                blankLine.CreateBlankLine();
                //Inform the user they have entered invlid information.
                proposerMesages.MessageUser($"The answer you have entered is invalid, it cannot be empty or contain any special characters please enter your answer again(or type 'exit' to quit)");

                input = readFromConsole.ReadInputFromConsole();

                //Check and give the user the option to exit if they so desire.
                exitApplication.CheckAndExitIfRequested(input);

                return FormatInputString(input);
            }

            // Return the valid string.
            return input;
        }

        private bool CheckValidDecimalUserInput(string input)
        {
            // Check if we can parse the amount.
            if (!decimal.TryParse(input, out decimal fineAmount)) return false;

            //return the result.
            return true;
        }

        public decimal GetValidDecimalFromUser(string input)
        {
            // While they do not give us a valid string to parse to a decimal then keep them trapped in the loop until 
            // They either enter a valid parsable string or choose to exit the app.
            while (!CheckValidDecimalUserInput(input))
            {
                // New line
                blankLine.CreateBlankLine();

                //Inform the user they have entered invlid information.
                proposerMesages.MessageUser($"The amount you entered is invalid, it cannot contain any special characters" +
                                                    "please enter your text again(or type 'exit' to quit)");
                // Gets the new input from the user.
                input = readFromConsole.ReadInputFromConsole();

                //Check and give the user the option to exit if they so desire.
                exitApplication.CheckAndExitIfRequested(input);
            }

            bool isDecimalValue = decimal.TryParse(input, out decimal result);

            return result;
        }

        public int GetValidInteger(string input)
        {
            while (!CheckValidInteger(input))
            {
                // New line
                blankLine.CreateBlankLine();

                proposerMesages.MessageUser("You have entered an invalid number, please enter the number again.");

                input = readFromConsole.ReadInputFromConsole();
            }

            int.TryParse(input, out int numberMileage);

            return numberMileage;
        }

        public bool CheckValidInteger(string number)
        {
            bool parsed = int.TryParse(number, out int result);

            if (!parsed)
            {
                return false;
            }

            return true;
        }

        public string FormatInputString(string input)
        {
            input = CheckCaseFormat(input);

            char[] inputCharArray = input.ToCharArray();

            inputCharArray[0] = char.ToUpper(inputCharArray[0]);

            for (int i = 1; i < inputCharArray.Length; i++)
            {
                if (inputCharArray[i - 1] == ' ')
                {
                    inputCharArray[i] = char.ToUpper(inputCharArray[i]);
                }
                else
                {
                    // Do nothing
                }
            }

            input = new string(inputCharArray).Replace(" ", "");

            return input;
        }
    }
}
