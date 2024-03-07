
using System.Collections.Generic;

namespace InsurancePolicyQuote.Logic
{
    public interface IBaseRateTable
    {
        Dictionary<NCB, decimal> GetBaseRateTable();
    }
}