using InsurancePolicyQuote.Logic;

namespace InsurancePolicyQuoteUI
{
    public class YesNoInputHandler : IYesNoInputHandler
    {
        IBlankLine blankLine = Factory.CreateBlankLine();       
        IProposerMessages proposerMessages = Factory.CreateProposerMessages();
        IReadFromConsole readFromConsole = Factory.ReadFromConsole();
        IExitApplication exitApplication = Factory.ExitApplication();
        IValidateUserInput validateUserInput = Factory.ValidateUserInput();

        public string GetYesOrNoValue(string input)
        {
            input = validateUserInput.GetValidUserInput(input);

            string changedInput = input.ToLower();

            while (!changedInput.StartsWith("yes") && !changedInput.StartsWith("no"))
            {
                // Empty line
                blankLine.CreateBlankLine();

                // Inform the user they must enter yes or no and nothing else.
                proposerMessages.MessageUser("That is an invalid answer, please enter Yes or No followed by the enter key.");
                changedInput = readFromConsole.ReadInputFromConsole();

                changedInput = changedInput.ToLower();

                //Check and exit if desired.
                exitApplication.CheckAndExitIfRequested(changedInput);
            }

            //return the valid word of Yes or No.
            return changedInput;
        }

        public bool ReturnTrueOrFalse(string input)
        {
            string yesOrNoValue = GetYesOrNoValue(input);

            if (yesOrNoValue.StartsWith("yes"))
            {
                return true;
            }
            else if (yesOrNoValue.StartsWith("no"))
            {
                return false;
            }
            else
            {
                return false;
            }           
        }
    }
}
