using System.Collections.Generic;

namespace InsurancePolicyQuote.Logic
{
    public interface IVehicleUseTable
    {
        Dictionary<VehicleUse, decimal> GetVehicleUseTable();
    }
}