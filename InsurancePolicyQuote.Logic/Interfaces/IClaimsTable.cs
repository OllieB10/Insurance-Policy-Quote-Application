using System.Collections.Generic;

namespace InsurancePolicyQuote.Logic
{
    public interface IClaimsTable
    {
        Dictionary<string, decimal> GetClaimsTable();
    }
}