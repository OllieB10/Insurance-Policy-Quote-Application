namespace InsurancePolicyQuote.Logic
{
    public class Vehicle : IVehicle
    {
        public int YearOfManufacture { get; set; }
        public string OperatingArea { get; set; }
        public int NumberOfDoors { get; set; }
        public int CubicCapacity { get; set; }
        public int NoOfSeats { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string AbiCode { get; set; }
        public decimal EstimatedValue { get; set; }
        public bool RightHandDrive { get; set; }
        public int AnnualMileage { get; set; }
        public decimal PricePaid { get; set; }
        public string ColourId { get; set; }
        public bool Imported { get; set; }
        public VehicleUse VehicleUsage { get; set; }
        public ParkingLocations ParkingLocationOvernight { get; set; }
    }
}
