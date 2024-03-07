using InsurancePolicyQuote.Logic;

namespace InsurancePolicyQuoteUI
{
    public class MinimumPremiumChecker : IMinimumPremiumChecker
    {
        public decimal CheckMinimumPremium(decimal netPremium, decimal minimumPremium)
        {
            if (netPremium > minimumPremium)
            {
                return netPremium;
            }
            else if (netPremium <= minimumPremium)
            {
                netPremium = minimumPremium;
                return netPremium;
            }
            else
            {
                return netPremium;
            }
        }
    }
}
