using System.Collections.Generic;

namespace InsurancePolicyQuote.Logic
{
    public interface ICoverTypeTable
    {
        Dictionary<string, decimal> GetCoverTable();
    }
}