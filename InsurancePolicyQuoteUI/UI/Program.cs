using InsurancePolicyQuote.Logic;
using System;
using System.Collections.Generic;

namespace InsurancePolicyQuoteUI
{
    class Program
    {          
        private static void Main()
        {           
            IProposerMessages proposerMessages = Factory.CreateProposerMessages();
            IPolicy policy = Factory.CreatePolicy();
            IProposer proposer = Factory.CreateProposer();
            IReadFromConsole readFromConsole = Factory.ReadFromConsole();
            IValidateUserInput validateUserInput = Factory.ValidateUserInput();
            IYesNoInputHandler yesNoInputHandler = Factory.CreateYesNoInputHandler();
            IPersonInputDetails personInputDetails = Factory.CreatePersonInputDetails();
            IVehicle vehicle = Factory.CreateVehicle();
            IDriver driver = Factory.CreateDriver();
            IVehicleInputDetails vehicleInputDetails = Factory.CreateVehicleInputDetails();
            ILicenceInputDetails licenceInputDetails = Factory.CreateLicenceInputDetails();
            ICoverInputDetails coverInputDetails = Factory.CreateCoverInputDetails();                     
            List<MotorClaim> motorClaims = Factory.CreateMotorClaims();
            IDateFormats dateFormats = Factory.CreateDateFormats();
            IIncidentInputHandler incidentInputHandler = Factory.CreateIncidentInputHandler();
            IVehicleParkingLocationHandler vehicleParkingLocationHandler = Factory.CreateVehicleParkingLocationHandler();
            IDriverInputDetails driverInputDetails = Factory.CreateDriverInputDetails();
            IBlankLine blankLine = Factory.CreateBlankLine();          
            IDateHelper dateHelper = Factory.CreateDateHelper();          
            IMinimumPremiumChecker minimumPremiumChecker = Factory.CreateMinimumPremiumChecker();        
            IDeclineQuote declineQuote = Factory.CreateDeclineQuote();
            ICalculation calculation = Factory.Calculation();

            #region Welcome User

            // Welcome the user to the application.
            proposerMessages.WelcomeUser();

            #endregion

            // Blank line.
            blankLine.CreateBlankLine();

            /*********************** Proposer Details Main Body Section Starts ********************************/

            #region Person Details

            #region First Name

            //Ask for the users first name.
            proposerMessages.AskFirstName();
            string firstName = readFromConsole.ReadInputFromConsole();
         
            proposer.FirstName = validateUserInput.GetValidUserInput(firstName);

            #endregion

            // Store the valid last name.
            blankLine.CreateBlankLine();

            #region Last Name

            //Ask for the users last name.
            proposerMessages.AskLastName();
            string lastName = readFromConsole.ReadInputFromConsole();

            proposer.LastName = validateUserInput.GetValidUserInput(lastName);

            #endregion

            // Create blank line.
            blankLine.CreateBlankLine();

            #region Date of Birth

            //Ask the user for their Date of Birth.
            proposerMessages.AskDateOfBirth();
            string dateOfBirthAnswer = readFromConsole.ReadInputFromConsole();
           
            // Date of birth.
            proposer.DateOfBirth = dateFormats.GetValidDate(dateOfBirthAnswer);

            #endregion

            // Create blank line.
            blankLine.CreateBlankLine();

            #region Gender

            // Ask the proposer for their gender.
            proposerMessages.AskGender();
            string genderAnswer = readFromConsole.ReadInputFromConsole();

            // Get the valid gender.
            Gender gender = personInputDetails.GetValidGender(genderAnswer);

            #endregion

            blankLine.CreateBlankLine();

            #region Email Address

            // Ask the proposer for their email address.
            proposerMessages.AskEmailAddress();
            string email = readFromConsole.ReadInputFromConsole();

            proposer.EmailAddress = personInputDetails.GetValidEmailAddress(email);

            #endregion 

            blankLine.CreateBlankLine();

            #region Relationship Status

            // Ask proposer for their relationship status.
            proposerMessages.AskRelationshipStatus();
            string relationshipStatusAnswer = readFromConsole.ReadInputFromConsole();

            // Store the relationship status.
            proposer.RelationshipStatus = personInputDetails.GetValidRelationshipStatus(relationshipStatusAnswer);

            #endregion

            #endregion

            blankLine.CreateBlankLine();

            /*********************** Vehicle Main Body Section Starts ********************************/

            #region Vehicle Details           

            #region Year of Manufacture

            //Ask the proposer for the year of manufacture and Store the users answer.
            proposerMessages.AskYearOfManufacture();
            string yearOfManufactureAnswer = readFromConsole.ReadInputFromConsole();

            vehicle.YearOfManufacture = dateFormats.GetYear(yearOfManufactureAnswer);

            #endregion

            blankLine.CreateBlankLine();

            #region Vehicle Seats

            proposerMessages.AskForNumberOfSeats();
            string numberOfSeatsAnswer = readFromConsole.ReadInputFromConsole();

            vehicle.NoOfSeats = vehicleInputDetails.GetNumberOfSeats(numberOfSeatsAnswer);

            #endregion

            blankLine.CreateBlankLine();

            #region Vehicle Value

            proposerMessages.AskEstimatedVehicleValue();
            string vehicleEstimatedValueAnswer = readFromConsole.ReadInputFromConsole();

            vehicle.EstimatedValue = vehicleInputDetails.GetEstimatedVehicleValue(vehicleEstimatedValueAnswer);

            if (vehicle.EstimatedValue > 70000.00M)
            {
                declineQuote.Decline("The vehicles estimated value is too high, we cannot provide you with a quote.");
            }
            else if (vehicle.EstimatedValue < 2000.00M)
            {
                declineQuote.Decline("The vehicles estimated value is too low, we cannot provide you with a quote.");
            }

            #endregion

            blankLine.CreateBlankLine();

            #region Vehicle Transmissions

            proposerMessages.AskVehicleTransmissionType(); // e.g Manual or Automatic
            string vehicleTransAnswer = readFromConsole.ReadInputFromConsole();

            VehicleTransmission vehicleTransmission = vehicleInputDetails.GetValidVehicleTransmission(vehicleTransAnswer);

            #endregion

            #endregion

            blankLine.CreateBlankLine();

            /*********************** Vehicle Main Body Section Ends ********************************/


            /***********************Driver Main Body Section Starts********************************/

            #region Driver Details

            #region Previously Refused Cover

            proposerMessages.AskPreviouslyRefusedCover();
            string refusedCoverAnswer = readFromConsole.ReadInputFromConsole();

            driver.InsurancePreviouslyRefused = yesNoInputHandler.ReturnTrueOrFalse(refusedCoverAnswer);

            blankLine.CreateBlankLine();

            if (driver.InsurancePreviouslyRefused)
            {
                declineQuote.Decline("Sorry, we do not allow those who have previously been refused cover to get a quote.");
            }

            #endregion

            #region Previously Had Terms Applied.

            proposerMessages.AskPreviouslyHadTermsApplied();
            string previousTermsApplied = readFromConsole.ReadInputFromConsole();

            driver.PreviouslyHadTermsApplied = yesNoInputHandler.ReturnTrueOrFalse(previousTermsApplied);

            blankLine.CreateBlankLine();

            if (driver.PreviouslyHadTermsApplied)
            {
                declineQuote.Decline("Sorry, we do not allow those who have previously had their insurance terms applied to get a quote.");
            }

            #endregion

            #region Disqualified from Driving

            proposerMessages.AskDisqualifiedFromDriving();
            string disqualifiedFromDriving = readFromConsole.ReadInputFromConsole();

            driver.DisqualifiedFromDriving = yesNoInputHandler.ReturnTrueOrFalse(disqualifiedFromDriving);

            blankLine.CreateBlankLine();

            if (driver.DisqualifiedFromDriving)
            {
                declineQuote.Decline("Sorry, we do not allow those who have previously been disqualified from driving to get a quote.");
            }

            #endregion

            #region Vehicle Use

            // Ask for the vehicle use.
            proposerMessages.AskVehicleUsage();  // Public Hire, Private Hire or Other.
            string vehicleUseAnswer = readFromConsole.ReadInputFromConsole();

            // Get the correct vehicle use.
            vehicle.VehicleUsage = vehicleInputDetails.GetVehicleUsage(vehicleUseAnswer);

            #endregion

            blankLine.CreateBlankLine();

            #region Parking Overnight

            proposerMessages.AskVehicleKeptAtHomeOverNight();
            string vehicleHomeNightAnswer = readFromConsole.ReadInputFromConsole();

            bool isAtHome = yesNoInputHandler.ReturnTrueOrFalse(vehicleHomeNightAnswer);

            // Store our parking location overnight value.
            vehicle.ParkingLocationOvernight = vehicleParkingLocationHandler.GetParkingLocationOvernight(isAtHome);

            #endregion

            blankLine.CreateBlankLine();

            #region Criminal Convictions

            proposerMessages.AskAnyCriminalConvictions();
            string criminalConvictionsAnswer = readFromConsole.ReadInputFromConsole();

            if (yesNoInputHandler.ReturnTrueOrFalse(criminalConvictionsAnswer))
            {
                declineQuote.Decline("Sorry, We do not allow drivers who have criminal convictions on this scheme.");
            }

            #endregion      

            blankLine.CreateBlankLine();

            #region Motor Claims

            // Ask the user if they have had any Motor Claims.
            proposerMessages.AskAnyMotorClaims();
            string incidentsAnswer = readFromConsole.ReadInputFromConsole();

            // Get a yes or No response which we convert to true or false.
            bool hasIncidents = yesNoInputHandler.ReturnTrueOrFalse(incidentsAnswer);

            blankLine.CreateBlankLine();

            // Types include, Accident and Other.
            IncidentType incidentType;

            // We need to loop through each claim question if the user has had claims.
            while (hasIncidents)
            {
                // Ask for the incident type.
                proposerMessages.AskIncidentType();
                string incidentAnswer = readFromConsole.ReadInputFromConsole();

                blankLine.CreateBlankLine();

                // Store the incident type as an enum value to be used later.
                incidentType = driverInputDetails.GetValidIncidentType(incidentAnswer);

                // If we have an accident incident type.
                if (incidentType == IncidentType.Accident)
                {
                    // 1. At fault? (Yes/No).
                    proposerMessages.AskAtFault();
                    string faultAnswer = readFromConsole.ReadInputFromConsole();

                    // Save the details for later use.
                    motorClaims.Add( new MotorClaim { AtFault = yesNoInputHandler.ReturnTrueOrFalse(faultAnswer), IncidentType = incidentType } );
                }               
                // If not AccidentType then save Other.
                else
                {
                    // 1. At fault? (Yes/No).
                    proposerMessages.AskAtFault();
                    string faultAnswer = readFromConsole.ReadInputFromConsole();

                    // Save the details for later use.
                    motorClaims.Add(new MotorClaim { AtFault = yesNoInputHandler.ReturnTrueOrFalse(faultAnswer), IncidentType = incidentType });
                }

                blankLine.CreateBlankLine();

                // Ask for anymore incidents.
                proposerMessages.AskAnyMoreIncidents();               
                string moreIncidentsAnswer = readFromConsole.ReadInputFromConsole();

                // Determine if we have more incidents to add.
                bool moreIncidents = yesNoInputHandler.ReturnTrueOrFalse(moreIncidentsAnswer);

                // Check for any more Claims.
                hasIncidents = incidentInputHandler.CheckMoreIncidents(moreIncidents);

                blankLine.CreateBlankLine();
            }

            #endregion

            #region Motoring Convictions

            // Ask how many motoring convictions.
            proposerMessages.AskHowManyMotorConvictions();
            string numberOfMotConAnswer = readFromConsole.ReadInputFromConsole();

            // Validate the answer.
            int motorConvictions = validateUserInput.GetValidInteger(numberOfMotConAnswer);

            #endregion - Ready for testing.

            blankLine.CreateBlankLine();

            #region Full Uk Licence

            // Ask the user if they have a full UK driving licence and get the answer.
            proposerMessages.AskWhetherHaveFullUkLicence();
            string fullUkLicenceAnswer = readFromConsole.ReadInputFromConsole();

            blankLine.CreateBlankLine();

            // If the user does not have a full UK Licence type then we cannot provide a quote.
            if (!yesNoInputHandler.ReturnTrueOrFalse(fullUkLicenceAnswer))
            {
                // We only accept Full Uk Licence types.
                declineQuote.Decline("We only accept full UK driving licence types, we cannot provide you with a quote; Press enter to exit the quote journey.");
            }

            #endregion

            #endregion

            blankLine.CreateBlankLine();

            /***********************Driver Main Body Section Ends********************************/
         
                               
            /***********************Cover Details Main Body Section Starts********************************/

            #region Cover Type

            // Type of Cover looking for - including Comprehensive, Third Party Fire and Theft, Third Party Only
            proposerMessages.AskWhatCoverTheyWant();
            string coverAnswer = readFromConsole.ReadInputFromConsole();

            CoverType cover = coverInputDetails.GetCoverType(coverAnswer);

            #endregion 

            blankLine.CreateBlankLine();

            #region Policy Start Date

            // Dates the user wants the cover to start.
            proposerMessages.AskPolicyStartDate();
            string chosenStartDateAnswer = readFromConsole.ReadInputFromConsole();

            DateTime chosenStartDate = dateFormats.GetValidDate(chosenStartDateAnswer);

            while(chosenStartDate.Date <= DateTime.Today)
            {
                proposerMessages.MessageUser("You must choose a future date, earliest starting date is from tomorrow, please enter your start date again.");
                chosenStartDateAnswer = readFromConsole.ReadInputFromConsole();

                chosenStartDate = dateFormats.GetValidDate(chosenStartDateAnswer);
            }

            #endregion

            blankLine.CreateBlankLine();

            #region NCD Years

            // Years NCD the user has.
            proposerMessages.AskHowManyNCD();
            string ncdAnswer = readFromConsole.ReadInputFromConsole();

            // Store the amount of No Claims Bonus the user has.
            NCB ncb = coverInputDetails.GetNCDAmount(ncdAnswer);

            #endregion

            /***********************Cover Details Main Body Section Ends********************************/


            /***********************Calculate Rate Main Body Section Starts********************************/

            #region Calculate Premium

            #region Base Rate Calculation

            // Set the Premium to the base rate.
            policy.NetPremium = calculation.CalculateBaseRate(ncb);

            #endregion

            #region Driver Age Calculation

            int yearAtInception = dateHelper.GetAgeDifference(proposer.DateOfBirth, chosenStartDate);

            // This needs to be placed in our factory to adhere to Dependency Inversion.
            DriverAges driverAge = driverInputDetails.GetDriverAgeEnum(yearAtInception);

            // Multiply the rate from the age table to get the new Net premium total.
            policy.NetPremium = policy.NetPremium * calculation.CalculateDriversAge(ncb, driverAge);

            #endregion

            #region Vehicle Value Calculation

            // Factor the estimated vehicle value into the price.
            policy.NetPremium = policy.NetPremium * calculation.CalculateVehicleValue(vehicle);

            #endregion

            #region Vehicle Use Calculation

            // Factor in the Vehicle Use Value to the Net premium.
            policy.NetPremium = policy.NetPremium * calculation.CalculateVehicleUse(vehicle.VehicleUsage);

            #endregion

            #region Vehicle Seats Calculation

            policy.NetPremium = policy.NetPremium * calculation.CalculateVehicleSeatsRate(vehicle);

            #endregion

            #region Vehicle Transmission Calculation

            policy.NetPremium = policy.NetPremium * calculation.CalculateVehicleTransmissionRate(vehicleTransmission);

            #endregion

            #region Minimum Premium Calculation
           
            policy.NetPremium = minimumPremiumChecker.CheckMinimumPremium(policy.NetPremium, calculation.CalculateMinimumPremium(ncb));

            #endregion

            #region Motor Claims Calculation

            policy.NetPremium = policy.NetPremium * calculation.CalculateClaimsRate(motorClaims, ncb);

            #endregion

            #region Motor Convictions Calculation

            policy.NetPremium = policy.NetPremium * calculation.CalculateMotorConvictions(motorConvictions);

            policy.NetPremium = Math.Round(policy.NetPremium,2);

            #endregion

            #endregion

            /*********************** Calculate Rate Main Body Section Ends ********************************/

            /*********************** Display Premium Price Main Body Section Starts ********************************/

            proposerMessages.MessageUser($"Personal Information:");
            proposerMessages.MessageUser($"Full Name: {proposer.FirstName} {proposer.LastName}");
            proposerMessages.MessageUser($"Date of Birth: {proposer.DateOfBirth.ToString()}");
            proposerMessages.MessageUser($"Gender: {gender.ToString()}");
            proposerMessages.MessageUser($"Email Address: {proposer.EmailAddress}");
            string relationshipStatus = (proposer.RelationshipStatus == RelationshipStatus.LivingWithPartner) ? "Living With Partner" : proposer.RelationshipStatus.ToString();
            proposerMessages.MessageUser($"Relationship Status: {relationshipStatus}");
            blankLine.CreateBlankLine();
            proposerMessages.MessageUser($"Vehicle Information:");
            proposerMessages.MessageUser($"Year of Manufacture: {vehicle.YearOfManufacture.ToString()}");
            proposerMessages.MessageUser($"Vehicle Seats: {vehicle.NoOfSeats.ToString()}");
            proposerMessages.MessageUser($"Vehicle Value: £{vehicle.EstimatedValue.ToString()}");
            proposerMessages.MessageUser($"Vehicle Transmission: {vehicleTransmission.ToString()}");
            blankLine.CreateBlankLine();
            proposerMessages.MessageUser($"Driver Information: ");
            string vehicleUse = (vehicle.VehicleUsage == VehicleUse.PublicHire) ? "Public Hire" : (vehicle.VehicleUsage == VehicleUse.PrivateHire) ? "Private Hire" : "Other";
            proposerMessages.MessageUser($"Vehicle Use: {vehicleUse}");
            proposerMessages.MessageUser($"Parking Location Overnight: {vehicle.ParkingLocationOvernight.ToString()}");
            proposerMessages.MessageUser($"Total Claims: {motorClaims.Count}");
            proposerMessages.MessageUser($"Total Motor Convictions: {motorConvictions}");
            blankLine.CreateBlankLine();
            proposerMessages.MessageUser($"Cover Information: ");
            string coverAsString = (cover == CoverType.ThirdPartyFireAndTheft) ? "Third Party FireAnd Theft" : (cover == CoverType.ThirdPartyOnly) ? "Third Party Only" : cover.ToString(); ;
            proposerMessages.MessageUser($"Cover Type: {coverAsString}");
            proposerMessages.MessageUser($"Start Date: {chosenStartDate.ToString()}");
            proposerMessages.MessageUser($"No Claims Bonus: {ncb}");
            blankLine.CreateBlankLine();
            proposerMessages.MessageUser($"Price");
            proposerMessages.MessageUser($"Total Net Premium Excluding IPT £{policy.NetPremium}");

            proposerMessages.MessageUser($"Please close the application");
            /*********************** Diplay Premium Price Main Body Section Ends ********************************/

            //Keep the console window open until purposefully closed.
            readFromConsole.ReadInputFromConsole();
        }
    }
}
