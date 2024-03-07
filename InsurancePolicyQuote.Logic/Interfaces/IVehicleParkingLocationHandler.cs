
namespace InsurancePolicyQuote.Logic
{
    public interface IVehicleParkingLocationHandler
    {
        ParkingLocations GetParkingLocationOvernight(bool isAtHome);
    }
}