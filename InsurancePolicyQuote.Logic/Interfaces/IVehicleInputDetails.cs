
namespace InsurancePolicyQuote.Logic
{
    public interface IVehicleInputDetails
    {
        bool CheckNumberOfSeats(string input);
        int GetNumberOfSeats(string input);
        ParkingLocations GetValidParkingLocation(string input);
        VehicleUse GetVehicleUsage(string input);
        decimal GetEstimatedVehicleValue(string input);
        VehicleTransmission GetValidVehicleTransmission(string input);
    }
}