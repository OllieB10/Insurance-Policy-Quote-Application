
using InsurancePolicyQuote.Logic;


namespace InsurancePolicyQuoteUI
{
    public class VehicleParkingLocationHandler : IVehicleParkingLocationHandler
    {
        IProposerMessages proposerMessages = Factory.CreateProposerMessages();
        IReadFromConsole readFromConsole = Factory.ReadFromConsole();
        IVehicleInputDetails vehicleInputDetails = Factory.CreateVehicleInputDetails();
        IBlankLine blankLine = Factory.CreateBlankLine();
        IValidateUserInput validateUserInput = Factory.ValidateUserInput();

        public ParkingLocations GetParkingLocationOvernight(bool isAtHome)
        {
            ParkingLocations parkingLocation;

            // If the vehicle is parked at home then determine if its on the drive, in a garage, car park etc.
            if (isAtHome)
            {
                blankLine.CreateBlankLine();

                proposerMessages.AskVehicleLocationOverNight();
                string vehicleLocationOvernightAnswer = readFromConsole.ReadInputFromConsole();

                vehicleLocationOvernightAnswer = validateUserInput.FormatInputString(vehicleLocationOvernightAnswer);

                return parkingLocation = vehicleInputDetails.GetValidParkingLocation(vehicleLocationOvernightAnswer);
            }
            // It must not be parked at home, therefore store other.
            else
            {
                // We dont bother asking for more information we just use Other.
                return parkingLocation = ParkingLocations.Other;
            }
        }
    }
}
