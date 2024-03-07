using System;
using System.Linq;
using InsurancePolicyQuote.Logic;
using InsurancePolicyQuoteUI;

namespace InsurancePolicyQuoteUI
{
    public class DriverInputDetails : IDriverInputDetails
    {
        IExitApplication exitApplication = Factory.ExitApplication();
        IReadFromConsole readFromConsole = Factory.ReadFromConsole();
        IProposerMessages proposerMessages = Factory.CreateProposerMessages();
        IValidateUserInput validateUserInput = Factory.ValidateUserInput();

        private bool CheckValidIncidentType(IncidentType incidentType)
        {
            IncidentType[] allowedIncidents = { IncidentType.Other, IncidentType.Accident };

            return allowedIncidents.Contains(incidentType);
        }

        public IncidentType GetValidIncidentType(string input)
        {
            input = validateUserInput.GetValidUserInput(input);

            IncidentType incidentType;

            //if the user input is invalid then keep them looped until input is valid unless they choose to exit. 
            while (!Enum.TryParse(input, true, out incidentType) && CheckValidIncidentType(incidentType))
            {
                //Inform the user they have entered an invalid incident type and display them again.
                proposerMessages.MessageUser("You have entered an invalid incident type, it must not contain any special characters or must be either 'Accident' or 'Other', type exit to exit the application or type a valid vehicle use to continue with the quote. ");

                input = readFromConsole.ReadInputFromConsole();

                //Provide the user with the choice to exit.
                exitApplication.CheckAndExitIfRequested(input);
            }

            return incidentType;
        }

        public DriverAges GetDriverAgeEnum(int yearAtInception)
        {
            DriverAges driverAge = new DriverAges();

            if (yearAtInception >= 70)
            {
                driverAge = DriverAges.SeventyPlus;
            }
            else if (yearAtInception >= 25 && yearAtInception < 30)
            {
                driverAge = DriverAges.TwentyFiveToTwentyNine;
            }
            else if (yearAtInception >= 30 && yearAtInception < 35)
            {
                driverAge = DriverAges.ThirtyToThirtyFour;
            }
            else if (yearAtInception >= 35 && yearAtInception < 40)
            {
                driverAge = DriverAges.ThirtyFiveToThirtyNine;
            }
            else if (yearAtInception >= 40 && yearAtInception < 45)
            {
                driverAge = DriverAges.FortyToFortyFour;
            }
            else if (yearAtInception >= 45 && yearAtInception < 50)
            {
                driverAge = DriverAges.FortyFiveToFortyNine;
            }
            else if (yearAtInception >= 50 && yearAtInception < 70)
            {
                driverAge = DriverAges.FiftyToSixtyNine;
            }

            return driverAge;
        }
    }
}
