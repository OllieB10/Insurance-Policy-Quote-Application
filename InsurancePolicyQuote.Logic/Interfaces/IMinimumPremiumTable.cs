using System.Collections.Generic;

namespace InsurancePolicyQuote.Logic
{
    public interface IMinimumPremiumTable
    {
        Dictionary<NCB, decimal> GetMinimumPremiumTable();
    }
}