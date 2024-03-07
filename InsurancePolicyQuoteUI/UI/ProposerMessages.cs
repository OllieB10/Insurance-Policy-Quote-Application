using InsurancePolicyQuote.Logic;

namespace InsurancePolicyQuoteUI
{
    /// <summary>
    /// Question for each class to answer is....
    /// S....does it have a single responsibility? Yes, this class as it print messages to the user, its single responsibility is to print messages to the user,
    /// O.... Is it Open for extension but closed for modification? 
    /// L.... Is theclass abide by liskov substitu
    /// does it have 1 reason to change? yes, if we need to add a new message it does not impact any other code.
    /// 
    /// </summary>
    public class ProposerMessages : IProposerMessages
    {
        IWriteNewLine writeNewLine = Factory.CreateWriteLine();

        #region Welcome Customer
        /// <summary>
        /// Welcome the user.
        /// </summary>
        public void WelcomeUser()
        {
            //Completed and ready for testing.
            writeNewLine.Write("Welcome to the site, lets get started on your Taxi insurance quote.");
        }

        #endregion

        #region Personal Questions

        //Write messages to the user.
        public void MessageUser(string message)
        {
            writeNewLine.Write(message);
        }

        /// <summary>
        /// Ask the user for their first name.
        /// </summary>
        public void AskFirstName()
        {
            //Completed and ready for testing.
            writeNewLine.Write($"Please enter your first name:  ");
        }

        /// <summary>
        /// Ask the user for their last name.
        /// </summary>
        public void AskLastName()
        {
            //Completed and ready for testing.
            writeNewLine.Write("Please enter your last name:  ");
        }

        /// <summary>
        /// Ask the proposer for their date of birth.
        /// </summary>
        public void AskDateOfBirth()
        {
            //Completed and ready for testing.
            writeNewLine.Write("Please enter your date of birth.  ");
        }

        /// <summary>
        /// Ask the proposer what their gender is.
        /// </summary>
        public void AskGender()
        {
            //Completed and ready for testing.
            writeNewLine.Write("Please enter your gender: Male, Female or Other  ");
        }
        /// <summary>
        /// Ask the proposer for their email address.
        /// </summary>
        public void AskEmailAddress()
        {
            //Completed and ready for testing.
            writeNewLine.Write("Please enter your email address.");
        }

        /// <summary>
        /// Ask proposer for relationship status
        /// </summary>
        public void AskRelationshipStatus()
        {
            // Relationship Status
            writeNewLine.Write("Please choose from one of the following relationship statuses: Married, Single, Separated, Widowed, Diviorced or Living with Partner.");
        }

        #endregion

        #region Driver Messages

        /// <summary>
        /// Ask the proposer if they have been a resident since birth.
        /// </summary>
        public void AskResidentSinceBirth()
        {
            //Completed and ready for testing.
            writeNewLine.Write("Have you been a resident since birth? enter (Yes or No)");
        }

        /// <summary>
        /// Ask the date the proposer has been a resident since, provide date formats for clarification.
        /// </summary>
        public void AskDateResidentSince()
        {
            writeNewLine.Write("Enter the date you have been resident since: ");
        }

        public void AskVehicleUsage()
        {
            writeNewLine.Write("How is the vehicle primarily used? Private Hire, Public Hire or Other.");
        }

        public void AskForPlatedCouncil()
        {
            writeNewLine.Write("What is the name of the council you are allowed to operate out of? ");
        }

        /// <summary>
        /// Ask the proposer for any criminal convictions.
        /// </summary>
        public void AskAnyCriminalConvictions()
        {
            //Completed and ready for testing.
            writeNewLine.Write("Have you got any criminal convictions? enter (Yes or No)");
        }

        public void AskPreviouslyRefusedCover()
        {
            writeNewLine.Write("Have you ever previously been refused cover? enter (Yes or No)");
        }

        public void AskPreviouslyHadTermsApplied()
        {
            writeNewLine.Write("Have you ever had insurance terms applied? enter (Yes or No)");
        }

        public void AskVehicleKeptAtHomeOverNight()
        {
            writeNewLine.Write("Is the taxi kept at home overnight? (Yes or No)");
        }

        public void AskVehicleLocationOverNight()
        {
            writeNewLine.Write("Please choose from one of the following parking locations: Car Park, Garage, Driveway, Street");
        }

        #region Convictions Messages

        public void AskAnyConvictions()
        {
            writeNewLine.Write("Have you had any driving related convictions, endorsements, penalties, disqualified, or bans in the past 5 years? ");
        }

        public void AskOffenceDate()
        {
            writeNewLine.Write("Enter the Offence Date");
        }

        public void AskConvictionDate()
        {
            writeNewLine.Write("On what date were you convicted? ");
        }

        public void AskDisqualifiedFromDriving()
        {
            writeNewLine.Write("Have you previously been disqualified from driving? ");
        }

        public void AskForTotalPoints()
        {
            writeNewLine.Write("How many points did you get.");
        }

        public void AskAnyPointsGiven()
        {
            writeNewLine.Write("How many points did you get.");
        }

        public void AskForFineAmount()
        {
            writeNewLine.Write("How much was the fine you received.");
        }

        public void AskIfFineOccurred()
        {
            writeNewLine.Write("Did the conviction result in a fine? ");
        }

        public void AskAnyCashPaymentsTaken()
        {
            writeNewLine.Write("Any cash payments taken in the taxi.");
        }

        public void AskForTheftType()
        {
            writeNewLine.Write("What type of theft? Theft, Theft of vehicle or Theft Related Damage");
        }

        public void AskForDVLAOffenceCode()
        {
            writeNewLine.Write("What is the offical DVLA offence code/name");
        }

        public void AskHowLongBannedFor()
        {
            writeNewLine.Write("How long were you banned for? ");
        }

        public void AskHowManyMotorConvictions()
        {
            writeNewLine.Write("How many motoring convictions do you currently have? ");
        }

        #endregion

        #region Claims Messages

        public void AskAnyMotorClaims()
        {
            writeNewLine.Write("Have there been any motor claims regardless of fault or whether a claim was filed (Yes or No)");
        }

        public void AskIncidentType()
        {
            writeNewLine.Write("Choose from the two types of incident: Accident or Other");
        }

        public void AskForIncidentdate()
        {
            writeNewLine.Write("");
        }

        public void AskForClaimType()
        {
            writeNewLine.Write("");
        }

        public void AskForClaimStatus()
        {
            writeNewLine.Write("");
        }

        public void AskForClaimAmount()
        {
            writeNewLine.Write("");
        }

        public void AskAtFault()
        {
            writeNewLine.Write("Were you at fault for the accident? (Yes or No)");
        }

        public void AskForClaimDate()
        {
            writeNewLine.Write("What was the incident date? please provide the answer in this format yyyy-MM-dd ");
        }

        public void AskClaimMadeAgainstPolicy()
        {
            writeNewLine.Write("Was the claim made against your taxi insurance policy.");
        }

        public void AskNoClaimsDiscountAffected()
        {
            writeNewLine.Write("Was your no claims discount affected? ");
        }

        public void AskAnyMoreIncidents()
        {
            writeNewLine.Write("Have you had any more incidents in the past? (Yes or No)");
        }

        #endregion

        #endregion

        #region Licence Details Messages

        public void AskForLicenceType()
        {
            writeNewLine.Write($"What type of licence type do you have: ");
        }

        public void AskDateCurrentLicenceObtained()
        {
            writeNewLine.Write($"Enter the date you obtained your current licence: ");
        }

        public void AskWhetherHaveFullUkLicence()
        {
            writeNewLine.Write("Do you have a full UK car licence? (Yes/No)");
        }

        #endregion

        #region Vehicle Messages

        public void AskYearOfManufacture()
        {
            //Completed and ready for testing.
            writeNewLine.Write($"What year was the vehicle manufactured? Give me the answer in the followingg format 'yyyy' e.g 2017 or 1995 ");
        }

        public void AskVehicleMileage()
        {
            writeNewLine.Write($"What is your annual mileage? ");
        }

        public void AskEstimatedVehicleValue()
        {
            writeNewLine.Write("What is the estimated value of your vehicle? ");
        }

        public void AskVehicleImported()
        {
            writeNewLine.Write("Has the vehicle been imported: Enter (Yes/No)");
        }

        public void AskDatePurchasedVehicle()
        {
            writeNewLine.Write($"Whe did you purchase the vehicle: enter the date in one of the following formats dd MMMM yyyy, dd/MM/yyyy, MM/dd/yyyy, yyyy-MM-dd, yyyy-dd-mm, yyyyddmm, yyyymmdd");
        }

        public void AskForNumberOfSeats()
        {
            writeNewLine.Write("How many seats does your vehicle have? ");
        }

        #endregion

        #region Cover Messages 

        public void AskIfProposerRegisteredKeeper()
        {
            writeNewLine.Write("Are you the registered keeper of the vehicle? ");
        }

        public void AskWhoIsLegalOwner()
        {
            writeNewLine.Write("Who is the legal owner of the vehicle? please choose from the option displayed.");
        }

        public void AskWhatCoverTheyWant()
        {
            writeNewLine.Write("Choose the type of cover you are after. Comprehensive, Third Party Fire and Theft, Third Party Only.");
        }

        public void AskPolicyStartDate()
        {
            writeNewLine.Write("What date would you like the cover to start.");
        }

        public void AskHowManyNCD()
        {
            writeNewLine.Write("How many years no claims bonus do you have?");
        }

        public void AskProtectNCB()
        {
            writeNewLine.Write("Would you like to protect your No Claims Bonus? ");
        }

        public void AskVehicleTransmissionType()
        {
            writeNewLine.Write("What vehicle transmission type is your vehicle? (Manual or Automatic)");
        }

        #endregion
    }
}
