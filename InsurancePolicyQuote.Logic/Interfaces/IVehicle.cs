namespace InsurancePolicyQuote.Logic
{
    public interface IVehicle
    {
        string AbiCode { get; set; }
        int AnnualMileage { get; set; }
        string ColourId { get; set; }
        int CubicCapacity { get; set; }
        decimal EstimatedValue { get; set; }
        bool Imported { get; set; }
        string Make { get; set; }
        string Model { get; set; }
        int NoOfSeats { get; set; }
        int NumberOfDoors { get; set; }
        string OperatingArea { get; set; }
        ParkingLocations ParkingLocationOvernight { get; set; }
        decimal PricePaid { get; set; }
        bool RightHandDrive { get; set; }
        VehicleUse VehicleUsage { get; set; }
        int YearOfManufacture { get; set; }
    }
}