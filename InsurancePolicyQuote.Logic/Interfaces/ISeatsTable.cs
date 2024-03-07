using System.Collections.Generic;

namespace InsurancePolicyQuote.Logic
{
    public interface ISeatsTable
    {
        Dictionary<VehicleSeats, decimal> GetSeatsTable();
    }
}