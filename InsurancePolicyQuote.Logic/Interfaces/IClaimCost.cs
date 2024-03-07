namespace InsurancePolicyQuote.Logic
{
    public interface IClaimCost
    {
        bool CheckClaimAmount(string input);
        decimal GetClaimCost(string input);
    }
}