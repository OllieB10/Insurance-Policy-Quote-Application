using System.Collections.Generic;

namespace InsurancePolicyQuote.Logic
{
    public interface IVehicleTransmissionTable
    {
        Dictionary<VehicleTransmission, decimal> GetVehicleTransmissionsTable();
    }
}