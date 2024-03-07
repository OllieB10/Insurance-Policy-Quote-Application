using InsurancePolicyQuote.Logic;
using InsurancePolicyQuoteUI;
using System.Collections.Generic;

namespace InsurancePolicyQuoteUI
{
    public class MotorConvictionsValidator : IMotorConvictionsValidator
    {
        IProposerMessages proposerMessages = Factory.CreateProposerMessages();
        IReadFromConsole readFromConsole = Factory.ReadFromConsole();
        IExitApplication exitApplication = Factory.ExitApplication();

        public bool CheckMotoringConvictionsValidValue(string usersAnswer)
        {
            if (usersAnswer.Length != 1)
                return false;

            bool isParsed = int.TryParse(usersAnswer, out int key);

            if (!isParsed)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int ConvertUsersMotoringConvictions(string usersAnswer)
        {
            while (!CheckMotoringConvictionsValidValue(usersAnswer))
            {
                proposerMessages.MessageUser($"The value you entered is invalid, please choose a number next to" +
                                                   "the Criminal Conviction or enter 0 if you have no criminal convictions or enter 9" +
                                                           "if it isnt an option. ");

                usersAnswer = readFromConsole.ReadInputFromConsole();

                if (usersAnswer.ToLower() == "exit")
                {
                    exitApplication.Exit();
                }
            }

            int crimKey = int.Parse(usersAnswer);

            return crimKey;
        }

        public string MotoringConvictions(int usersAnswer)
        {
            // Define our criminal convictions and the keys to get them
            var crimConvicValues = new Dictionary<int, string>
            {
                { 1,"MURDER"},
                { 2, "ATTEMPTED MURDER"},
                { 3, "MANSLAUGHTER"},
                { 4, "RAPE"},
                { 5, "KIDNAPPING"},
                { 6, "GROSS INDECENCY"},
                { 7, "DEATH BY RECKLESS DRIVING"},
                { 8, "FIREARMS OFFENCES"},
                { 9, "None"},
                { 0, "Other"}
            };

            bool gotValue = crimConvicValues.TryGetValue(usersAnswer, out string criminalConviction);

            if (!gotValue)
            {
                return string.Empty;
            }
            else
            {
                return criminalConviction;
            }
        }

        public string GetMotorConvictionType(int crimConvicCode)
        {
            var usersCrimConviction = MotoringConvictions(crimConvicCode);

            return usersCrimConviction;
        }
    }
}
