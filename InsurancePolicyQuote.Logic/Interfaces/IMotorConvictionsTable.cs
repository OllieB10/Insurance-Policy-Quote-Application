using System.Collections.Generic;

namespace InsurancePolicyQuote.Logic
{
    public interface IMotorConvictionsTable
    {
        Dictionary<string, decimal> GetMotorConvictionsTable();
    }
}