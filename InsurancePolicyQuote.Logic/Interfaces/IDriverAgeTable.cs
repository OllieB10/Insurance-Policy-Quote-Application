using System.Collections.Generic;

namespace InsurancePolicyQuote.Logic
{
    public interface IDriverAgeTable
    {
        Dictionary<string, decimal> GetDriverAge();
    }
}