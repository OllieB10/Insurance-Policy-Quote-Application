using System.Collections.Generic;

namespace InsurancePolicyQuote.Logic
{
    public interface IVehicleValueTable
    {
        Dictionary<string, decimal> GetVehicleValueTable();
    }
}