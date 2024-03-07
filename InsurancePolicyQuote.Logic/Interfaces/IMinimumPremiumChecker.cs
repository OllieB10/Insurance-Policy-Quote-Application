namespace InsurancePolicyQuote.Logic
{
    public interface IMinimumPremiumChecker
    {
        decimal CheckMinimumPremium(decimal netPremium, decimal minimumPremium);
    }
}