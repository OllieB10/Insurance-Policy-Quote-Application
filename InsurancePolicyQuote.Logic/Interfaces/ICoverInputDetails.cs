
namespace InsurancePolicyQuote.Logic
{
    public interface ICoverInputDetails
    {
        CoverType GetCoverType(string input);
        NCB GetNCDAmount(string input);
    }
}