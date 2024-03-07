using InsurancePolicyQuote.Logic;
using InsurancePolicyQuoteUI;
using System;
using System.Linq;

namespace InsurancePolicyQuoteUI
{
    public class LicenceInputDetails : ILicenceInputDetails
    {
        IReadFromConsole readFromConsole = Factory.ReadFromConsole();
        IProposerMessages proposerMessages = Factory.CreateProposerMessages();
        IExitApplication exitApplication = Factory.ExitApplication();
        private bool CheckValidLicenceType(LicenceType licenceType)
        {
            LicenceType[] allowedLicences = { LicenceType.FullEuLicence, LicenceType.FullEuropean, LicenceType.FullInternational, LicenceType.Other };

            return allowedLicences.Contains(licenceType);
        }

        public LicenceType GetValidLicenceType(string input)
        {
            LicenceType licenceType;

            //if the user input is invalid then keep them looped until input is valid unless they choose to exit. 
            while (!Enum.TryParse(input, true, out licenceType) || CheckValidLicenceType(licenceType))
            {
                //Inform the user they have entered an invalid incident type and display them again.
                proposerMessages.MessageUser("You have entered an invalid incident type, it must not contain any special characters or must be either 'Accident', 'Theft' or 'Other', type exit to exit the application or type a valid vehicle use to continue with the quote. ");

                input = readFromConsole.ReadInputFromConsole();

                //Provide the user with the choice to exit.
                exitApplication.CheckAndExitIfRequested(input);
            }

            return licenceType;
        }

    }
}
