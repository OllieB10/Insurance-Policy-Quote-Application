using System.Collections.Generic;

namespace InsurancePolicyQuote.Logic
{
    public interface ICalculation
    {
        decimal CalculateBaseRate(NCB ncb);
        decimal CalculateDriversAge(NCB ncb, DriverAges driverAge);
        decimal CalculateVehicleValue(IVehicle vehicle);
        decimal CalculateVehicleUse(VehicleUse vehicleUse);
        decimal CalculateVehicleSeatsRate(IVehicle vehicle);
        decimal CalculateVehicleTransmissionRate(VehicleTransmission vehicleTransmission);
        decimal CalculateMinimumPremium(NCB ncb);
        decimal CalculateClaimsRate(List<MotorClaim> motorClaims, NCB ncb);
        decimal CalculateMotorConvictions(int motorConvictions);
    }
}