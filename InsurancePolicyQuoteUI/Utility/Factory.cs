using InsurancePolicyQuote.Logic;
using System.Collections.Generic;
using System.Text;

namespace InsurancePolicyQuoteUI
{
    public static class Factory
    {
        #region Rating Table Instances

        public static IMinimumPremiumTable CreateMinimumPremiumTable()
        {
            return new MinimumPremiumTable();
        }

        public static IBaseRateTable CreateBaseRateTable()
        {
            return new BaseRateTable();
        }

        public static IClaimsTable CreateClaimsTable()
        {
            return new ClaimsTable();
        }
 
        public static IDriverAgeTable CreateDriverAgeTable()
        {
            return new DriverAgeTable();
        }

        public static ICoverTypeTable CreateCoverTypeTable()
        {
            return new CoverTypeTable();
        }

        public static ISeatsTable CreateSeatsTable()
        {
            return new SeatsTable();
        }

        public static IVehicleTransmissionTable CreateVehicleTransmissionTable()
        {
            return new VehicleTransmissionTable();
        }

        public static IVehicleUseTable CreateVehicleUseTable()
        {
            return new VehicleUseTable();
        }

        public static IVehicleValueTable CreateVehicleValue()
        {
            return new VehicleValueTable();
        }

        #endregion

        public static IDateHelper CreateDateHelper()
        {
            return new DateHelper();
        }
        public static IPolicy CreatePolicy()
        {
            return new Policy();
        }
        public static IProposer CreateProposer()
        {
            return new Proposer();
        }

        public static IVehicle CreateVehicle()
        {
            return new Vehicle();
        }

        public static StringBuilder BuildString()
        {
            return new StringBuilder();
        }

        public static IDriver CreateDriver()
        {
            return new Driver();
        }

        public static IDeclineQuote CreateDeclineQuote()
        {
            return new DeclineQuote();
        }
     
        public static IProposerMessages CreateProposerMessages()
        {
            return new ProposerMessages();
        }

        public static IReadFromConsole ReadFromConsole()
        {
            return new ReadFromConsole();
        }

        public static IValidateUserInput ValidateUserInput()
        {
            return new ValidateUserInput();
        }

        public static IExitApplication ExitApplication()
        {
            return new ExitApplication();
        }

        public static IYesNoInputHandler CreateYesNoInputHandler()
        {
            return new YesNoInputHandler();
        }

        public static IPersonInputDetails CreatePersonInputDetails()
        {
            return new PersonInputDetails();
        }

        public static IVehicleInputDetails CreateVehicleInputDetails()
        {
            return new VehicleInputDetails();
        }

        public static ILicenceInputDetails CreateLicenceInputDetails()
        {
            return new LicenceInputDetails();
        }

        public static ICoverInputDetails CreateCoverInputDetails()
        {
            return new CoverInputDetails();
        }
   
        public static List<MotorClaim> CreateMotorClaims()
        {
            return new List<MotorClaim>();
        }

        public static IDateFormats CreateDateFormats()
        {
            return new DateFormats();
        }

        public static IIncidentInputHandler CreateIncidentInputHandler()
        {
            return new IncidentInputHandler();
        }

        public static IVehicleParkingLocationHandler CreateVehicleParkingLocationHandler()
        {
            return new VehicleParkingLocationHandler();
        }

        public static IDriverInputDetails CreateDriverInputDetails()
        {
            return new DriverInputDetails();
        }

        public static IBlankLine CreateBlankLine()
        {
            return new BlankLine();
        }

        public static IWriteNewLine CreateWriteLine()
        {
            return new WriteNewLine();
        }

        public static IMinimumPremiumChecker CreateMinimumPremiumChecker()
        {
            return new MinimumPremiumChecker();
        }

        public static ICalculation Calculation()
        {
            return new Calculation();
        }

        public static IMotorConvictionsTable CreateMotorConvictionsTable()
        {
            return new MotorConvictionsTable();
        }
    }
}
