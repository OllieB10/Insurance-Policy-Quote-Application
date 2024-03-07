using System.Collections.Generic;

namespace InsurancePolicyQuote.Logic
{
    public interface IVehicleAgeTable
    {
        Dictionary<string, decimal> GetVehicleAgeTable();
    }
}