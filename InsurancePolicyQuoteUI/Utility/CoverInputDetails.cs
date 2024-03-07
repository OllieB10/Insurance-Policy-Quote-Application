using InsurancePolicyQuote.Logic;
using System;
using System.Linq;

namespace InsurancePolicyQuoteUI
{
    public class CoverInputDetails : ICoverInputDetails
    {
        IReadFromConsole readFromConsole = Factory.ReadFromConsole();
        IExitApplication exitApplication = Factory.ExitApplication();
        IProposerMessages proposerMessages = Factory.CreateProposerMessages();
        IValidateUserInput validateUserInput = Factory.ValidateUserInput();

        private bool CheckCoverType(CoverType coverType)
        {
            CoverType[] allowedCCoverTypes = { CoverType.Comprehensive, CoverType.ThirdPartyFireAndTheft, CoverType.ThirdPartyOnly };

            return allowedCCoverTypes.Contains(coverType);
        }

        private bool CheckNcdAmount(NCB ncb)
        {
            NCB[] allowedNcbs = { NCB.NewBadge, NCB.Zero, NCB.One, NCB.Two, NCB.Three, NCB.Four, NCB.Five, NCB.SixPlus };

            return allowedNcbs.Contains(ncb);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public NCB GetNCDAmount(string input)
        {
            NCB ncb;

            int ncbNumber = validateUserInput.GetValidInteger(input);

            if (ncbNumber >= 6)
            {
                ncb = NCB.SixPlus;
            }
            else if (ncbNumber == 0)
            {
                ncb = NCB.Zero;
            }
            else if (ncbNumber == 1)
            {
                ncb = NCB.One;
            }
            else if (ncbNumber == 2)
            {
                ncb = NCB.Two;
            }
            else if (ncbNumber == 3)
            {
                ncb = NCB.Three;
            }
            else if (ncbNumber == 4)
            {
                ncb = NCB.Four;
            }
            else if (ncbNumber == 5)
            {
                ncb = NCB.Five;
            }

            //if the user input is invalid then keep them looped until input is valid unless they choose to exit. 
            while (!Enum.TryParse(input, true, out ncb) || !CheckNcdAmount(ncb))
            {
                proposerMessages.MessageUser("You have entered an invalid NCB amount, it must not contain any special characters or must be  one of the amounts in the prior message, type exit to exit the application or type a valid legal owner to continue with the quote. ");

                input = readFromConsole.ReadInputFromConsole();

                //Provide the user with the choice to exit.
                exitApplication.CheckAndExitIfRequested(input);
            }

            return ncb;
        }

        public CoverType GetCoverType(string input)
        {
            input = validateUserInput.FormatInputString(input);

            CoverType coverType;

            //if the user input is invalid then keep them looped until input is valid unless they choose to exit. 
            while (!Enum.TryParse(input, true, out coverType) || !CheckCoverType(coverType))
            {
                proposerMessages.MessageUser("You have entered an invalid cover type, please enter it again or type 'exit' to quit.");
                input = readFromConsole.ReadInputFromConsole();

                input = validateUserInput.FormatInputString(input);

                //Provide the user with the choice to exit.
                exitApplication.CheckAndExitIfRequested(input);
            }

            return coverType;
        }
    }
}
